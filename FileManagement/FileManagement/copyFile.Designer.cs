
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
            this.txt_copy_folder = new System.Windows.Forms.TextBox();
            this.btn_open_folder_file = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_copy_file = new System.Windows.Forms.Button();
            this.lb_total_file = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lb_percent = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblProgress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_copy_folder
            // 
            this.txt_copy_folder.Location = new System.Drawing.Point(184, 42);
            this.txt_copy_folder.Name = "txt_copy_folder";
            this.txt_copy_folder.Size = new System.Drawing.Size(411, 20);
            this.txt_copy_folder.TabIndex = 0;
            // 
            // btn_open_folder_file
            // 
            this.btn_open_folder_file.Location = new System.Drawing.Point(601, 39);
            this.btn_open_folder_file.Name = "btn_open_folder_file";
            this.btn_open_folder_file.Size = new System.Drawing.Size(135, 23);
            this.btn_open_folder_file.TabIndex = 1;
            this.btn_open_folder_file.Text = "Chọn thư mục liêu file";
            this.btn_open_folder_file.UseVisualStyleBackColor = true;
            this.btn_open_folder_file.Click += new System.EventHandler(this.open_folder_file_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đường dẫn lưu file";
            // 
            // btn_copy_file
            // 
            this.btn_copy_file.Location = new System.Drawing.Point(626, 158);
            this.btn_copy_file.Name = "btn_copy_file";
            this.btn_copy_file.Size = new System.Drawing.Size(75, 23);
            this.btn_copy_file.TabIndex = 3;
            this.btn_copy_file.Text = "Copy";
            this.btn_copy_file.UseVisualStyleBackColor = true;
            this.btn_copy_file.Click += new System.EventHandler(this.btn_copy_file_Click);
            // 
            // lb_total_file
            // 
            this.lb_total_file.AutoSize = true;
            this.lb_total_file.Location = new System.Drawing.Point(93, 9);
            this.lb_total_file.Name = "lb_total_file";
            this.lb_total_file.Size = new System.Drawing.Size(77, 13);
            this.lb_total_file.TabIndex = 4;
            this.lb_total_file.Text = "Tổng file copy:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(184, 99);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(411, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // lb_percent
            // 
            this.lb_percent.AutoSize = true;
            this.lb_percent.Location = new System.Drawing.Point(608, 109);
            this.lb_percent.Name = "lb_percent";
            this.lb_percent.Size = new System.Drawing.Size(21, 13);
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
            this.lblProgress.Location = new System.Drawing.Point(184, 80);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(35, 13);
            this.lblProgress.TabIndex = 7;
            this.lblProgress.Text = "label2";
            // 
            // copyFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 237);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.lb_percent);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lb_total_file);
            this.Controls.Add(this.btn_copy_file);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_open_folder_file);
            this.Controls.Add(this.txt_copy_folder);
            this.Name = "copyFile";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_copy_folder;
        private System.Windows.Forms.Button btn_open_folder_file;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_copy_file;
        private System.Windows.Forms.Label lb_total_file;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lb_percent;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblProgress;
    }
}