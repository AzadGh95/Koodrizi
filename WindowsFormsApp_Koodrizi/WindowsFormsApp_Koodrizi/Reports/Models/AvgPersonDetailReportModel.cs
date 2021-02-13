using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Koodrizi.Reports.Models
{
    public class AvgPersonDetailReportModel
    {
        public string KoodNumber { get; set; }
        public string KoodName { get; set; }
        public string ArrivedDate { get; set; }
        public double Weight { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
        
    }
}
