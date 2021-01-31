import time
import sys

class log(object):
    # 优化格式化化版本
    # 输出日志的类
    # 显示格式: \033[显示方式;前景色;背景色m
    # 只写一个字段表示前景色,背景色默认

    # 彩色输出
    # RED = '\033[31m'  # 红色
    # GREEN = '\033[32m'  # 绿色
    # YELLOW = '\033[33m'  # 黄色
    # BLUE = '\033[34m'  # 蓝色
    # FUCHSIA = '\033[35m'  # 紫红色
    # CYAN = '\033[36m'  # 青蓝色
    # WHITE = '\033[37m'  # 白色
    # RESET = '\033[0m'  # 终端默认颜色

    # 普通输出
    RED = ''
    GREEN = ''
    YELLOW = ''
    RESET = ''

    def color_str(self, color, s):
        print(time.strftime('\n[%Y-%m-%d %H:%M:%S]', time.localtime(time.time())), end='')
        print('{}{}{}'.format(getattr(self, color), s, self.RESET))
        sys.stdout.flush()
        with open("./log.txt", 'a')as fn:
            fn.write(time.strftime('\n[%Y-%m-%d %H:%M:%S]', time.localtime(time.time())) + s)
        # if color =='RED':     #警告就退出的代码,为了防止莫名退出,已经注释掉.
        # exit()

    def error(self, s):
        return self.color_str('RED', s)

    def info(self, s):
        return self.color_str('GREEN', s)

    def warn(self, s):
        return self.color_str('YELLOW', s)


l = log()
