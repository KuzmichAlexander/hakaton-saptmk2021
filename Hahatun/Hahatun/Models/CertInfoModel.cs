using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hahatun.Models
{
    public class CertInfoModel
    {
        public long certnumber { get; set; }
        public string certdate { get; set; }
        public int manufacturercode { get; set; }
        public string companycode { get; set; }
        public long checkcode { get; set; }

        public string productname { get; set; }
        public int status { get; set; }
        public string certurl { get; set; }

    }
}
