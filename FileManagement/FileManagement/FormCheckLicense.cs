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

namespace FileManagement
{
    public partial class FormCheckLicense : Form
    {
        private string prKey1 = "TGUgQ29uZyBTYW5nIERldg";
        private string prKey2 = "TGUgQ29uZyBTYW5nIERKENSldg";
        Form opener;
        public FormCheckLicense(Form parentForm)
        {
            opener = parentForm;
            InitializeComponent();
        }

        private void btn_key_public_Click(object sender, EventArgs e)
        {
            try
            {

                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine(txt_key_public.Text);
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = Environment.CurrentDirectory;
                saveFileDialog.Title = "Save Public Key";
                saveFileDialog.FileName = "PublicKey.txt";
                saveFileDialog.DefaultExt = "txt";
                saveFileDialog.Filter = "Text files (*.txt)|*.txt";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, stringBuilder.ToString());
                    MessageBox.Show("Save Public Key success.", "Save Public", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save Public Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        private bool CheckLicense(string keypublic)
        {
            try
            {
                string cipherText = ManagedAes.Decrypt(keypublic ?? "ABCDEF", prKey2);
                cipherText = ManagedAes.Decrypt(cipherText, prKey2);
                if (HardwareInfo.IsInvalid(cipherText))
                {
                    License_Update();
                    return true;
                }
            }
            catch
            {
            }
            return false;
        }
        private bool License_Update()
        {
            try
            {
                string clearText = ManagedAes.Encrypt(HardwareInfo.Info(), prKey2);
                clearText = ManagedAes.Encrypt(clearText, prKey2);
                Regedit.WriteKey(Form1.ReadConfigKey, "PrivateKey", clearText);
            }
            catch (Exception ex)
            {

            }
            return false;
        }
        private void FormCheckLicense_Load(object sender, EventArgs e)
        {
            txt_key_public.Text = "\"PUBLICKEY\"=\"" + Form1.keyPublic + "\"";

        }

        private void btn_save_key_Private_Click(object sender, EventArgs e)
        {
            string text = txt_key_private.Text.Trim();

            if (text.StartsWith("\"PRIVATEKEY\"="))
            {
                text = text.Replace("\"PRIVATEKEY\"=", "").Trim('"');
                if (CheckLicense(text))
                {

                    Form1 form1 = new Form1();
                    Hide();
                    form1.Show();
                    // MessageBox.Show("Oki crack thanh cong");


                }
                else
                {
                    MessageBox.Show("Key không đúng liên hệ với admin");


                }

            }
            else
            {
                MessageBox.Show(" Key Không đúng định dạng");
            }
        }

    }
}
