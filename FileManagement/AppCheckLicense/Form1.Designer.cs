
namespace AppCheckLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_key = new System.Windows.Forms.TextBox();
            this.btn_key = new System.Windows.Forms.Button();
            this.btn_pen_public_key = new System.Windows.Forms.Button();
            this.txt_public_key = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Save_icense_key = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_key
            // 
            this.txt_key.Location = new System.Drawing.Point(28, 19);
            this.txt_key.Multiline = true;
            this.txt_key.Name = "txt_key";
            this.txt_key.Size = new System.Drawing.Size(414, 147);
            this.txt_key.TabIndex = 0;
            // 
            // btn_key
            // 
            this.btn_key.Location = new System.Drawing.Point(28, 180);
            this.btn_key.Name = "btn_key";
            this.btn_key.Size = new System.Drawing.Size(146, 23);
            this.btn_key.TabIndex = 2;
            this.btn_key.Text = "generate license key";
            this.btn_key.UseVisualStyleBackColor = true;
            this.btn_key.Click += new System.EventHandler(this.btn_key_Click);
            // 
            // btn_pen_public_key
            // 
            this.btn_pen_public_key.Location = new System.Drawing.Point(28, 193);
            this.btn_pen_public_key.Name = "btn_pen_public_key";
            this.btn_pen_public_key.Size = new System.Drawing.Size(414, 23);
            this.btn_pen_public_key.TabIndex = 4;
            this.btn_pen_public_key.Text = "Open Public Key";
            this.btn_pen_public_key.UseVisualStyleBackColor = true;
            this.btn_pen_public_key.Click += new System.EventHandler(this.btn_pen_public_key_Click);
            // 
            // txt_public_key
            // 
            this.txt_public_key.Location = new System.Drawing.Point(28, 19);
            this.txt_public_key.Multiline = true;
            this.txt_public_key.Name = "txt_public_key";
            this.txt_public_key.Size = new System.Drawing.Size(414, 168);
            this.txt_public_key.TabIndex = 3;
            this.txt_public_key.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_public_key);
            this.groupBox1.Controls.Add(this.btn_pen_public_key);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 226);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Public Key";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Save_icense_key);
            this.groupBox2.Controls.Add(this.txt_key);
            this.groupBox2.Controls.Add(this.btn_key);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(471, 212);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output  Private Key";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.55556F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.44444F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(477, 450);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // btn_Save_icense_key
            // 
            this.btn_Save_icense_key.Location = new System.Drawing.Point(296, 180);
            this.btn_Save_icense_key.Name = "btn_Save_icense_key";
            this.btn_Save_icense_key.Size = new System.Drawing.Size(146, 23);
            this.btn_Save_icense_key.TabIndex = 3;
            this.btn_Save_icense_key.Text = "Save license key";
            this.btn_Save_icense_key.UseVisualStyleBackColor = true;
            this.btn_Save_icense_key.Click += new System.EventHandler(this.btn_Save_icense_key_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_key;
        private System.Windows.Forms.Button btn_key;
        private System.Windows.Forms.Button btn_pen_public_key;
        private System.Windows.Forms.TextBox txt_public_key;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_Save_icense_key;
    }
}

