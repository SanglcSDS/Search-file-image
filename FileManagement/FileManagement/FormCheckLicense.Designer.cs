
namespace FileManagement
{
    partial class FormCheckLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCheckLicense));
            this.txt_key_public = new System.Windows.Forms.TextBox();
            this.txt_key_private = new System.Windows.Forms.TextBox();
            this.btn_key_public = new System.Windows.Forms.Button();
            this.btn_save_key_Private = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_key_public
            // 
            this.txt_key_public.Location = new System.Drawing.Point(10, 19);
            this.txt_key_public.Multiline = true;
            this.txt_key_public.Name = "txt_key_public";
            this.txt_key_public.Size = new System.Drawing.Size(494, 159);
            this.txt_key_public.TabIndex = 0;
            // 
            // txt_key_private
            // 
            this.txt_key_private.Location = new System.Drawing.Point(9, 19);
            this.txt_key_private.Multiline = true;
            this.txt_key_private.Name = "txt_key_private";
            this.txt_key_private.Size = new System.Drawing.Size(494, 172);
            this.txt_key_private.TabIndex = 1;
            // 
            // btn_key_public
            // 
            this.btn_key_public.Location = new System.Drawing.Point(10, 184);
            this.btn_key_public.Name = "btn_key_public";
            this.btn_key_public.Size = new System.Drawing.Size(494, 31);
            this.btn_key_public.TabIndex = 2;
            this.btn_key_public.Text = "Save File Public Key ";
            this.btn_key_public.UseVisualStyleBackColor = true;
            this.btn_key_public.Click += new System.EventHandler(this.btn_key_public_Click);
            // 
            // btn_save_key_Private
            // 
            this.btn_save_key_Private.Location = new System.Drawing.Point(10, 203);
            this.btn_save_key_Private.Name = "btn_save_key_Private";
            this.btn_save_key_Private.Size = new System.Drawing.Size(493, 29);
            this.btn_save_key_Private.TabIndex = 3;
            this.btn_save_key_Private.Text = "Activate license key";
            this.btn_save_key_Private.UseVisualStyleBackColor = true;
            this.btn_save_key_Private.Click += new System.EventHandler(this.btn_save_key_Private_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_key_public);
            this.groupBox1.Controls.Add(this.btn_key_public);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 229);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Public Key";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_key_private);
            this.groupBox2.Controls.Add(this.btn_save_key_Private);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(530, 238);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Private Key";
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.26931F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.73069F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(536, 479);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // FormCheckLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 479);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCheckLicense";
            this.Load += new System.EventHandler(this.FormCheckLicense_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_key_public;
        private System.Windows.Forms.TextBox txt_key_private;
        private System.Windows.Forms.Button btn_key_public;
        private System.Windows.Forms.Button btn_save_key_Private;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}