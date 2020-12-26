using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Koodrizi.Models
{
    public class FinalKoodrizi
    {
        public FinalKoodrizi()
        {
            KoodNumber = "K-" + DateTime.UtcNow.ToString("dMmss");
        }
        [Key]
        public int FinalKoodId { get; set; }
        public string KoodName { get; set; }
        public string KoodNumber { get; set; }
        public decimal TotalPrice { get; set; }
        public string TotalOunce { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreateDate { get; set; }

        public double TotalWeight { get; set; }
        public double Remining { get; set; }

        public int KoodId { get; set; }
        [ForeignKey("KoodId")]
        public virtual List<Koodrizi> Koodrizi { get; set; }
    }
}
