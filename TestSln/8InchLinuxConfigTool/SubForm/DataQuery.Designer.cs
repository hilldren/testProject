namespace _8InchLinuxConfigTool.SubForm
{
    partial class DataQuery
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.GUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.人员类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODELID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.创建时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.有效开始时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.有效结束时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.特征点信息 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.小区编码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.小区名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GUID,
            this.NAME,
            this.人员类型,
            this.MODELID,
            this.创建时间,
            this.有效开始时间,
            this.有效结束时间,
            this.特征点信息,
            this.小区编码,
            this.小区名称});
            this.dataGridView1.Location = new System.Drawing.Point(12, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(904, 333);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(760, 415);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Text = "上一页";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(841, 415);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "下一页";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Location = new System.Drawing.Point(581, 420);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(0, 12);
            this.lblTotalCount.TabIndex = 3;
            // 
            // GUID
            // 
            this.GUID.DataPropertyName = "GUID";
            this.GUID.HeaderText = "主键ID";
            this.GUID.Name = "GUID";
            // 
            // NAME
            // 
            this.NAME.DataPropertyName = "NAME";
            this.NAME.HeaderText = "姓名";
            this.NAME.Name = "NAME";
            // 
            // 人员类型
            // 
            this.人员类型.DataPropertyName = "USERTYPE";
            this.人员类型.HeaderText = "人员类型";
            this.人员类型.Name = "人员类型";
            // 
            // MODELID
            // 
            this.MODELID.DataPropertyName = "MODELID";
            this.MODELID.HeaderText = "MODELID";
            this.MODELID.Name = "MODELID";
            // 
            // 创建时间
            // 
            this.创建时间.DataPropertyName = "CREATETIME";
            this.创建时间.HeaderText = "创建时间";
            this.创建时间.Name = "创建时间";
            this.创建时间.Width = 150;
            // 
            // 有效开始时间
            // 
            this.有效开始时间.DataPropertyName = "STARTTIME";
            this.有效开始时间.HeaderText = "有效开始时间";
            this.有效开始时间.Name = "有效开始时间";
            // 
            // 有效结束时间
            // 
            this.有效结束时间.DataPropertyName = "ENDTIME";
            this.有效结束时间.HeaderText = "有效结束时间";
            this.有效结束时间.Name = "有效结束时间";
            // 
            // 特征点信息
            // 
            this.特征点信息.DataPropertyName = "FEATURE";
            this.特征点信息.HeaderText = "特征点信息";
            this.特征点信息.Name = "特征点信息";
            // 
            // 小区编码
            // 
            this.小区编码.DataPropertyName = "AREACODE";
            this.小区编码.HeaderText = "小区编码";
            this.小区编码.Name = "小区编码";
            // 
            // 小区名称
            // 
            this.小区名称.DataPropertyName = "AREANAME";
            this.小区名称.HeaderText = "小区名称";
            this.小区名称.Name = "小区名称";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "姓名：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(50, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 5;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(167, 26);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 6;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // DataQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 450);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalCount);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataQuery";
            this.Text = "DataQuery";
            this.Load += new System.EventHandler(this.DataQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn GUID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn 人员类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODELID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 创建时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 有效开始时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 有效结束时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 特征点信息;
        private System.Windows.Forms.DataGridViewTextBoxColumn 小区编码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 小区名称;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnQuery;
    }
}