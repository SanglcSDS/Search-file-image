
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lb_connect = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_machine_IP = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_CardNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_TransNo = new System.Windows.Forms.TextBox();
            this.date_TransactionDate = new System.Windows.Forms.DateTimePicker();
            this.lb_result = new System.Windows.Forms.Label();
            this.bt_search = new System.Windows.Forms.Button();
            this.btn_copy = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lb_connect
            // 
            this.lb_connect.AutoSize = true;
            this.lb_connect.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_connect.Location = new System.Drawing.Point(739, 20);
            this.lb_connect.Name = "lb_connect";
            this.lb_connect.Size = new System.Drawing.Size(0, 17);
            this.lb_connect.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(9, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "ID Máy";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(57, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(540, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // btn_machine_IP
            // 
            this.btn_machine_IP.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_machine_IP.Location = new System.Drawing.Point(613, 12);
            this.btn_machine_IP.Name = "btn_machine_IP";
            this.btn_machine_IP.Size = new System.Drawing.Size(106, 28);
            this.btn_machine_IP.TabIndex = 16;
            this.btn_machine_IP.Text = "Connect ID Máy ";
            this.btn_machine_IP.UseVisualStyleBackColor = true;
            this.btn_machine_IP.Click += new System.EventHandler(this.btn_machine_IP_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(9, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Số Thẻ";
            // 
            // txt_CardNumber
            // 
            this.txt_CardNumber.Location = new System.Drawing.Point(57, 19);
            this.txt_CardNumber.Name = "txt_CardNumber";
            this.txt_CardNumber.Size = new System.Drawing.Size(162, 20);
            this.txt_CardNumber.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(462, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Ngày Giao dịch";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(230, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Trans No";
            // 
            // txt_TransNo
            // 
            this.txt_TransNo.Location = new System.Drawing.Point(287, 19);
            this.txt_TransNo.Name = "txt_TransNo";
            this.txt_TransNo.Size = new System.Drawing.Size(157, 20);
            this.txt_TransNo.TabIndex = 22;
            // 
            // date_TransactionDate
            // 
            this.date_TransactionDate.CustomFormat = "dd/MM/yyyy";
            this.date_TransactionDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.date_TransactionDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.date_TransactionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_TransactionDate.Location = new System.Drawing.Point(567, 19);
            this.date_TransactionDate.Name = "date_TransactionDate";
            this.date_TransactionDate.Size = new System.Drawing.Size(152, 22);
            this.date_TransactionDate.TabIndex = 15;
            // 
            // lb_result
            // 
            this.lb_result.AutoSize = true;
            this.lb_result.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lb_result.Location = new System.Drawing.Point(7, 60);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(48, 15);
            this.lb_result.TabIndex = 9;
            this.lb_result.Text = "Kết quả";
            // 
            // bt_search
            // 
            this.bt_search.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.bt_search.Location = new System.Drawing.Point(786, 16);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(94, 33);
            this.bt_search.TabIndex = 1;
            this.bt_search.Text = "Tìm kiếm";
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // btn_copy
            // 
            this.btn_copy.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_copy.Location = new System.Drawing.Point(9, 10);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(75, 30);
            this.btn_copy.TabIndex = 14;
            this.btn_copy.Text = "Copy File";
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chk});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(944, 374);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // chk
            // 
            this.chk.HeaderText = "";
            this.chk.Name = "chk";
            this.chk.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.btn_machine_IP);
            this.groupBox1.Controls.Add(this.lb_connect);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(944, 44);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.date_TransactionDate);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.bt_search);
            this.groupBox2.Controls.Add(this.txt_TransNo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lb_result);
            this.groupBox2.Controls.Add(this.txt_CardNumber);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(944, 83);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_copy);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 142);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(944, 46);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(950, 571);
            this.tableLayoutPanel1.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 571);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lb_connect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_machine_IP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_CardNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_TransNo;
        private System.Windows.Forms.DateTimePicker date_TransactionDate;
        private System.Windows.Forms.Label lb_result;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

