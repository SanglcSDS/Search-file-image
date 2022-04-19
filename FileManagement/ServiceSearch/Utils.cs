using FileManagement;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace ServiceSearch
{
    public class Utils
    {
        public static int CHECK_CONNECTION_TIMEOUT = Int32.Parse(ConfigurationManager.AppSettings["check_connection_timeout"]);
        public static int PORT_FORWARD = Int32.Parse(ConfigurationManager.AppSettings["port_listen"]);
        public static int SEND_DATA_TIMEOUT = Int32.Parse(ConfigurationManager.AppSettings["send_data_timeout"]);
        public static string CAM1 = ConfigurationManager.AppSettings["cam1"];
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
        public static List<ModelInfoImage> GetMatchingImages(string path, ModelParameter modelParameter, Socket socketATM)
        {
            var matches = new List<ModelInfoImage>();

            var images = System.IO.Directory.GetFiles(path);

            foreach (var image in images)
            {
                if (image.Contains(".jpg"))
                {
                    if (image.Contains(modelParameter.CardNumber) || image.Contains(modelParameter.TransNo))

                    {
                        FileInfo info = new FileInfo(image);
                        ModelInfoImage imtem = new ModelInfoImage
                        {
                            Name = info.Name,
                            Url = info.FullName,
                            size = Math.Ceiling(info.Length / 1024f).ToString("0 KB")

                        };

                     //   socketATM.Send(Encoding.ASCII.GetBytes(image));
                       // socketATM.Send(Encoding.ASCII.GetBytes(Utils.fomartjson("DATA", "", "", "", "", null, imtem)));
                        matches.Add(imtem);

                    }
                }
            }

            return matches;
        }

        public static string fomartjson(string Status, string Messege, string TransNo, string CardNumber, string TransactionDate, List<string> Url, List<ModelInfoImage> modelInfoImage)
        {
            ModelMessage parameter = new ModelMessage
            {
                Status = Status,
                Messege = Messege,
                modelInfoImage = modelInfoImage,
                Url = Url,
                modelParameter = new ModelParameter
                {
                    CardNumber = CardNumber,
                    TransNo = TransNo,
                    TransactionDate = TransactionDate,
                }

            };
            return JsonConvert.SerializeObject(parameter);
            ;
        }

    }
}
