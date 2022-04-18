using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
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
    }
}
