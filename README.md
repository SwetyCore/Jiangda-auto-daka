# Jiangda-auto-daka
江大自动健康打卡的py实现.

## 过程分析:
对打卡网址进行post请求: http://yun.ujs.edu.cn/xxhgl/yqsb/grmrsb?v=3097

要求:携带有效的`cookie:_csrf-cloud=***********; cloud_sessionID=**************`

由于cookie的有效时间很短,因此建议直接模拟登陆,过程详见我github上的登录项目
[戳我传送](https://github.com/SwetyCore/Jiangda-Portal-Automatic-Login)
#### post表单内容(这里是转换后的json格式):
```
{
  "ykt": "学号",
  "dwmc": "学院",
  "zy": "专业",
  "bj": "班级",
  "xm": "姓名",
  "zjh": **,
  "nl": **,
  "sjh": "电话",
  "sfyxszd": "*",
  "sfid": ******,
  "csid": ******,
  "xqid": ******,
  "xxdz": "******",
  "jqdt": "*************8",
  "sffx": "*",
  "dzsj_m": "",
  "dzsj_d": "",
  "czjtgj": "",
  "jtgjbc": "",
  "yxzt": "*",
  "mqzdyqdyjcs": "",
  "zdyq": "",
  "sfgtjzryfrks": "*",
  "xsfxbj": "是否返校",
  "qtyc": "*",
  "bz": "",
  "latitude": "",
  "longitude": "",
  "btn": ""
}
```

## 提交示例
只修改了提交表单的体温部分
详见mainSes.py(阿里云ocr的key依然需要申请嗷)
使用时请预先准备好带有以前登录表单的**data.json** 文件!!! (文末)
学校用的是[SSO单点登录—CAS统一身份认证]

> CAS三个重要术语：TGT（Ticket Granting Ticket）、TGC（Ticket Granting Cookie）和ST（Service Ticket）。  
>> TGT为用户登录后生成的票根，包含用户的认证身份、有效期等，存储于CAS Server中，类似于服务器会话。  
>> TGC存储于cookie中，类似于会话ID，用户与CAS Server交互时，帮助用户查找相应的TGT。  
>> ST为CAS Server签发的一张一次性票据，CAS Client使用ST与CAS Server进行交互，获取用户的验证状态。  
>> 作者：郝小发的生活
>> 来源：简书

具体的认证原理见我Baidu出来的结果:[统一身份认证（CAS）的工作流程](https://www.jianshu.com/p/35ba532780ec?from=timeline)
由于偷了小懒,所以我没在py文件里面写太多的注释,下面进行简单的过程解释:
利用模拟登陆获取登录后的session,取得TGT
注意:此时的cookie里面并没有需要的cookie,不能直接访问打卡网址
先修改请求头的host为yun.ujs.edu.cn
初次访问打卡网址,直接提交目的是获取ST
会被三次重定向
```[2021-01-22 13:51:06]重定向链接:index
[2021-01-22 13:51:06]重定向链接:https://pass.ujs.edu.cn/cas/login?service=http%3A%2F%2Fyun.ujs.edu.cn%2Fxxhgl%2Fyqsb%2Findex
[2021-01-22 13:51:06]重定向链接:http://yun.ujs.edu.cn/xxhgl/yqsb/index?ticket=ST-534244-UeFZPT4bAdgezafbaf3234234706-nIQs-cas
```
其中的第三次重定向的连接中的ticket=ST***************-cas就是ST
之后就可以对目标网址进行post提交打卡表单了!!!

## data.json解读
其实就是吧以前登录时候提交的表单复制粘贴下来,写成json格式并且储存在data.json里面了
如果不想手动写就把表单复制并且赋值给下面程序的变量c,运行之后复制输出粘贴到data.json里面即可
**使用示例:**
```
c = '''Accept: text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9
Accept-Encoding: gzip, deflate, br
Accept-Language: zh-CN,zh;q=0.9,en;q=0.8,en-GB;q=0.7,en-US;q=0.6,en-GB-oxendict;q=0.5
Cache-Control: max-age=0
Connection: keep-alive
Content-Length: 302
Content-Type: application/x-www-form-urlencoded'''
print('{')
print('\t"', end='')
flag = 1
for i in range(len(c)):
    if c[i] == ':' and flag == 1:
        print('":"', end='')
        flag = 0
    elif c[i] == '\n':
        print('",\n\t"', end='')
        flag = 1
    elif c[i] == ' ' and c[i - 1] == ':':
        continue
    else:
        print(c[i], end='')
print('"')
print('}')
```
运行结果:
```
{
        "Accept":"text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9",
        "Accept-Encoding":"gzip, deflate, br",
        "Accept-Language":"zh-CN,zh;q=0.9,en;q=0.8,en-GB;q=0.7,en-US;q=0.6,en-GB-oxendict;q=0.5",
        "Cache-Control":"max-age=0",
        "Connection":"keep-alive",
        "Content-Length":"302",
        "Content-Type":"application/x-www-form-urlencoded"
}
```

仅供研究学习交流,严禁用于其他用途!!!
