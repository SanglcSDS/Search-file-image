using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchImage
{
    public static class Utils
    {
       

        public static bool  PathLocation(string value,string message)
        {
            try
            {
                if (Directory.Exists(value))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show(message);
                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(message);
            }
            return false;



        }


        public static void ConvertImage(string Url, byte[] data)
        {
            FileStream fs =   File.Create(Url);
          
            fs.Write(data, 0, data.Length);
            fs.Close();
        }


        public static byte[] ReceiveAll(Socket socket)
        {
            var buffer = new List<byte>();

            while (socket.Available > 0)
            {
                var currByte = new Byte[1];
                var byteCounter = socket.Receive(currByte, currByte.Length, SocketFlags.None);

                if (byteCounter.Equals(1))
                {
                    buffer.Add(currByte[0]);
                }
            }

            return buffer.ToArray();
        }
        public static List<ModelMachine> listMachines(string part, ComboBox comboBox1)
        {
            List<ModelMachine> listMachines = new List<ModelMachine>();
            using (var stream = new FileStream(path: part, mode: FileMode.Open, access: FileAccess.ReadWrite, share: FileShare.ReadWrite))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    string item;
                    while ((item = reader.ReadLine()) != null)
                    {
                        ModelMachine machine = new ModelMachine();
                        if (item.IndexOf(":") > 0)
                        {
                            comboBox1.Items.Add(item.Split(new char[] { ':' })[0]);
                            machine.IDMachine = item.Split(new char[] { ':' })[0];
                            machine.ip = item.Split(new char[] { ':' })[1];
                            listMachines.Add(machine);
                        }
                    }
                }
            }
            return listMachines;
        }
    }
}
