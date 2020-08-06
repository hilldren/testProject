namespace _8InchLinuxConfigTool
{
    partial class MainFrm
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
            this.pnLeft = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnCmd = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnUpdateProgram = new System.Windows.Forms.Button();
            this.btnDataQuery = new System.Windows.Forms.Button();
            this.btnCoreConfig = new System.Windows.Forms.Button();
            this.btnNormalConfig = new System.Windows.Forms.Button();
            this.btnNetConfig = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnRight = new System.Windows.Forms.Panel();
            this.pnLeft.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnLeft.Controls.Add(this.btnLogOut);
            this.pnLeft.Controls.Add(this.btnCmd);
            this.pnLeft.Controls.Add(this.btnLog);
            this.pnLeft.Controls.Add(this.btnUpdateProgram);
            this.pnLeft.Controls.Add(this.btnDataQuery);
            this.pnLeft.Controls.Add(this.btnCoreConfig);
            this.pnLeft.Controls.Add(this.btnNormalConfig);
            this.pnLeft.Controls.Add(this.btnNetConfig);
            this.pnLeft.Location = new System.Drawing.Point(0, 0);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(249, 493);
            this.pnLeft.TabIndex = 4;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogOut.Location = new System.Drawing.Point(0, 434);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(249, 62);
            this.btnLogOut.TabIndex = 20;
            this.btnLogOut.Text = "退出登录";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnCmd
            // 
            this.btnCmd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCmd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCmd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCmd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCmd.Location = new System.Drawing.Point(0, 372);
            this.btnCmd.Name = "btnCmd";
            this.btnCmd.Size = new System.Drawing.Size(249, 62);
            this.btnCmd.TabIndex = 19;
            this.btnCmd.Text = "命令输入";
            this.btnCmd.UseVisualStyleBackColor = true;
            this.btnCmd.Click += new System.EventHandler(this.btnReboot_Click);
            // 
            // btnLog
            // 
            this.btnLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLog.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLog.Location = new System.Drawing.Point(0, 310);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(249, 62);
            this.btnLog.TabIndex = 18;
            this.btnLog.Text = "日志查询";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnUpdateProgram
            // 
            this.btnUpdateProgram.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateProgram.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdateProgram.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdateProgram.Location = new System.Drawing.Point(0, 248);
            this.btnUpdateProgram.Name = "btnUpdateProgram";
            this.btnUpdateProgram.Size = new System.Drawing.Size(249, 62);
            this.btnUpdateProgram.TabIndex = 17;
            this.btnUpdateProgram.Text = "更新程序";
            this.btnUpdateProgram.UseVisualStyleBackColor = true;
            this.btnUpdateProgram.Click += new System.EventHandler(this.btnUpdateProgram_Click);
            // 
            // btnDataQuery
            // 
            this.btnDataQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDataQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataQuery.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDataQuery.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDataQuery.Location = new System.Drawing.Point(0, 186);
            this.btnDataQuery.Name = "btnDataQuery";
            this.btnDataQuery.Size = new System.Drawing.Size(249, 62);
            this.btnDataQuery.TabIndex = 16;
            this.btnDataQuery.Text = "数据查询";
            this.btnDataQuery.UseVisualStyleBackColor = true;
            this.btnDataQuery.Click += new System.EventHandler(this.btnDataQuery_Click);
            // 
            // btnCoreConfig
            // 
            this.btnCoreConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCoreConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoreConfig.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCoreConfig.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCoreConfig.Location = new System.Drawing.Point(0, 124);
            this.btnCoreConfig.Name = "btnCoreConfig";
            this.btnCoreConfig.Size = new System.Drawing.Size(249, 62);
            this.btnCoreConfig.TabIndex = 15;
            this.btnCoreConfig.Text = "核心功能配置";
            this.btnCoreConfig.UseVisualStyleBackColor = true;
            this.btnCoreConfig.Click += new System.EventHandler(this.btnCoreConfig_Click);
            // 
            // btnNormalConfig
            // 
            this.btnNormalConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNormalConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNormalConfig.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNormalConfig.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNormalConfig.Location = new System.Drawing.Point(0, 62);
            this.btnNormalConfig.Name = "btnNormalConfig";
            this.btnNormalConfig.Size = new System.Drawing.Size(249, 62);
            this.btnNormalConfig.TabIndex = 11;
            this.btnNormalConfig.Text = "普通功能配置";
            this.btnNormalConfig.UseVisualStyleBackColor = true;
            this.btnNormalConfig.Click += new System.EventHandler(this.btnNormalConfig_Click);
            // 
            // btnNetConfig
            // 
            this.btnNetConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNetConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNetConfig.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNetConfig.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNetConfig.Location = new System.Drawing.Point(0, 0);
            this.btnNetConfig.Name = "btnNetConfig";
            this.btnNetConfig.Size = new System.Drawing.Size(249, 62);
            this.btnNetConfig.TabIndex = 1;
            this.btnNetConfig.Text = "网络配置";
            this.btnNetConfig.UseVisualStyleBackColor = true;
            this.btnNetConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnLeft);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 493);
            this.panel1.TabIndex = 2;
            // 
            // pnRight
            // 
            this.pnRight.Location = new System.Drawing.Point(247, 0);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(928, 493);
            this.pnRight.TabIndex = 3;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 496);
            this.Controls.Add(this.pnRight);
            this.Controls.Add(this.panel1);
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainFrm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFrm_FormClosed);
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.pnLeft.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Button btnNetConfig;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnRight;
        private System.Windows.Forms.Button btnCoreConfig;
        private System.Windows.Forms.Button btnNormalConfig;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnUpdateProgram;
        private System.Windows.Forms.Button btnDataQuery;
        private System.Windows.Forms.Button btnCmd;
        private System.Windows.Forms.Button btnLogOut;
    }
}