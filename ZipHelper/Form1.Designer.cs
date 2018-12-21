namespace ZipHelper
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dirSch = new System.DirectoryServices.DirectorySearcher();
            this.label1 = new System.Windows.Forms.Label();
            this.txtToCprsFile = new System.Windows.Forms.TextBox();
            this.btToCprsFileSelct = new System.Windows.Forms.Button();
            this.btCprs = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtToDecprsFile = new System.Windows.Forms.TextBox();
            this.btDecprs = new System.Windows.Forms.Button();
            this.btToDecprsFileSelct = new System.Windows.Forms.Button();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.txtDecprsPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combCprsType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.combCprsType);
            this.groupBox1.Controls.Add(this.btCprs);
            this.groupBox1.Controls.Add(this.btToCprsFileSelct);
            this.groupBox1.Controls.Add(this.txtToCprsFile);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 109);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "压缩";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btDecprs);
            this.groupBox2.Controls.Add(this.btToDecprsFileSelct);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtDecprsPath);
            this.groupBox2.Controls.Add(this.txtToDecprsFile);
            this.groupBox2.Location = new System.Drawing.Point(12, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 107);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "解压";
            // 
            // dirSch
            // 
            this.dirSch.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.dirSch.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.dirSch.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "源文件";
            // 
            // txtToCprsFile
            // 
            this.txtToCprsFile.Location = new System.Drawing.Point(73, 26);
            this.txtToCprsFile.Name = "txtToCprsFile";
            this.txtToCprsFile.Size = new System.Drawing.Size(304, 21);
            this.txtToCprsFile.TabIndex = 1;
            // 
            // btToCprsFileSelct
            // 
            this.btToCprsFileSelct.Location = new System.Drawing.Point(383, 26);
            this.btToCprsFileSelct.Name = "btToCprsFileSelct";
            this.btToCprsFileSelct.Size = new System.Drawing.Size(58, 23);
            this.btToCprsFileSelct.TabIndex = 2;
            this.btToCprsFileSelct.Text = "浏览...";
            this.btToCprsFileSelct.UseVisualStyleBackColor = true;
            this.btToCprsFileSelct.Click += new System.EventHandler(this.btCprsFileSelct_Click);
            // 
            // btCprs
            // 
            this.btCprs.Location = new System.Drawing.Point(383, 66);
            this.btCprs.Name = "btCprs";
            this.btCprs.Size = new System.Drawing.Size(58, 23);
            this.btCprs.TabIndex = 2;
            this.btCprs.Text = "压缩";
            this.btCprs.UseVisualStyleBackColor = true;
            this.btCprs.Click += new System.EventHandler(this.btCprs_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "源文件";
            // 
            // txtToDecprsFile
            // 
            this.txtToDecprsFile.Location = new System.Drawing.Point(73, 23);
            this.txtToDecprsFile.Name = "txtToDecprsFile";
            this.txtToDecprsFile.Size = new System.Drawing.Size(304, 21);
            this.txtToDecprsFile.TabIndex = 1;
            // 
            // btDecprs
            // 
            this.btDecprs.Location = new System.Drawing.Point(383, 68);
            this.btDecprs.Name = "btDecprs";
            this.btDecprs.Size = new System.Drawing.Size(58, 23);
            this.btDecprs.TabIndex = 2;
            this.btDecprs.Text = "解压";
            this.btDecprs.UseVisualStyleBackColor = true;
            this.btDecprs.Click += new System.EventHandler(this.btDecprs_Click);
            // 
            // btToDecprsFileSelct
            // 
            this.btToDecprsFileSelct.Location = new System.Drawing.Point(383, 23);
            this.btToDecprsFileSelct.Name = "btToDecprsFileSelct";
            this.btToDecprsFileSelct.Size = new System.Drawing.Size(58, 23);
            this.btToDecprsFileSelct.TabIndex = 2;
            this.btToDecprsFileSelct.Text = "浏览...";
            this.btToDecprsFileSelct.UseVisualStyleBackColor = true;
            this.btToDecprsFileSelct.Click += new System.EventHandler(this.btDecprsFileSelct_Click);
            // 
            // openFileDlg
            // 
            this.openFileDlg.FileName = "openFileDialog1";
            // 
            // txtDecprsPath
            // 
            this.txtDecprsPath.Location = new System.Drawing.Point(73, 68);
            this.txtDecprsPath.Name = "txtDecprsPath";
            this.txtDecprsPath.Size = new System.Drawing.Size(304, 21);
            this.txtDecprsPath.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "解压路径";
            // 
            // combCprsType
            // 
            this.combCprsType.FormattingEnabled = true;
            this.combCprsType.Items.AddRange(new object[] {
            "Rar",
            "Zip",
            "Gzip",
            "Bzip2",
            "Tar | Gzip",
            "Tar | Bizp2"});
            this.combCprsType.Location = new System.Drawing.Point(73, 66);
            this.combCprsType.Name = "combCprsType";
            this.combCprsType.Size = new System.Drawing.Size(69, 20);
            this.combCprsType.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "压缩格式";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 275);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btCprs;
        private System.Windows.Forms.Button btToCprsFileSelct;
        private System.Windows.Forms.TextBox txtToCprsFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btDecprs;
        private System.Windows.Forms.Button btToDecprsFileSelct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtToDecprsFile;
        private System.DirectoryServices.DirectorySearcher dirSch;
        private System.Windows.Forms.OpenFileDialog openFileDlg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combCprsType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDecprsPath;
    }
}

