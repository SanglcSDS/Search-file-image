using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManagement
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
    }
}
