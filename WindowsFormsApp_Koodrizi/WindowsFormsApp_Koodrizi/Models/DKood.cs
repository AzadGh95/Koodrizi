using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Koodrizi.Models
{
    public class DKood
    {
        public DKood()
        {
            CreateDate = DateTime.UtcNow;
        }

        [Key]
        public int DId { get; set; }


        public decimal Price { get; set; }
        public double Weight { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime SellDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime ArrivedDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreateDate { get; set; }
        public double PercentRoyat { get; set; }

        public int BarId { get; set; }
        [ForeignKey("BarId")]
        public virtual BarModel Bar { get; set; }

        public int FinalKoodId { get; set; }
        [ForeignKey("FinalKoodId")]
        public virtual FinalKoodriziModel FinalKoodrizi { get; set; }

        public double Zarib { get; set; }
        public double BaseOunce { get; set; }
        public double BaseDahanBast { get; set; }
        public double BasePercentRoyat { get; set; }
        public string extra { get; set; }
        public double Adl { get; set; }

        public int AvgPersonId {get;set;}
        [ForeignKey("AvgPersonId")]
        public AvgPersonModel AvgPersonModel {get;set;}

    }
}
