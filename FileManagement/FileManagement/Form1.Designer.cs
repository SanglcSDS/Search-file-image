
namespace FileManagement
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.bt_search = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblPercent = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lb_result = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_copy = new System.Windows.Forms.Button();
            this.date_TransactionDate = new System.Windows.Forms.DateTimePicker();
            this.btn_machine_IP = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_CardNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_TransNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_connect = new System.Windows.Forms.Label();
            this.chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_search
            // 
            this.bt_search.Location = new System.Drawing.Point(674, 92);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(121, 43);
            this.bt_search.TabIndex = 1;
            this.bt_search.Text = "Tìm kiếm";
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(204, 118);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(414, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Location = new System.Drawing.Point(624, 128);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(21, 13);
            this.lblPercent.TabIndex = 6;
            this.lblPercent.Text = "0%";
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(201, 94);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(35, 13);
            this.lblProgress.TabIndex = 7;
            this.lblProgress.Text = "label1";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lb_result
            // 
            this.lb_result.AutoSize = true;
            this.lb_result.Location = new System.Drawing.Point(61, 128);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(44, 13);
            this.lb_result.TabIndex = 9;
            this.lb_result.Text = "Kết quả";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chk});
            this.dataGridView1.Location = new System.Drawing.Point(24, 228);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(890, 234);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_copy
            // 
            this.btn_copy.Location = new System.Drawing.Point(161, 178);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(75, 23);
            this.btn_copy.TabIndex = 14;
            this.btn_copy.Text = "Copy File";
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // date_TransactionDate
            // 
            this.date_TransactionDate.CustomFormat = "dd/MM/yyyy";
            this.date_TransactionDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.date_TransactionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_TransactionDate.Location = new System.Drawing.Point(696, 43);
            this.date_TransactionDate.Name = "date_TransactionDate";
            this.date_TransactionDate.Size = new System.Drawing.Size(186, 20);
            this.date_TransactionDate.TabIndex = 15;
            // 
            // btn_machine_IP
            // 
            this.btn_machine_IP.Location = new System.Drawing.Point(613, 13);
            this.btn_machine_IP.Name = "btn_machine_IP";
            this.btn_machine_IP.Size = new System.Drawing.Size(106, 23);
            this.btn_machine_IP.TabIndex = 16;
            this.btn_machine_IP.Text = "Connect ID Máy ";
            this.btn_machine_IP.UseVisualStyleBackColor = true;
            this.btn_machine_IP.Click += new System.EventHandler(this.btn_machine_IP_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(177, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(424, 21);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "ID Máy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Số Thẻ";
            // 
            // txt_CardNumber
            // 
            this.txt_CardNumber.Location = new System.Drawing.Point(177, 43);
            this.txt_CardNumber.Name = "txt_CardNumber";
            this.txt_CardNumber.Size = new System.Drawing.Size(173, 20);
            this.txt_CardNumber.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Trans No";
            // 
            // txt_TransNo
            // 
            this.txt_TransNo.Location = new System.Drawing.Point(428, 43);
            this.txt_TransNo.Name = "txt_TransNo";
            this.txt_TransNo.Size = new System.Drawing.Size(173, 20);
            this.txt_TransNo.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(610, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Ngày Giao dịch";
            // 
            // lb_connect
            // 
            this.lb_connect.AutoSize = true;
            this.lb_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_connect.Location = new System.Drawing.Point(740, 16);
            this.lb_connect.Name = "lb_connect";
            this.lb_connect.Size = new System.Drawing.Size(0, 13);
            this.lb_connect.TabIndex = 24;
            // 
            // chk
            // 
            this.chk.HeaderText = "";
            this.chk.Name = "chk";
            this.chk.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 496);
            this.Controls.Add(this.lb_connect);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_TransNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_CardNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_machine_IP);
            this.Controls.Add(this.date_TransactionDate);
            this.Controls.Add(this.btn_copy);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lb_result);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.bt_search);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lb_result;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.DateTimePicker date_TransactionDate;
        private System.Windows.Forms.Button btn_machine_IP;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_CardNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_TransNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_connect;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk;
    }
}

