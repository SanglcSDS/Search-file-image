
namespace FileManagement
{
    partial class copyFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(copyFile));
            this.txt_copy_folder = new System.Windows.Forms.TextBox();
            this.btn_open_folder_file = new System.Windows.Forms.Button();
            this.btn_copy_file = new System.Windows.Forms.Button();
            this.lb_total_file = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lb_percent = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblProgress = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_copy_folder
            // 
            this.txt_copy_folder.Location = new System.Drawing.Point(164, 16);
            this.txt_copy_folder.Name = "txt_copy_folder";
            this.txt_copy_folder.Size = new System.Drawing.Size(411, 20);
            this.txt_copy_folder.TabIndex = 0;
            // 
            // btn_open_folder_file
            // 
            this.btn_open_folder_file.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_open_folder_file.Location = new System.Drawing.Point(603, 13);
            this.btn_open_folder_file.Name = "btn_open_folder_file";
            this.btn_open_folder_file.Size = new System.Drawing.Size(140, 23);
            this.btn_open_folder_file.TabIndex = 1;
            this.btn_open_folder_file.Text = "Chọn thư mục liêu file";
            this.btn_open_folder_file.UseVisualStyleBackColor = true;
            this.btn_open_folder_file.Click += new System.EventHandler(this.open_folder_file_Click);
            // 
            // btn_copy_file
            // 
            this.btn_copy_file.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_copy_file.Location = new System.Drawing.Point(648, 19);
            this.btn_copy_file.Name = "btn_copy_file";
            this.btn_copy_file.Size = new System.Drawing.Size(95, 61);
            this.btn_copy_file.TabIndex = 3;
            this.btn_copy_file.Text = "Copy";
            this.btn_copy_file.UseVisualStyleBackColor = true;
            this.btn_copy_file.Click += new System.EventHandler(this.btn_copy_file_Click);
            // 
            // lb_total_file
            // 
            this.lb_total_file.AutoSize = true;
            this.lb_total_file.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_total_file.Location = new System.Drawing.Point(9, 16);
            this.lb_total_file.Name = "lb_total_file";
            this.lb_total_file.Size = new System.Drawing.Size(87, 15);
            this.lb_total_file.TabIndex = 4;
            this.lb_total_file.Text = "Tổng file copy:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(164, 41);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(411, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // lb_percent
            // 
            this.lb_percent.AutoSize = true;
            this.lb_percent.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_percent.Location = new System.Drawing.Point(581, 49);
            this.lb_percent.Name = "lb_percent";
            this.lb_percent.Size = new System.Drawing.Size(29, 15);
            this.lb_percent.TabIndex = 6;
            this.lb_percent.Text = "0%";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(122, 16);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(0, 13);
            this.lblProgress.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_total_file);
            this.groupBox1.Controls.Add(this.txt_copy_folder);
            this.groupBox1.Controls.Add(this.btn_open_folder_file);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 46);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.lblProgress);
            this.groupBox2.Controls.Add(this.lb_percent);
            this.groupBox2.Controls.Add(this.btn_copy_file);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(764, 95);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.30657F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.69343F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(770, 153);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // copyFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(770, 153);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "copyFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.copyFile_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_copy_folder;
        private System.Windows.Forms.Button btn_open_folder_file;
        private System.Windows.Forms.Button btn_copy_file;
        private System.Windows.Forms.Label lb_total_file;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lb_percent;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}