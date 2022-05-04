
namespace SearchImage
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
            this.lb_total_file = new System.Windows.Forms.Label();
            this.txt_copy_folder = new System.Windows.Forms.TextBox();
            this.btn_open_folder_file = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_copy_file = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_percent = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_total_file
            // 
            this.lb_total_file.AutoSize = true;
            this.lb_total_file.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_total_file.Location = new System.Drawing.Point(6, 25);
            this.lb_total_file.Name = "lb_total_file";
            this.lb_total_file.Size = new System.Drawing.Size(87, 15);
            this.lb_total_file.TabIndex = 0;
            this.lb_total_file.Text = "Tổng file copy:";
            // 
            // txt_copy_folder
            // 
            this.txt_copy_folder.Location = new System.Drawing.Point(134, 21);
            this.txt_copy_folder.Name = "txt_copy_folder";
            this.txt_copy_folder.Size = new System.Drawing.Size(426, 23);
            this.txt_copy_folder.TabIndex = 1;
            // 
            // btn_open_folder_file
            // 
            this.btn_open_folder_file.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_open_folder_file.Location = new System.Drawing.Point(582, 21);
            this.btn_open_folder_file.Name = "btn_open_folder_file";
            this.btn_open_folder_file.Size = new System.Drawing.Size(153, 23);
            this.btn_open_folder_file.TabIndex = 2;
            this.btn_open_folder_file.Text = "Chọn thư mục liêu file";
            this.btn_open_folder_file.UseVisualStyleBackColor = true;
            this.btn_open_folder_file.Click += new System.EventHandler(this.btn_open_folder_file_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(134, 54);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(426, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // btn_copy_file
            // 
            this.btn_copy_file.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_copy_file.Location = new System.Drawing.Point(660, 22);
            this.btn_copy_file.Name = "btn_copy_file";
            this.btn_copy_file.Size = new System.Drawing.Size(75, 55);
            this.btn_copy_file.TabIndex = 4;
            this.btn_copy_file.Text = "Copy";
            this.btn_copy_file.UseVisualStyleBackColor = true;
            this.btn_copy_file.Click += new System.EventHandler(this.btn_copy_file_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_total_file);
            this.groupBox1.Controls.Add(this.txt_copy_folder);
            this.groupBox1.Controls.Add(this.btn_open_folder_file);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 55);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_percent);
            this.groupBox2.Controls.Add(this.lblProgress);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.btn_copy_file);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(764, 86);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // lb_percent
            // 
            this.lb_percent.AutoSize = true;
            this.lb_percent.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_percent.Location = new System.Drawing.Point(582, 54);
            this.lb_percent.Name = "lb_percent";
            this.lb_percent.Size = new System.Drawing.Size(29, 15);
            this.lb_percent.TabIndex = 6;
            this.lb_percent.Text = "0%";
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(70, 32);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(0, 15);
            this.lblProgress.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.86928F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.13072F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(770, 153);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // copyFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(770, 153);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "copyFile";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.copyFile_FormClosing_1);
            this.Load += new System.EventHandler(this.copyFile_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_total_file;
        private System.Windows.Forms.TextBox txt_copy_folder;
        private System.Windows.Forms.Button btn_open_folder_file;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_copy_file;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lb_percent;
        private System.Windows.Forms.Label lblProgress;
    }
}