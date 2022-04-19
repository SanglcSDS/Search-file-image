using System;
using System.Collections.Generic;

using System.Text;

namespace FileManagement
{
    public class ModelMessage
    {
        public string Status { get; set; }
        public string Messege { get; set; }
        public ModelParameter modelParameter { get; set; }
        public List< ModelInfoImage> modelInfoImage { get; set; }
        public List<string> Url { get; set; }
    }
}
