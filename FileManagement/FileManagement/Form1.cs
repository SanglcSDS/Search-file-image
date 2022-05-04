using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Net;
using System.Net.Sockets;
using Nancy.Json;
using Newtonsoft.Json;
using System.Globalization;
using Newtonsoft.Json.Linq;
using System.Threading;

namespace FileManagement
{
    public partial class Form1 : Form
    {
       // private static string[] MACHINE_ID = ConfigurationManager.AppSettings["Machine_ID"].Split(new char[] { ',' });
        private static string URL_PART_MACHINE_ID = ConfigurationManager.AppSettings["Url_Part_Machine_ID"];
        public static int IP_ATM = Int32.Parse(ConfigurationManager.AppSettings["port_atm"]);
        public static int CHECK_CONNECTION_TIMEOUT = Int32.Parse(ConfigurationManager.AppSettings["check_connection_timeout"]);
        public static List<ModelMachine> listMachine;
        public static Socket socketATM;
        public static List<ModelInfoImage> modelInfoImages;
        public static int TotalFiles;
        public static List<string> listFullPart;
        TcpClient tcpClient;
        DataTable table;


        public Form1()
        {


            InitializeComponent();
           backgroundWorker1 = new BackgroundWorker();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;

            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("STT", typeof(int));
            table.Columns.Add("Tên File", typeof(string));
            table.Columns.Add("Thư mục", typeof(string));
            table.Columns.Add("Kích thức", typeof(string));
            listMachine = new List<ModelMachine>();
            listMachine =Utils.listMachines(URL_PART_MACHINE_ID,comboBox1);
       
            this.dataGridView1.Controls.Add(HeaderCheckBox);

            dataGridView1.DataSource = table;
            this.dataGridView1.Columns[2].Width = 400;
            this.dataGridView1.Columns[3].Width = 400;

            AddHeaderCheckBox();

            HeaderCheckBox.MouseClick += new MouseEventHandler(HeaderCheckBox_MouseClick);
        }





        private void bt_search_Click(object sender, EventArgs e)
        {
            //  bt_search.Enabled = false;

            if (socketATM != null)
            {
                if (IsConnected())
                {
                    backgroundWorker1.CancelAsync();
                    lb_result.Text = "Kết quả";

                   // lblProgress.Text = "";
                    if (modelInfoImages != null)
                        modelInfoImages.Clear();
                    if (listFullPart != null)
                        listFullPart.Clear();
                    table = new DataTable();
                    table.Columns.Add("STT", typeof(int));
                    table.Columns.Add("Tên File", typeof(string));
                    table.Columns.Add("Thư mục", typeof(string));
                    table.Columns.Add("Kích thức", typeof(string));
                    backgroundWorker1 = new BackgroundWorker();
                    backgroundWorker1.WorkerReportsProgress = true;
                    backgroundWorker1.WorkerSupportsCancellation = true;
                    dataGridView1.DataSource = table;

                    backgroundWorker1.DoWork += backgroundWorker1_DoWork;
                    backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
                    backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
                    dataGridView1.Refresh();
                    ModelMessage parameter = new ModelMessage
                    {
                        Status = "Search",
                        Messege = "",
                        Url = null,
                        TotalFiles = 0,
                        modelInfoImage = null,
                        modelParameter = new ModelParameter
                        {
                            CardNumber = txt_CardNumber.Text,
                            TransNo = txt_TransNo.Text,
                            TransactionDate = DateTime.ParseExact(date_TransactionDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("yyyyMMdd"),
                        }
                    };
                    string jsonparameter = new JavaScriptSerializer().Serialize(parameter);
                    if (IsConnected())
                    {

                        Byte[] data = Encoding.UTF8.GetBytes(jsonparameter);
                        socketATM.Send(data);

                    }

                    if (IsConnected())
                    {
                        while (true)
                        {

                            Byte[] data = Utils.ReceiveAll(socketATM);


                            if (data.Length > 0)
                            {


                                string dataSearch = Encoding.UTF8.GetString(data);
                                ModelMessage modelMessage = JsonConvert.DeserializeObject<ModelMessage>(dataSearch);
                                if (modelMessage.Status.Equals("END"))
                                {
                                    bt_search.Enabled = true;
                                    MessageBox.Show(modelMessage.Messege);
                                    return;
                                }
                                else if (modelMessage.Status.Equals("DATA"))
                                {

                                    modelInfoImages = new List<ModelInfoImage>();
                                    modelInfoImages.AddRange(modelMessage.modelInfoImage);
                                    TotalFiles = modelMessage.TotalFiles;
                                    backgroundWorker1.RunWorkerAsync();
                                    return;
                                }
                            }


                        }



                    }
                }
                else
                {
                    bt_search.Enabled = true;
                    MessageBox.Show("Connec ID máy không thành công ");
                }
            }
            else
            {
                bt_search.Enabled = true;
                MessageBox.Show("Connec ID máy không thành công ");
            }



        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            for (int i = 0; i < modelInfoImages.Count; i++)
            {
              //  lblProgress.Invoke((Action)(() => lblProgress.Text = modelInfoImages[i].Name));
                backgroundWorker1.ReportProgress((int)(i / modelInfoImages.Count * 100));

                dataGridView1.Invoke((Action)(() =>
                {
                    table.Rows.Add(i + 1, modelInfoImages[i].Name, modelInfoImages[i].Url, modelInfoImages[i].size);
                }));

            }

            backgroundWorker1.ReportProgress(100);
        }




        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {


            lb_result.Text = String.Format("Tìm thấy {0}/{1} tệp tin.", table.Rows.Count, TotalFiles);



        }


        CheckBox HeaderCheckBox = null;
        bool IsHeaderCheckBoxClicked = false;
        private void AddHeaderCheckBox()
        {
            HeaderCheckBox = new CheckBox();
            HeaderCheckBox.Size = new Size(15, 15);

            this.dataGridView1.Controls.Add(HeaderCheckBox);
        }
        private void HeaderCheckBoxClick(CheckBox HcheckBox)
        {
            IsHeaderCheckBoxClicked = true;
            foreach (DataGridViewRow Row in dataGridView1.Rows)
            {
                if (HcheckBox.Checked == true)
                {
                    Row.Cells[0].Style.BackColor = Color.LightGreen;
                    Row.Cells[1].Style.BackColor = Color.LightGreen;
                    Row.Cells[2].Style.BackColor = Color.LightGreen;
                    Row.Cells[3].Style.BackColor = Color.LightGreen;
                    Row.Cells[4].Style.BackColor = Color.LightGreen;

                }
                else
                {
                    Row.Cells[0].Style.BackColor = Color.White;
                    Row.Cells[1].Style.BackColor = Color.White;
                    Row.Cells[2].Style.BackColor = Color.White;
                    Row.Cells[3].Style.BackColor = Color.White;
                    Row.Cells[4].Style.BackColor = Color.White;
                }
                ((DataGridViewCheckBoxCell)Row.Cells["chk"]).Value = HcheckBox.Checked;

            }
            dataGridView1.RefreshEdit();
            IsHeaderCheckBoxClicked = false;
        }
        private void HeaderCheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            HeaderCheckBoxClick((CheckBox)sender);
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            if (row.Cells["chk"].Value == null)
            {
                ((DataGridViewCheckBoxCell)row.Cells["chk"]).Value = true;
                if (!(row.Cells["chk"].Value.ToString()).Equals("False"))
                {
                    dataGridView1.Rows[e.RowIndex].Cells[1].Style.BackColor = Color.LightGreen;
                    dataGridView1.Rows[e.RowIndex].Cells[2].Style.BackColor = Color.LightGreen;
                    dataGridView1.Rows[e.RowIndex].Cells[3].Style.BackColor = Color.LightGreen;
                    dataGridView1.Rows[e.RowIndex].Cells[4].Style.BackColor = Color.LightGreen;
                }

            }
            else
            {

                if ((row.Cells["chk"].Value.ToString()).Equals("False"))
                {
                    ((DataGridViewCheckBoxCell)row.Cells["chk"]).Value = true;
                    if (!(row.Cells["chk"].Value.ToString()).Equals("False"))
                    {
                        dataGridView1.Rows[e.RowIndex].Cells[1].Style.BackColor = Color.LightGreen;
                        dataGridView1.Rows[e.RowIndex].Cells[2].Style.BackColor = Color.LightGreen;
                        dataGridView1.Rows[e.RowIndex].Cells[3].Style.BackColor = Color.LightGreen;
                        dataGridView1.Rows[e.RowIndex].Cells[4].Style.BackColor = Color.LightGreen;
                    }
                }
                else
                {

                    ((DataGridViewCheckBoxCell)row.Cells["chk"]).Value = false;
                    if ((row.Cells["chk"].Value.ToString()).Equals("False"))
                    {
                        dataGridView1.Rows[e.RowIndex].Cells[1].Style.BackColor = Color.White;
                        dataGridView1.Rows[e.RowIndex].Cells[2].Style.BackColor = Color.White;
                        dataGridView1.Rows[e.RowIndex].Cells[3].Style.BackColor = Color.White;
                        dataGridView1.Rows[e.RowIndex].Cells[4].Style.BackColor = Color.White;
                    }
                }



            }
            dataGridView1.RefreshEdit();
        }


        private void btn_copy_Click(object sender, EventArgs e)
        {
            listFullPart = new List<string>();
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells["chk"].Value) == true)
                {
                    if (dataGridView1.Rows[i].Cells[3].Value != null)
                    {
                        listFullPart.Add(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    }


                }

            }

            if (listFullPart.Count > 0)
            {
                if (IsConnected())
                {
                    copyFile f = new copyFile(this);
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Connec ID máy không thành công ");

                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn file cần copy");

            }


        }

        private void btn_machine_IP_Click(object sender, EventArgs e)
        {
            try
            {

                if (comboBox1.SelectedItem != null)
                {
                    lb_result.Text = "Kết quả";
                    if (btn_machine_IP.Text == "Connect ID Máy ")
                    {
                        btn_machine_IP.Enabled = false;
                        comboBox1.Enabled = false;
                        btn_machine_IP.Text = "Close ID Máy ";
                        this.lb_connect.Text = "Connect to " + comboBox1.SelectedItem.ToString();
                        ModelMachine result = listMachine.Find(x => x.IDMachine == comboBox1.SelectedItem.ToString());
                        tcpClient = new TcpClient(result.ip, IP_ATM);
                        socketATM = tcpClient.Client;
                        if (socketATM.Connected)
                        {
                            btn_machine_IP.Enabled = true;
                            this.lb_connect.Text = "Connect to " + result.IDMachine + " success";
                            this.lb_connect.ForeColor = Color.FromArgb(124, 252, 0);
                        }
                        else
                        {
                            btn_machine_IP.Enabled = true;
                            this.lb_connect.Text = "Connect to " + result.IDMachine + "failed";
                            this.lb_connect.ForeColor = Color.FromArgb(255, 0, 0);
                            socketATM.Close();
                            tcpClient.Close();
                        }

                    }
                    else
                    {
                        btn_machine_IP.Enabled = true;
                        comboBox1.Enabled = true;
                        btn_machine_IP.Text = "Connect ID Máy ";
                        this.lb_connect.Text = "";
                        if (socketATM != null)
                            socketATM.Close();
                        if (tcpClient != null)
                            tcpClient.Close();
                    }

                }

                else
                {
                    MessageBox.Show("Bạn chưa nhập ID máy");
                }
            }
            catch (Exception ex)
            {
                btn_machine_IP.Enabled = true;
                this.lb_connect.Text = "Connect to " + comboBox1.SelectedItem.ToString() + " failed";
                this.lb_connect.ForeColor = Color.FromArgb(255, 0, 0);
            }

        }

        public static bool IsConnected()
        {
            try
            {
                bool check = !(socketATM.Poll(CHECK_CONNECTION_TIMEOUT, SelectMode.SelectRead) && socketATM.Available == 0);
                //if (!check)
                //    Logger.Log("Host not responding");
                return check;
            }
            catch (SocketException)
            {
                //Logger.Log("Host not responding");
                return false;
            }
            catch (ObjectDisposedException)
            {
                //Logger.Log("Host not responding");
                return false;
            }
        }


    }
}
