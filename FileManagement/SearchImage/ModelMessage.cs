using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagement
{
    public class ModelMessage
    {
        public string Status { get; set; }
        public string Messege { get; set; }
        public int TotalFiles { get; set; }
        public ModelParameter modelParameter { get; set; }
        public List<ModelInfoImage> modelInfoImage { get; set; }
        public string Url { get; set; }
    }
}
