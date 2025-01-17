﻿namespace _8InchLinuxConfigTool.SubForm
{
    partial class CoreConfigManager
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
            this.camera_id = new System.Windows.Forms.TextBox();
            this.area_code = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.building_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.no_screen_server = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.no_screen_port = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "设备编码：";
            // 
            // camera_id
            // 
            this.camera_id.Location = new System.Drawing.Point(378, 38);
            this.camera_id.Name = "camera_id";
            this.camera_id.Size = new System.Drawing.Size(230, 21);
            this.camera_id.TabIndex = 1;
            // 
            // area_code
            // 
            this.area_code.Location = new System.Drawing.Point(378, 79);
            this.area_code.Name = "area_code";
            this.area_code.Size = new System.Drawing.Size(230, 21);
            this.area_code.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "小区编码：";
            // 
            // building_id
            // 
            this.building_id.Location = new System.Drawing.Point(378, 118);
            this.building_id.Name = "building_id";
            this.building_id.Size = new System.Drawing.Size(230, 21);
            this.building_id.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "楼宇编码：";
            // 
            // no_screen_server
            // 
            this.no_screen_server.Location = new System.Drawing.Point(378, 163);
            this.no_screen_server.Name = "no_screen_server";
            this.no_screen_server.Size = new System.Drawing.Size(230, 21);
            this.no_screen_server.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "无屏服务IP：";
            // 
            // no_screen_port
            // 
            this.no_screen_port.Location = new System.Drawing.Point(378, 206);
            this.no_screen_port.Name = "no_screen_port";
            this.no_screen_port.Size = new System.Drawing.Size(230, 21);
            this.no_screen_port.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "无屏服务端口：";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(369, 270);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 27);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(479, 270);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(129, 27);
            this.btnSend.TabIndex = 11;
            this.btnSend.Text = "保存并下发到面板机";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(447, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "修改配置后需要重启才能生效";
            // 
            // CoreConfigManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.no_screen_port);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.no_screen_server);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.building_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.area_code);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.camera_id);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CoreConfigManager";
            this.Text = "修改配置";
            this.Load += new System.EventHandler(this.frmConfigManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox camera_id;
        private System.Windows.Forms.TextBox area_code;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox building_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox no_screen_server;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox no_screen_port;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label6;
    }
}