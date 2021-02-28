using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Koodrizi.Models
{
    /// <summary>
    /// کودریزی نهایی
    /// </summary>
    public class FinalKoodriziModel
    {
        public FinalKoodriziModel()
        {
            CreateDate = DateTime.UtcNow;
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
        public virtual List<DKood> DetailKoodrizis { get; set; }


        public decimal PriceDahanBast { get; set; }
        public decimal PriceOunce { get; set; }
        public decimal BasePrice { get; set; }
    }
}
