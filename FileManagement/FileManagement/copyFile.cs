using Microsoft.WindowsAPICodePack.Dialogs;
using Nancy.Json;
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
    public partial class copyFile : Form
    {
        BackgroundWorker worker = new BackgroundWorker();
        Form opener;
        public copyFile(Form parentForm)
        {
            InitializeComponent();
            opener = parentForm;
            worker.WorkerSupportsCancellation = true;
            worker.WorkerReportsProgress = true;
            worker.ProgressChanged += backgroundWorker1_ProgressChanged;
            worker.DoWork += backgroundWorker1_DoWork;
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            lb_total_file.Text = "Tổng file copy: " + Form1.listFullPart.Count.ToString();


        }
        private void CopyFile(List<string> listFileSource, string target)
        {
            try
            {
                if (Utils.PathLocation(target, "Đường dẫn lưu file copy không đúng"))
                {
                    for (int i = 0; i < listFileSource.Count; i++)
                    {

                        string[] arrListStr = listFileSource[i].Split('\\');
                        lblProgress.Invoke((Action)(() => lblProgress.Text = arrListStr[arrListStr.Length - 1]));
                        worker.ReportProgress((int)(((i+1) * 100) / (listFileSource.Count )));

                        //     File.Copy(listFileSource[i], target + "\\" + arrListStr[arrListStr.Length - 1], true);

                        if (Form1.IsConnected())
                        {
                            ModelMessage parameter = new ModelMessage
                            {
                                Status = "COPY",
                                Messege = "",
                                Url = listFileSource[i],
                                modelInfoImage = null,
                                modelParameter=null
                            };
                            string jsonparameter = new JavaScriptSerializer().Serialize(parameter);

                            Byte[] data = Encoding.UTF8.GetBytes(jsonparameter);

                            Form1.socketATM.Send(data);
                        }
                        while (true)
                        {
                            if (Form1.IsConnected())
                            {
                                Byte[] data = Utils.ReceiveAll(Form1.socketATM);


                                if (data.Length > 0)
                                {
                                    Utils.ConvertImage(target + "\\" + arrListStr[arrListStr.Length - 1], data);
                                    break;
                                }


                            }

                        }


                    }


                }
            }
            catch (Exception)
            {
              //  MessageBox.Show("Đường dẫn lưu file trùng đường dẫn thư mục");
            }


        }

        private void btn_copy_file_Click(object sender, EventArgs e)
        {
            worker.RunWorkerAsync();



        }

        private void open_folder_file_Click(object sender, EventArgs e)
        {

            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txt_copy_folder.Text = dialog.FileName;
            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            CopyFile(Form1.listFullPart, txt_copy_folder.Text);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            lb_percent.Text = progressBar1.Value.ToString() + "%";
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                DialogResult result = MessageBox.Show("Copy file thành công ");
                if (result == DialogResult.OK)
                {
                    this.Close();
                }

            }
        }

        private void copyFile_FormClosing(object sender, FormClosingEventArgs e)
        {
           
                if (worker.IsBusy)
            {

                if (e.CloseReason == CloseReason.WindowsShutDown) return;

                if (this.DialogResult == DialogResult.Cancel)
                {

                    switch (MessageBox.Show(this, "Bạn chắc muốn thoát chứ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {

                        case DialogResult.No:
                            e.Cancel = true;
                            break;
                        default:
                            break;
                    }
                }
            }



        }
    }
}
