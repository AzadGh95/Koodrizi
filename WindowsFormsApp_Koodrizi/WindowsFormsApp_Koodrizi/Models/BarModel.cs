﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Koodrizi.Models
{
    /// <summary>
    /// لیست بار های مشتریان
    /// </summary>
    public class BarModel
    {
        public BarModel()
        {
            CreateDate = DateTime.UtcNow;
        }
        [Key]
        public int BarId { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime CreateDate { get; set; }
        public double TotalWeight { get; set; }
        public double Remaining { get; set; }
        public double Ounce { get; set; }

        [DefaultValue(false)]
        public bool IsLock { get; set; }
        public int IdPerson { get; set; }
        [ForeignKey("IdPerson")]
        public virtual PersonModel Person { get; set; }

        public double Adl {get;set;}
        public double AdlRem {get;set;}
        /// <summary>
        /// درصد دهن بست
        /// </summary>
        // public double DahanBast {get;set;}
        [DefaultValue(100)]
        public double DhanBast {get;set;}
        public string PistachioName { get; set; }
        /// <summary>
        /// true:خندان
        /// false:دهن بست
        /// </summary>
        public bool PistachioType { get; set; }
        public double Gram { get; set; }

    }
}
