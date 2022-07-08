using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCheckLicense
{
    public partial class Form1 : Form
    {
        private string prKey1 = "TGUgQ29uZyBTYW5nIERldg";
        private string prKey2 = "TGUgQ29uZyBTYW5nIERKENSldg";
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_key_Click(object sender, EventArgs e)
        {
            string text = txt_public_key.Text.Trim();

            if (text.StartsWith("\"PUBLICKEY\"="))
            {
                text = text.Replace("\"PUBLICKEY\"=", "").Trim('"');
                SavePrivateKey(text);

            }
            else
            {
                MessageBox.Show(" Key Không đúng định dạng");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_Save_icense_key.Enabled = false;

        }
        private void SavePrivateKey(string s)
        {
            try
            {
                s = ManagedAes.Decrypt(s, prKey1);
                s = ManagedAes.Decrypt(s, prKey1);
                s = ManagedAes.Encrypt(s, prKey2);
                s = ManagedAes.Encrypt(s, prKey2);
                txt_key.Text = "\"PRIVATEKEY\"=\"" + s + "\"";
                if (txt_key.Text != null && txt_key.Text != "")
                {
                    btn_Save_icense_key.Enabled = true;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " PrivateKey Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_pen_public_key_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Open Public Key";
                openFileDialog.DefaultExt = "txt";
                openFileDialog.Filter = "Files Text  (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                int num = 0;
                StreamReader streamReader = new StreamReader(openFileDialog.FileName);
                string text;
                while ((text = streamReader.ReadLine()) != null)
                {
                    num++;
                    if (text.StartsWith("\"PUBLICKEY\"="))
                    {

                        txt_public_key.Text = text;
                        return;
                    }
                }

                MessageBox.Show("Public key not invalid.", "Public key error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_Save_icense_key_Click(object sender, EventArgs e)
        {
            try
            {

                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine(txt_key.Text);

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = Environment.CurrentDirectory;
                saveFileDialog.Title = "Open Private Key";
                saveFileDialog.FileName = "PrivateKey.txt";
                saveFileDialog.DefaultExt = "txt";
                saveFileDialog.Filter = "Files Text  (*.txt)|*.txt";
                saveFileDialog.FilterIndex = 2;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, stringBuilder.ToString());
                    MessageBox.Show("Save Private Key success.", "Save PrivateKey", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " PrivateKey Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
