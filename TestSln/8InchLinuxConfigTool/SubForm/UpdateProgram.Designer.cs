namespace _8InchLinuxConfigTool.SubForm
{
    partial class UpdateProgram
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
            this.txtDeviceUpdateDirectory = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSelDirectory = new System.Windows.Forms.Button();
            this.txtUpdatePackageDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDeviceUpdateDirectory
            // 
            this.txtDeviceUpdateDirectory.Location = new System.Drawing.Point(391, 156);
            this.txtDeviceUpdateDirectory.Name = "txtDeviceUpdateDirectory";
            this.txtDeviceUpdateDirectory.Size = new System.Drawing.Size(176, 21);
            this.txtDeviceUpdateDirectory.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(391, 247);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(176, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "下发更新文件";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSelDirectory
            // 
            this.btnSelDirectory.Location = new System.Drawing.Point(391, 218);
            this.btnSelDirectory.Name = "btnSelDirectory";
            this.btnSelDirectory.Size = new System.Drawing.Size(176, 23);
            this.btnSelDirectory.TabIndex = 2;
            this.btnSelDirectory.Text = "选择更新包目录";
            this.btnSelDirectory.UseVisualStyleBackColor = true;
            this.btnSelDirectory.Click += new System.EventHandler(this.btnSelDirectory_Click);
            // 
            // txtUpdatePackageDirectory
            // 
            this.txtUpdatePackageDirectory.Location = new System.Drawing.Point(391, 183);
            this.txtUpdatePackageDirectory.Name = "txtUpdatePackageDirectory";
            this.txtUpdatePackageDirectory.ReadOnly = true;
            this.txtUpdatePackageDirectory.Size = new System.Drawing.Size(176, 21);
            this.txtUpdatePackageDirectory.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "面板机更新目录";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "更新包目录";
            // 
            // UpdateProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUpdatePackageDirectory);
            this.Controls.Add(this.btnSelDirectory);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtDeviceUpdateDirectory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateProgram";
            this.Text = "UpdateProgram";
            this.Load += new System.EventHandler(this.UpdateProgram_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDeviceUpdateDirectory;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSelDirectory;
        private System.Windows.Forms.TextBox txtUpdatePackageDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}