import smtplib
from email.mime.text import MIMEText
from email.utils import formataddr
from log1 import log


# 懒得写注释勒

l=log()

my_sender = '13456789@qq.com'  # 发件人邮箱账号
my_pass = 'redg23rdafsfaliaci'  # 发件人邮箱密码
my_user = '1234565432@qq.com'  # 收件人邮箱账号

def mail():
    with open('testpost.html', 'r', encoding='utf-8') as fn:
        html = fn.read()
    try:
        mail_msg = html
        msg = MIMEText(mail_msg, 'html', 'utf-8')
        msg['From'] = formataddr(["自动打卡", my_sender])  # 括号里的对应发件人邮箱昵称、发件人邮箱账号
        msg['To'] = formataddr(["SwetyCore", my_user])  # 括号里的对应收件人邮箱昵称、收件人邮箱账号
        msg['Subject'] = "打卡结果反馈"  # 邮件的主题，也可以说是标题

        server = smtplib.SMTP_SSL("smtp.qq.com", 465)  # 发件人邮箱中的SMTP服务器，端口是25
        server.login(my_sender, my_pass)  # 括号中对应的是发件人邮箱账号、邮箱密码
        server.sendmail(my_sender, [my_user, ], msg.as_string())  # 括号中对应的是发件人邮箱账号、收件人邮箱账号、发送邮件
        server.quit()  # 关闭连接
    except Exception:  # 如果 try 中的语句没有执行，则会执行下面的 ret=False
        l.info("邮件发送失败")
    l.info("邮件发送成功")
def failedmail():
    try:
        mail_msg = '打卡失败,未成功登陆!'
        msg = MIMEText(mail_msg, 'html', 'utf-8')
        msg['From'] = formataddr(["自动打卡", my_sender])  # 括号里的对应发件人邮箱昵称、发件人邮箱账号
        msg['To'] = formataddr(["SwetyCore", my_user])  # 括号里的对应收件人邮箱昵称、收件人邮箱账号
        msg['Subject'] = "打卡失败结果反馈"  # 邮件的主题，也可以说是标题

        server = smtplib.SMTP_SSL("smtp.qq.com", 465)  # 发件人邮箱中的SMTP服务器，端口是25
        server.login(my_sender, my_pass)  # 括号中对应的是发件人邮箱账号、邮箱密码
        server.sendmail(my_sender, [my_user, ], msg.as_string())  # 括号中对应的是发件人邮箱账号、收件人邮箱账号、发送邮件
        server.quit()  # 关闭连接
    except Exception:  # 如果 try 中的语句没有执行，则会执行下面的 ret=False
        l.info("邮件发送失败")
    l.info("邮件发送成功")

# failedmail()