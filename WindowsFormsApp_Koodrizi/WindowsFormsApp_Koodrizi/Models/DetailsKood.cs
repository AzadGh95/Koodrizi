﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Koodrizi.Models
{
    /// <summary>
    /// Delete
    /// </summary>
    public class DetailsKood
    {
        public DetailsKood()
        {
            CreateDate = DateTime.UtcNow;
        }

        [Key]
        public int DetailId { get; set; }
        public int KoodId { get; set; }
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
        public virtual Bar Bar { get; set; }

        public int FinalKoodId { get; set; }
        [ForeignKey("FinalKoodId")]
        public virtual FinalKoodrizi FinalKoodrizi { get; set; }

        public double zarib { get; set; }
        public double baseOunce { get; set; }
        public double baseDahanBast { get; set; }
        public double basePercentRoyat { get; set; }
        public double Adl { get; set; }

    }
}
