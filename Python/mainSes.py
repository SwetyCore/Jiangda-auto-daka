import time
from random import randint

import sys

from log1 import l
import json
from mailsender import mail, failedmail
from loginRe import Login
import os


def showRedirectHistory(reditList):
    text = f'重定向次数:{len(reditList)}\n'
    l.info(text)
    for item in reditList:
        # l.info(f'重定向链接:{item.headers["location"]}')
        ''

def daka(ses):
    dakaAPI = "http://yun.ujs.edu.cn/xxhgl/yqsb/grmrsb?v=3097"

    # l.info(f'初始化...\napi={dakaAPI}')
    ses.headers = {
        # 'Host': 'yun.ujs.edu.cn',
        'user-agent': 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/86.0.4240.193 Safari/537.36 Edg/86.0.622.68'
    }
    tem1 = randint(355, 365) / 10
    tem2 = randint(355, 365) / 10
    l.info("随机体温为:{}和{}".format(tem1, tem2))

    data = {}
    while not os.path.exists('./data.json'):
        l.warn('请在运行目录下放入data.json后输入回车以继续...')
        input()

    data = json.load(open('./data.json', 'r', encoding='utf-8'))
    data['xwwd'] = tem1
    data['swwd'] = tem2

    # for key, value in data.items():
    #     print(f"{key}:{value}")

    l.info("表单创建完毕!!" + "\n")

    '''
    headers = {
         'origin': 'http://yun.ujs.edu.cn',
         'referer': 'http://yun.ujs.edu.cn/xxhgl/yqsb/grmrsb?v=6949',
         'user-agent': 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/86.0.4240.193 Safari/537.36 Edg/86.0.622.68',
         'cookie': f'_csrf-cloud={csrf_cloud}; cloud_sessionID={cloud_sessionID}'
     } 如果利用cookie的方式访问需要的参数
     '''

    l.info("提交表单ing...")
    response = ses.post(url=dakaAPI, data=data)
    reditList = response.history
    showRedirectHistory(reditList)
    response = ses.get(url=reditList[len(reditList) - 1].headers["location"])
    reditList = response.history
    showRedirectHistory(reditList)

    response = ses.post(url=dakaAPI, data=data)
    text = response.content
    l.info("写入返回结果...")
    with open("testpost.html", 'wb') as resHtml:
        resHtml.write(text)

    l.info('发送邮件....')
    mail()

    with open("./log.txt", 'a')as fn:
        fn.write("本次打卡执行完毕。\n---------------------------------\n\n\n\n")


if __name__ == '__main__':
    print('可以使用json转换工具来得到data.json嗷!')
    sys.stdout.flush()
    # appkey = input('输入ocr的key:')
    # username = input('输入学号: ')
    # password = getpass.getpass("密码: ")
    config = json.load(open('config.json', 'r'))
    # print(config)
    username = config['username']
    password = config['password']
    # password = input()
    lg = Login()
    try1=0
    notlogin=None
    try:
        while notlogin == None:
            ses = lg.Login(username=username, password=password)
            notlogin = ses
            try1 += 1
            if try1 > 3:
                failedmail()
                l.error('未能成功登陆')
        daka(ses)
    except Exception as msg:
        l.error(msg)
        failedmail()
    l.info('等候下次打卡...')
