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

namespace FileManagement
{
    public partial class Form1 : Form
    {
        private static string[] MACHINE_ID = ConfigurationManager.AppSettings["Machine_ID"].Split(new char[] { ',' });
        //  public static string[] LIST_FILE = ConfigurationManager.AppSettings["listfile"].Split(new char[] { ',' });
        public static int IP_ATM = Int32.Parse(ConfigurationManager.AppSettings["port_atm"]);

        public static List<Machine> listMachine;
        public Socket socketATM;
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
            table.Columns.Add("Tên File", typeof(string));
            table.Columns.Add("Thư mục", typeof(string));
            table.Columns.Add("Kích thức", typeof(string));
            listMachine = new List<Machine>();
            foreach (string item in MACHINE_ID)
            {
                Machine machine = new Machine();
                if (item.IndexOf(":") > 0)
                {
                    comboBox1.Items.Add(item.Split(new char[] { ':' })[0]);
                    machine.IDMachine = item.Split(new char[] { ':' })[0];
                    machine.ip = item.Split(new char[] { ':' })[1];


                    listMachine.Add(machine);

                }


            }






            this.dataGridView1.Controls.Add(HeaderCheckBox);

            dataGridView1.DataSource = table;
            this.dataGridView1.Columns[1].Width = 400;
            this.dataGridView1.Columns[2].Width = 400;

            AddHeaderCheckBox();

            HeaderCheckBox.MouseClick += new MouseEventHandler(HeaderCheckBox_MouseClick);
            // chkls_item_file.Items.AddRange(LIST_FILE);
        }
        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        private void bt_open_folder_Click(object sender, EventArgs e)
        {
            Console.WriteLine(listMachine.ToString());
            //  Console.WriteLine(MACHINE_ID);
            listFullPart = new List<string>();
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txt_folder.Text = dialog.FileName;
            }
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
                ((DataGridViewCheckBoxCell)Row.Cells["chk"]).Value = HcheckBox.Checked;

            }
            dataGridView1.RefreshEdit();
            IsHeaderCheckBoxClicked = false;
        }
        private void HeaderCheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            HeaderCheckBoxClick((CheckBox)sender);
        }
        private void bt_search_Click(object sender, EventArgs e)
        {
            string[] subdirs = Directory.GetDirectories(txt_folder.Text)
                            .Select(Path.GetFileName)
                            .ToArray();

            string[] folders = Directory.GetDirectories(txt_folder.Text, "*", SearchOption.AllDirectories);


            Console.WriteLine(folders);



            if (Utils.PathLocation(txt_folder.Text, "Đường dẫn thư mục không đúng"))
            {
                if (backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.CancelAsync();
                }
                else
                {
                    progressBar1.Value = progressBar1.Minimum;
                    bt_search.Text = "Dừng tìm";
                    //   listView1.Items.Clear();

                    //  Console.WriteLine(table.Rows.Count);
                    table.Clear();

                    // dataGridView1.Refresh();
                    backgroundWorker1.RunWorkerAsync();
                }
            }

        }

        private void txt_folder_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkls_item_file_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        public static List<string> listFullPart;

        public void AddToListView(string file)
        {
            FileInfo finfo = new FileInfo(file);
            dataGridView1.Invoke((Action)(() =>
            {
                var icon = Icon.ExtractAssociatedIcon(file);
                string key = Path.GetExtension(file);
                imageList1.Images.Add(key, icon.ToBitmap());
                imageList1.ImageSize = new Size(30, 30);

                table.Rows.Add(finfo.Name, finfo.DirectoryName, Math.Ceiling(finfo.Length / 1024f).ToString("0 KB"));
            }));

        }

        public void ScanDirectory(string directory, string searchPattern)
        {
            try
            {

                foreach (var file in Directory.GetFiles(directory))
                {
                    if (backgroundWorker1.CancellationPending)
                    {
                        return;
                    }

                    lblProgress.Invoke((Action)(() => lblProgress.Text = file));
                    if (file.Contains(searchPattern) && file.Contains(txt_content.Text))
                    {
                        listFullPart.Add(file);
                        AddToListView(file);
                    }
                }


                foreach (var dir in Directory.GetDirectories(directory))
                {
                    ScanDirectory(dir, searchPattern);
                }
            }
            catch
            {
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            string[] dirs = Directory.GetDirectories(txt_folder.Text);
            float length = dirs.Length;
            progressBar1.Invoke((Action)(() => progressBar1.Maximum = dirs.Length));
            ScanDirectory(txt_folder.Text, ".jpg");
            for (int i = 0; i < dirs.Length; i++)
            {
                backgroundWorker1.ReportProgress((int)(i / length * 100));
                ScanDirectory(dirs[i], ".jpg");
            }

            backgroundWorker1.ReportProgress(100);

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (!backgroundWorker1.CancellationPending)
            {
                lblPercent.Text = e.ProgressPercentage + "%";
                progressBar1.PerformStep();
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {


            lb_result.Text = String.Format("Tìm thấy {0} tập tin.", table.Rows.Count);
            lblProgress.Text = "";

            if (progressBar1.Value < progressBar1.Maximum)
            {
                lblProgress.Text = "Dừng tìm kiếm. " + lblProgress.Text;
            }
            bt_search.Text = "Tìm kiếm";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];



            if (row.Cells["chk"].Value == null)
            {
                ((DataGridViewCheckBoxCell)row.Cells["chk"]).Value = true;

            }
            else
            {
                Console.WriteLine(row.Cells["chk"].Value.ToString());
                if ((row.Cells["chk"].Value.ToString()).Equals("False"))
                {
                    ((DataGridViewCheckBoxCell)row.Cells["chk"]).Value = true;
                }
                else
                {
                    ((DataGridViewCheckBoxCell)row.Cells["chk"]).Value = false;
                }

            }
            dataGridView1.RefreshEdit();
        }


        private void btn_copy_Click(object sender, EventArgs e)
        {
            copyFile f = new copyFile(this);
            f.Show();

        }

        private void btn_machine_IP_Click(object sender, EventArgs e)
        {
           

            try
            {

                if (comboBox1.SelectedItem != null)
                {
                    if (btn_machine_IP.Text == "Connect ID Máy ")
                    {
                        btn_machine_IP.Enabled = false;
                        comboBox1.Enabled = false;
                        btn_machine_IP.Text = "Close ID Máy ";
                        this.lb_connect.Text = "Connect to " + comboBox1.SelectedItem.ToString();
                        Machine result = listMachine.Find(x => x.IDMachine == comboBox1.SelectedItem.ToString());
                        TcpClient newTcpClient = new TcpClient(result.ip, IP_ATM);
                        socketATM = newTcpClient.Client;
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
