using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Koodrizi.Reports.Models
{
   public class AvgPersonReportModel
    {
        public int Id { get; set; }
        public string PersonName { get; set; }
        public decimal Bedehi { get; set; }
        public string AvgDate { get; set; }
        public string CreatDate { get; set; }
    }
}
