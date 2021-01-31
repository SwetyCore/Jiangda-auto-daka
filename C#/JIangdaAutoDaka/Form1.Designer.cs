
namespace JIangdaAutoDaka
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroTextBox_output = new MetroFramework.Controls.MetroTextBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton_testmail = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox_password = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox_username = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox_receiveaddress = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox_mailkey = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox_senderaddress = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox_settedtime = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel_nowtime = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroTextBox_apikey = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox_secretkey = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton1.Location = new System.Drawing.Point(644, 555);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(134, 41);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "开启服务";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroTextBox_output
            // 
            this.metroTextBox_output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTextBox_output.Location = new System.Drawing.Point(23, 63);
            this.metroTextBox_output.Multiline = true;
            this.metroTextBox_output.Name = "metroTextBox_output";
            this.metroTextBox_output.ReadOnly = true;
            this.metroTextBox_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.metroTextBox_output.Size = new System.Drawing.Size(601, 476);
            this.metroTextBox_output.TabIndex = 1;
            this.metroTextBox_output.Text = "[日志输出]";
            // 
            // metroButton2
            // 
            this.metroButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton2.Location = new System.Drawing.Point(810, 555);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(133, 41);
            this.metroButton2.TabIndex = 3;
            this.metroButton2.Text = "停止服务";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.metroButton3);
            this.groupBox1.Controls.Add(this.metroButton4);
            this.groupBox1.Controls.Add(this.metroButton_testmail);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroTextBox_password);
            this.groupBox1.Controls.Add(this.metroTextBox_username);
            this.groupBox1.Controls.Add(this.metroTextBox_secretkey);
            this.groupBox1.Controls.Add(this.metroTextBox_apikey);
            this.groupBox1.Controls.Add(this.metroTextBox_receiveaddress);
            this.groupBox1.Controls.Add(this.metroTextBox_mailkey);
            this.groupBox1.Controls.Add(this.metroTextBox_senderaddress);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(644, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 476);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "资料配置";
            // 
            // metroButton3
            // 
            this.metroButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton3.Location = new System.Drawing.Point(9, 408);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(125, 43);
            this.metroButton3.TabIndex = 15;
            this.metroButton3.Text = "从磁盘加载配置";
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton4.Location = new System.Drawing.Point(166, 408);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(124, 43);
            this.metroButton4.TabIndex = 14;
            this.metroButton4.Text = "保存配置";
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroButton_testmail
            // 
            this.metroButton_testmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton_testmail.Location = new System.Drawing.Point(184, 154);
            this.metroButton_testmail.Name = "metroButton_testmail";
            this.metroButton_testmail.Size = new System.Drawing.Size(106, 35);
            this.metroButton_testmail.TabIndex = 14;
            this.metroButton_testmail.Text = "测试邮箱配置";
            this.metroButton_testmail.Click += new System.EventHandler(this.metroButton_testmail_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(7, 288);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(93, 80);
            this.metroLabel3.TabIndex = 11;
            this.metroLabel3.Text = "<综合门户> \r\n学号\r\n\r\n密码";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.metroLabel1.Location = new System.Drawing.Point(6, 23);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(99, 120);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "<QQ邮箱>   \r\n发件邮箱地址\r\n\r\n邮箱授权码\r\n\r\n收件邮箱地址";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroTextBox_password
            // 
            this.metroTextBox_password.Location = new System.Drawing.Point(110, 345);
            this.metroTextBox_password.Name = "metroTextBox_password";
            this.metroTextBox_password.PasswordChar = '●';
            this.metroTextBox_password.Size = new System.Drawing.Size(180, 23);
            this.metroTextBox_password.TabIndex = 8;
            // 
            // metroTextBox_username
            // 
            this.metroTextBox_username.Location = new System.Drawing.Point(110, 308);
            this.metroTextBox_username.Name = "metroTextBox_username";
            this.metroTextBox_username.Size = new System.Drawing.Size(180, 23);
            this.metroTextBox_username.TabIndex = 7;
            // 
            // metroTextBox_receiveaddress
            // 
            this.metroTextBox_receiveaddress.Location = new System.Drawing.Point(110, 120);
            this.metroTextBox_receiveaddress.Name = "metroTextBox_receiveaddress";
            this.metroTextBox_receiveaddress.Size = new System.Drawing.Size(180, 23);
            this.metroTextBox_receiveaddress.TabIndex = 2;
            // 
            // metroTextBox_mailkey
            // 
            this.metroTextBox_mailkey.Location = new System.Drawing.Point(110, 79);
            this.metroTextBox_mailkey.Name = "metroTextBox_mailkey";
            this.metroTextBox_mailkey.PasswordChar = '●';
            this.metroTextBox_mailkey.Size = new System.Drawing.Size(180, 23);
            this.metroTextBox_mailkey.TabIndex = 1;
            // 
            // metroTextBox_senderaddress
            // 
            this.metroTextBox_senderaddress.Location = new System.Drawing.Point(110, 42);
            this.metroTextBox_senderaddress.Name = "metroTextBox_senderaddress";
            this.metroTextBox_senderaddress.Size = new System.Drawing.Size(180, 23);
            this.metroTextBox_senderaddress.TabIndex = 0;
            // 
            // metroTextBox_settedtime
            // 
            this.metroTextBox_settedtime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroTextBox_settedtime.Location = new System.Drawing.Point(252, 555);
            this.metroTextBox_settedtime.MaxLength = 5;
            this.metroTextBox_settedtime.Name = "metroTextBox_settedtime";
            this.metroTextBox_settedtime.Size = new System.Drawing.Size(64, 23);
            this.metroTextBox_settedtime.TabIndex = 12;
            // 
            // metroLabel
            // 
            this.metroLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel.AutoSize = true;
            this.metroLabel.Location = new System.Drawing.Point(23, 555);
            this.metroLabel.Name = "metroLabel";
            this.metroLabel.Size = new System.Drawing.Size(223, 20);
            this.metroLabel.TabIndex = 12;
            this.metroLabel.Text = "当前时间:                      设定时间:";
            this.metroLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // metroLabel_nowtime
            // 
            this.metroLabel_nowtime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel_nowtime.AutoSize = true;
            this.metroLabel_nowtime.Location = new System.Drawing.Point(101, 555);
            this.metroLabel_nowtime.Name = "metroLabel_nowtime";
            this.metroLabel_nowtime.Size = new System.Drawing.Size(44, 20);
            this.metroLabel_nowtime.TabIndex = 13;
            this.metroLabel_nowtime.Text = "08:00";
            this.metroLabel_nowtime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // metroTextBox_apikey
            // 
            this.metroTextBox_apikey.Location = new System.Drawing.Point(110, 204);
            this.metroTextBox_apikey.Name = "metroTextBox_apikey";
            this.metroTextBox_apikey.PasswordChar = '●';
            this.metroTextBox_apikey.Size = new System.Drawing.Size(180, 23);
            this.metroTextBox_apikey.TabIndex = 5;
            // 
            // metroTextBox_secretkey
            // 
            this.metroTextBox_secretkey.Location = new System.Drawing.Point(110, 243);
            this.metroTextBox_secretkey.Name = "metroTextBox_secretkey";
            this.metroTextBox_secretkey.PasswordChar = '●';
            this.metroTextBox_secretkey.Size = new System.Drawing.Size(180, 23);
            this.metroTextBox_secretkey.TabIndex = 6;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.metroLabel2.Location = new System.Drawing.Point(9, 185);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(95, 80);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "<百度OCR>  \r\nAPI_KEY\r\n\r\nSECRET_KEY";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroLabel4.Location = new System.Drawing.Point(23, 585);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(92, 20);
            this.metroLabel4.TabIndex = 14;
            this.metroLabel4.Text = "[获取源代码]";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(954, 616);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel_nowtime);
            this.Controls.Add(this.metroLabel);
            this.Controls.Add(this.metroTextBox_settedtime);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroTextBox_output);
            this.Controls.Add(this.metroButton1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "Form1";
            this.Text = "自动打卡项目";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox metroTextBox_output;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBox_receiveaddress;
        private MetroFramework.Controls.MetroTextBox metroTextBox_mailkey;
        private MetroFramework.Controls.MetroTextBox metroTextBox_senderaddress;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBox_password;
        private MetroFramework.Controls.MetroTextBox metroTextBox_username;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox metroTextBox_settedtime;
        private MetroFramework.Controls.MetroLabel metroLabel;
        private MetroFramework.Controls.MetroLabel metroLabel_nowtime;
        private MetroFramework.Controls.MetroButton metroButton_testmail;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox metroTextBox_secretkey;
        private MetroFramework.Controls.MetroTextBox metroTextBox_apikey;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}

