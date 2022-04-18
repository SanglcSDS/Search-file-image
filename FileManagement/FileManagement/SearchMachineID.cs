using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManagement
{
    public partial class SearchMachineID : Form
    {
        private static string[] MACHINE_ID = ConfigurationManager.AppSettings["Machine_ID"].Split(new char[] { ',' });
        DataTable table;
        public SearchMachineID(Form parentForm)
        {
            InitializeComponent();

        }


        private void SearchMachineID_Load(object sender, EventArgs e)
        {
            table = new DataTable();

            table.Columns.Add("IP, Port", typeof(string));
            table.Columns.Add("STT", typeof(int));
            dataGridView1.DataSource = table;
            /*      this.dataGridView1.Columns[1].Width = 400;
                  this.dataGridView1.Columns[2].Width = 400;*/
            //  this.dataGridView1.Columns[3].Width = 400;

            for (int i = 0; i < MACHINE_ID.Length; i++)
            {

                table.Rows.Add(MACHINE_ID[i], i + 1);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Connect")
            {

              //  dataGridView1.Columns[e.ColumnIndex].
                MessageBox.Show("sssss");
            }

        }
    }
}
