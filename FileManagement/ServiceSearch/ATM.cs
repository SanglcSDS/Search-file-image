using FileManagement;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ServiceSearch
{
    public class ATM
    {
        public Socket socketATM;
        TcpListener listener;


        public ATM()
        {
            listener = new TcpListener(IPAddress.Any, Utils.PORT_FORWARD);
            listener.Start();
            socketATM = listener.AcceptSocket();
            socketATM.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, true);
            socketATM.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.SendTimeout, Utils.SEND_DATA_TIMEOUT);
            socketATM.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.DontLinger, true);
            LingerOption lingerOption = new LingerOption(false, 3);
            socketATM.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Linger, lingerOption);
        }
        public bool IsConnected()
        {
            try
            {
                bool check = !(socketATM.Poll(Utils.CHECK_CONNECTION_TIMEOUT, SelectMode.SelectRead) && socketATM.Available == 0);

                return check;
            }
            catch (SocketException)
            {
                return false;
            }
            catch (ObjectDisposedException)
            {
                return false;
            }
        }
        public void ReceiveDataFromATM()
        {
            while (true)
            {
                

                if (this.IsConnected())
                {
                    Byte[] data = Utils.ReceiveAll(socketATM);
                    if (data.Length > 0)
                    {
                        string DataSearch = Encoding.UTF8.GetString(data);
                        ModelMessage modelMessage = JsonConvert.DeserializeObject<ModelMessage>(DataSearch);
                        if (modelMessage.Status.Equals("Search"))
                        {
                            if (Directory.Exists(Utils.CAM1 + modelMessage.modelParameter.TransactionDate))
                            {
                               /* Thread th_one = new Thread(() =>
                                {



                                });
                               th_one.Start();
                               th_one.Join();*/

                                ModelMessage listModelInfoImage =  Utils.GetMatchingImages(Utils.CAM1 + modelMessage.modelParameter.TransactionDate, modelMessage.modelParameter, socketATM);

                                 socketATM.Send(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(listModelInfoImage)));

                            }
                            else
                            {
                             

                                socketATM.Send(Encoding.UTF8.GetBytes(Utils.fomartjson("END", "không tìm thấy ngày giao dịch", "", "", "", null,null)));

                            }
                        }
                        else if (modelMessage.Status.Equals("END"))
                        {


                        }
                        else if (modelMessage.Status.Equals("COPY"))
                        {


                            socketATM.SendFile(modelMessage.Url);
                        }
                        else
                        {


                        }



                    }
                }
                else
                {
                    Close();
                    listener = new TcpListener(IPAddress.Any, Utils.PORT_FORWARD);
                    listener.Start();
                    socketATM = listener.AcceptSocket();
                    socketATM.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, true);
                    socketATM.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.SendTimeout, Utils.SEND_DATA_TIMEOUT);
                    socketATM.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.DontLinger, true);
                    LingerOption lingerOption = new LingerOption(false, 3);
                    socketATM.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Linger, lingerOption);

                }

            }
        }

        public void Close()
        {
            if (socketATM.Connected)
                this.socketATM.Close();
            this.listener.Stop();
        }

        public void Terminate()
        {
            if (socketATM.Connected)
                this.socketATM.Close();
        }
    }
}
