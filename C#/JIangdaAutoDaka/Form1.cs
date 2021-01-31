using MetroFramework.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Threading;
using System.Windows.Forms;

namespace JIangdaAutoDaka
{
    public partial class Form1 : MetroForm
    {
        bool isServiceStart = false;
        bool isRunning = false;
        public Form1()
        {
            InitializeComponent();
        }
        public void getsettings()
        {
            if (File.Exists("config.json") == true)
            {
                JObject jsonObj = (JObject)JsonConvert.DeserializeObject(File.ReadAllText("config.json"));
                metroTextBox_senderaddress.Text = jsonObj["senderaddress"].ToString();
                metroTextBox_mailkey.Text = jsonObj["mailkey"].ToString();
                metroTextBox_receiveaddress.Text = jsonObj["receiveaddress"].ToString();
                metroTextBox_apikey.Text = jsonObj["apikey"].ToString();
                metroTextBox_secretkey.Text = jsonObj["secretkey"].ToString();
                metroTextBox_username.Text = jsonObj["username"].ToString();
                metroTextBox_password.Text = jsonObj["password"].ToString();
                //MessageBox.Show("加载完毕!");
            }
            else
            { MessageBox.Show("未找到配置文件!!"); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getsettings();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (File.Exists("data.json") != true)
            {
                MessageBox.Show("未找到data.json!!!");
            }
                if (metroTextBox_settedtime.Text != "")
            {
                isServiceStart = true;
                metroButton1.Enabled = false;
                //metroTextBox_output.AppendText("服务已开启!");
                metroTextBox_output.AppendText("\r\n服务已开启!\r\n等待打卡...");
            }
            else
            {
                MessageBox.Show("时间未设定!!!!!!!");
            }
        }
        protected void SendMail(string body, bool ishtml)
        {
            //实例化一个发送邮件类。
            MailMessage mailMessage = new MailMessage();
            //发件人邮箱地址，方法重载不同，可以根据需求自行选择。
            mailMessage.From = new MailAddress(metroTextBox_senderaddress.Text);
            //收件人邮箱地址。
            mailMessage.To.Add(new MailAddress(metroTextBox_receiveaddress.Text));
            //邮件标题。
            mailMessage.Subject = "测试邮件...";
            //邮件内容。
            mailMessage.IsBodyHtml = ishtml;
            mailMessage.Body = body;
            //实例化一个SmtpClient类。
            SmtpClient client = new SmtpClient();
            //在这里我使用的是qq邮箱，所以是smtp.qq.com，如果你使用的是126邮箱，那么就是smtp.126.com。
            client.Host = "smtp.qq.com";
            //使用安全加密连接。
            client.EnableSsl = true;
            //不和请求一块发送。
            client.UseDefaultCredentials = false;
            //验证发件人身份(发件人的邮箱，邮箱里的生成授权码);
            client.Credentials = new NetworkCredential(metroTextBox_senderaddress.Text, metroTextBox_mailkey.Text);
            //发送
            client.Send(mailMessage);
            Console.WriteLine("发送成功");
        }



        private void metroButton_testmail_Click(object sender, EventArgs e)
        {
            metroButton_testmail.Enabled = false;
            SendMail("这是邮件的body!", false);
            metroButton_testmail.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            metroLabel_nowtime.Text = DateTime.Now.ToString("HH:mm:ss");
            if (DateTime.Now.ToString("HH:mm") == metroTextBox_settedtime.Text && isServiceStart == true&&isRunning==false)
            {
                Console.WriteLine("时间到!");

                metroTextBox_output.AppendText("\r\n开始打卡...");
                Thread thread = new Thread(new ThreadStart(start));//创建线程
                thread.Start();

                isRunning = true;
            }
        }
        public void log(string str)
        {
            Invoke(new Action(() =>
            {
                metroTextBox_output.AppendText(str);
            }));
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            try
            {
                dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject("{}");
                jsonObj["senderaddress"] = metroTextBox_senderaddress.Text;
                jsonObj["mailkey"] = metroTextBox_mailkey.Text;
                jsonObj["receiveaddress"] = metroTextBox_receiveaddress.Text;
                jsonObj["apikey"] = metroTextBox_apikey.Text;
                jsonObj["secretkey"] = metroTextBox_secretkey.Text;
                jsonObj["username"] = metroTextBox_username.Text;
                jsonObj["password"] = metroTextBox_password.Text;
                string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText("config.json", output);
                MessageBox.Show("保存成功!", "提示:");
            }
            catch
            {
                MessageBox.Show("保存失败!");
            }
        }
        private void metroButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process[] myProcesses = System.Diagnostics.Process.GetProcesses();

            foreach (System.Diagnostics.Process myProcess in myProcesses)
            {
                if ("dakaCore" == myProcess.ProcessName)
                    myProcess.Kill();

            }

            metroTextBox_output.AppendText("\r\n服务已关闭!");
            isServiceStart = false;
            metroButton1.Enabled = true;
            isRunning = false;
        }

        public void start()
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo = new System.Diagnostics.ProcessStartInfo();
            p.StartInfo.FileName = "dakaCore.exe";
            p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;//让窗体不显示
            p.Start();
            StreamReader reader = p.StandardOutput;//截取输出流
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();//每次读取一行
                log("\r\n"+line);
            }
            p.WaitForExit();//等待程序执行完退出进程
            p.Close();
            Thread.Sleep(60000);
            isRunning = false;

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            getsettings();
        }



        private void metroLabel2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ai.baidu.com/tech/ocr/general");
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://service.mail.qq.com/cgi-bin/help?subtype=1&&no=1001607&&id=28");
        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/SwetyCore/Jiangda-auto-daka/tree/C%23-GUI-Version");
        }
    }
}
