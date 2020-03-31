namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_keyword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pb_download = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.nu_num = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.rb_small = new System.Windows.Forms.RadioButton();
            this.rb_middle = new System.Windows.Forms.RadioButton();
            this.rb_big = new System.Windows.Forms.RadioButton();
            this.rb_supper = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nu_num)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入关键词";
            // 
            // tb_keyword
            // 
            this.tb_keyword.Location = new System.Drawing.Point(183, 64);
            this.tb_keyword.Name = "tb_keyword";
            this.tb_keyword.Size = new System.Drawing.Size(203, 21);
            this.tb_keyword.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "输入抓取数量";
            // 
            // pb_download
            // 
            this.pb_download.Location = new System.Drawing.Point(66, 325);
            this.pb_download.Name = "pb_download";
            this.pb_download.Size = new System.Drawing.Size(364, 23);
            this.pb_download.TabIndex = 4;
            this.pb_download.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "抓取";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nu_num
            // 
            this.nu_num.Location = new System.Drawing.Point(183, 123);
            this.nu_num.Name = "nu_num";
            this.nu_num.Size = new System.Drawing.Size(203, 21);
            this.nu_num.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "设置下载路径";
            // 
            // tb_path
            // 
            this.tb_path.Location = new System.Drawing.Point(183, 177);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(131, 21);
            this.tb_path.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(320, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "选择路径";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rb_small
            // 
            this.rb_small.AutoSize = true;
            this.rb_small.Location = new System.Drawing.Point(183, 224);
            this.rb_small.Name = "rb_small";
            this.rb_small.Size = new System.Drawing.Size(35, 16);
            this.rb_small.TabIndex = 10;
            this.rb_small.TabStop = true;
            this.rb_small.Text = "小";
            this.rb_small.UseVisualStyleBackColor = true;
            this.rb_small.CheckedChanged += new System.EventHandler(this.rb_small_CheckedChanged);
            // 
            // rb_middle
            // 
            this.rb_middle.AutoSize = true;
            this.rb_middle.Location = new System.Drawing.Point(224, 224);
            this.rb_middle.Name = "rb_middle";
            this.rb_middle.Size = new System.Drawing.Size(35, 16);
            this.rb_middle.TabIndex = 11;
            this.rb_middle.TabStop = true;
            this.rb_middle.Text = "中";
            this.rb_middle.UseVisualStyleBackColor = true;
            this.rb_middle.CheckedChanged += new System.EventHandler(this.rb_middle_CheckedChanged);
            // 
            // rb_big
            // 
            this.rb_big.AutoSize = true;
            this.rb_big.Location = new System.Drawing.Point(279, 224);
            this.rb_big.Name = "rb_big";
            this.rb_big.Size = new System.Drawing.Size(35, 16);
            this.rb_big.TabIndex = 12;
            this.rb_big.TabStop = true;
            this.rb_big.Text = "大";
            this.rb_big.UseVisualStyleBackColor = true;
            this.rb_big.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rb_supper
            // 
            this.rb_supper.AutoSize = true;
            this.rb_supper.Checked = true;
            this.rb_supper.Location = new System.Drawing.Point(339, 224);
            this.rb_supper.Name = "rb_supper";
            this.rb_supper.Size = new System.Drawing.Size(47, 16);
            this.rb_supper.TabIndex = 13;
            this.rb_supper.TabStop = true;
            this.rb_supper.Text = "特大";
            this.rb_supper.UseVisualStyleBackColor = true;
            this.rb_supper.CheckedChanged += new System.EventHandler(this.rb_supper_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "设置下载尺寸";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rb_supper);
            this.Controls.Add(this.rb_big);
            this.Controls.Add(this.rb_middle);
            this.Controls.Add(this.rb_small);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tb_path);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nu_num);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pb_download);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_keyword);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "百度图片抓取器";
            ((System.ComponentModel.ISupportInitialize)(this.nu_num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_keyword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar pb_download;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown nu_num;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.RadioButton rb_small;
        private System.Windows.Forms.RadioButton rb_middle;
        private System.Windows.Forms.RadioButton rb_big;
        private System.Windows.Forms.RadioButton rb_supper;
        private System.Windows.Forms.Label label4;
    }
}

