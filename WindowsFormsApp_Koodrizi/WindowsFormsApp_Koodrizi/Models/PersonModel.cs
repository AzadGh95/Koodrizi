using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsFormsApp_Koodrizi.Models
{
    public class PersonModel
    {
        public PersonModel()
        {
            CreateDate = DateTime.UtcNow;
            AvgDate = DateTime.UtcNow;
            BaseDate = DateTime.UtcNow;
        }
        [Key]
        public int PersonId { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [Column(TypeName = "Nvarchar")]
        [StringLength(300)]
        public string Name { get; set; }

        [StringLength(50)]
        public string PhoneNumber { get; set; }

        public decimal Total { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime AvgDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime BaseDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreateDate { get; set; }
        public decimal Bedehi { get; set; }
    }
}
