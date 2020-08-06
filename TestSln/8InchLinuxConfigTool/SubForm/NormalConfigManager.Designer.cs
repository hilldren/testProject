namespace _8InchLinuxConfigTool.SubForm
{
    partial class NormalConfigManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.open_info = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.qr_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.hprose_server = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.hprose_port = new System.Windows.Forms.TextBox();
            this.tcp_server = new System.Windows.Forms.TextBox();
            this.tcp_port = new System.Windows.Forms.TextBox();
            this.monitor_server_hprose = new System.Windows.Forms.TextBox();
            this.monitor_port_hprose = new System.Windows.Forms.TextBox();
            this.min_face = new System.Windows.Forms.TextBox();
            this.txt_1to1Threshold = new System.Windows.Forms.TextBox();
            this.local_1_N_threshold = new System.Windows.Forms.TextBox();
            this.face_belive = new System.Windows.Forms.TextBox();
            this.face_clear = new System.Windows.Forms.TextBox();
            this.ic_verify = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.card_verify = new System.Windows.Forms.TextBox();
            this.qr_verify = new System.Windows.Forms.TextBox();
            this.blur_diff = new System.Windows.Forms.TextBox();
            this.ui_close = new System.Windows.Forms.TextBox();
            this.save_img = new System.Windows.Forms.TextBox();
            this.face_facade = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.keep_open = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label22 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "识别成功显示的内容";
            // 
            // open_info
            // 
            this.open_info.Location = new System.Drawing.Point(270, 18);
            this.open_info.Name = "open_info";
            this.open_info.Size = new System.Drawing.Size(230, 21);
            this.open_info.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(447, 400);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 27);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(557, 400);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(137, 27);
            this.btnSend.TabIndex = 11;
            this.btnSend.Text = "保存并下发到面板机";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(519, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "二维码内容";
            // 
            // qr_id
            // 
            this.qr_id.Location = new System.Drawing.Point(590, 18);
            this.qr_id.Name = "qr_id";
            this.qr_id.Size = new System.Drawing.Size(165, 21);
            this.qr_id.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "图片接收服务IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(519, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "图片接收服务端口";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "远程开门服务IP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(519, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "远程开门服务端口";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(175, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "监控服务IP";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(539, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 21;
            this.label9.Text = "监控服务端口";
            // 
            // hprose_server
            // 
            this.hprose_server.Location = new System.Drawing.Point(246, 54);
            this.hprose_server.Name = "hprose_server";
            this.hprose_server.Size = new System.Drawing.Size(254, 21);
            this.hprose_server.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(175, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 23;
            this.label10.Text = "最小人脸值";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(151, 215);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 12);
            this.label11.TabIndex = 24;
            this.label11.Text = "人脸置信度分值";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(572, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 25;
            this.label12.Text = "1比N比对值";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(343, 215);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 12);
            this.label13.TabIndex = 26;
            this.label13.Text = "人脸清晰度分值";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(355, 176);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 12);
            this.label14.TabIndex = 27;
            this.label14.Text = "1比1比对分值";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(211, 255);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(215, 12);
            this.label15.TabIndex = 28;
            this.label15.Text = "IC卡人证比对（0:只刷卡，1:人脸+卡）";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(151, 293);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(275, 12);
            this.label16.TabIndex = 29;
            this.label16.Text = "二维码人证比对（0:只刷二维码，1:人脸+二维码）";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(469, 255);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(209, 12);
            this.label17.TabIndex = 30;
            this.label17.Text = "身份证检验模式(0为不开启，1为开启)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(175, 360);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(251, 12);
            this.label18.TabIndex = 31;
            this.label18.Text = "红外全彩图分值 （分值越高，彩色照片越多）";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(469, 293);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(209, 12);
            this.label19.TabIndex = 32;
            this.label19.Text = "人名和图片显示（0为关闭，1为开启）";
            // 
            // hprose_port
            // 
            this.hprose_port.Location = new System.Drawing.Point(626, 55);
            this.hprose_port.Name = "hprose_port";
            this.hprose_port.Size = new System.Drawing.Size(129, 21);
            this.hprose_port.TabIndex = 33;
            // 
            // tcp_server
            // 
            this.tcp_server.Location = new System.Drawing.Point(246, 91);
            this.tcp_server.Name = "tcp_server";
            this.tcp_server.Size = new System.Drawing.Size(254, 21);
            this.tcp_server.TabIndex = 34;
            // 
            // tcp_port
            // 
            this.tcp_port.Location = new System.Drawing.Point(626, 91);
            this.tcp_port.Name = "tcp_port";
            this.tcp_port.Size = new System.Drawing.Size(129, 21);
            this.tcp_port.TabIndex = 35;
            // 
            // monitor_server_hprose
            // 
            this.monitor_server_hprose.Location = new System.Drawing.Point(246, 133);
            this.monitor_server_hprose.Name = "monitor_server_hprose";
            this.monitor_server_hprose.Size = new System.Drawing.Size(254, 21);
            this.monitor_server_hprose.TabIndex = 36;
            // 
            // monitor_port_hprose
            // 
            this.monitor_port_hprose.Location = new System.Drawing.Point(626, 133);
            this.monitor_port_hprose.Name = "monitor_port_hprose";
            this.monitor_port_hprose.Size = new System.Drawing.Size(129, 21);
            this.monitor_port_hprose.TabIndex = 37;
            // 
            // min_face
            // 
            this.min_face.Location = new System.Drawing.Point(246, 173);
            this.min_face.Name = "min_face";
            this.min_face.Size = new System.Drawing.Size(90, 21);
            this.min_face.TabIndex = 38;
            // 
            // txt_1to1Threshold
            // 
            this.txt_1to1Threshold.Location = new System.Drawing.Point(438, 173);
            this.txt_1to1Threshold.Name = "txt_1to1Threshold";
            this.txt_1to1Threshold.Size = new System.Drawing.Size(90, 21);
            this.txt_1to1Threshold.TabIndex = 39;
            // 
            // local_1_N_threshold
            // 
            this.local_1_N_threshold.Location = new System.Drawing.Point(647, 173);
            this.local_1_N_threshold.Name = "local_1_N_threshold";
            this.local_1_N_threshold.Size = new System.Drawing.Size(89, 21);
            this.local_1_N_threshold.TabIndex = 40;
            // 
            // face_belive
            // 
            this.face_belive.Location = new System.Drawing.Point(246, 212);
            this.face_belive.Name = "face_belive";
            this.face_belive.Size = new System.Drawing.Size(90, 21);
            this.face_belive.TabIndex = 41;
            // 
            // face_clear
            // 
            this.face_clear.Location = new System.Drawing.Point(438, 212);
            this.face_clear.Name = "face_clear";
            this.face_clear.Size = new System.Drawing.Size(90, 21);
            this.face_clear.TabIndex = 42;
            // 
            // ic_verify
            // 
            this.ic_verify.Location = new System.Drawing.Point(421, 252);
            this.ic_verify.Name = "ic_verify";
            this.ic_verify.Size = new System.Drawing.Size(30, 21);
            this.ic_verify.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(493, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "保存大图（1为保存，0为不保存）";
            // 
            // card_verify
            // 
            this.card_verify.Location = new System.Drawing.Point(684, 252);
            this.card_verify.Name = "card_verify";
            this.card_verify.Size = new System.Drawing.Size(30, 21);
            this.card_verify.TabIndex = 44;
            // 
            // qr_verify
            // 
            this.qr_verify.Location = new System.Drawing.Point(421, 290);
            this.qr_verify.Name = "qr_verify";
            this.qr_verify.Size = new System.Drawing.Size(30, 21);
            this.qr_verify.TabIndex = 45;
            // 
            // blur_diff
            // 
            this.blur_diff.Location = new System.Drawing.Point(421, 357);
            this.blur_diff.Name = "blur_diff";
            this.blur_diff.Size = new System.Drawing.Size(104, 21);
            this.blur_diff.TabIndex = 46;
            // 
            // ui_close
            // 
            this.ui_close.Location = new System.Drawing.Point(684, 290);
            this.ui_close.Name = "ui_close";
            this.ui_close.Size = new System.Drawing.Size(30, 21);
            this.ui_close.TabIndex = 47;
            // 
            // save_img
            // 
            this.save_img.Location = new System.Drawing.Point(684, 324);
            this.save_img.Name = "save_img";
            this.save_img.Size = new System.Drawing.Size(30, 21);
            this.save_img.TabIndex = 48;
            // 
            // face_facade
            // 
            this.face_facade.Location = new System.Drawing.Point(647, 212);
            this.face_facade.Name = "face_facade";
            this.face_facade.Size = new System.Drawing.Size(90, 21);
            this.face_facade.TabIndex = 50;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(552, 215);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(89, 12);
            this.label20.TabIndex = 49;
            this.label20.Text = "人脸正脸度分值";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(241, 327);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(185, 12);
            this.label21.TabIndex = 51;
            this.label21.Text = "继电器开关（0为常开，1为常闭）";
            // 
            // keep_open
            // 
            this.keep_open.Location = new System.Drawing.Point(421, 324);
            this.keep_open.Name = "keep_open";
            this.keep_open.Size = new System.Drawing.Size(30, 21);
            this.keep_open.TabIndex = 52;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(705, 407);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(59, 12);
            this.linkLabel1.TabIndex = 53;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "修改更多>";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(265, 407);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(161, 12);
            this.label22.TabIndex = 54;
            this.label22.Text = "修改配置后需要重启才能生效";
            // 
            // NormalConfigManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 450);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.keep_open);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.face_facade);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.save_img);
            this.Controls.Add(this.ui_close);
            this.Controls.Add(this.blur_diff);
            this.Controls.Add(this.qr_verify);
            this.Controls.Add(this.card_verify);
            this.Controls.Add(this.ic_verify);
            this.Controls.Add(this.face_clear);
            this.Controls.Add(this.face_belive);
            this.Controls.Add(this.local_1_N_threshold);
            this.Controls.Add(this.txt_1to1Threshold);
            this.Controls.Add(this.min_face);
            this.Controls.Add(this.monitor_port_hprose);
            this.Controls.Add(this.monitor_server_hprose);
            this.Controls.Add(this.tcp_port);
            this.Controls.Add(this.tcp_server);
            this.Controls.Add(this.hprose_port);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.hprose_server);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.qr_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.open_info);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NormalConfigManager";
            this.Text = "修改配置";
            this.Load += new System.EventHandler(this.frmConfigManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox open_info;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox qr_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox hprose_server;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox hprose_port;
        private System.Windows.Forms.TextBox tcp_server;
        private System.Windows.Forms.TextBox tcp_port;
        private System.Windows.Forms.TextBox monitor_server_hprose;
        private System.Windows.Forms.TextBox monitor_port_hprose;
        private System.Windows.Forms.TextBox min_face;
        private System.Windows.Forms.TextBox txt_1to1Threshold;
        private System.Windows.Forms.TextBox local_1_N_threshold;
        private System.Windows.Forms.TextBox face_belive;
        private System.Windows.Forms.TextBox face_clear;
        private System.Windows.Forms.TextBox ic_verify;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox card_verify;
        private System.Windows.Forms.TextBox qr_verify;
        private System.Windows.Forms.TextBox blur_diff;
        private System.Windows.Forms.TextBox ui_close;
        private System.Windows.Forms.TextBox save_img;
        private System.Windows.Forms.TextBox face_facade;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox keep_open;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label22;
    }
}