using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Koodrizi.Models
{
    public class AvgPersonModel
    {
        public AvgPersonModel()
        {
            CreatDate = DateTime.UtcNow;
        }

        [Key]
        public int Id { get; set; }
        //public int IdPerson { get; set; }
        //[ForeignKey("IdPerson")]
        //public virtual Person Person { get; set; }
        //public virtual List<DKood> DetailKoodrizis { get; set; }
        public decimal Bedehi { get; set; }
        public DateTime AvgDate { get; set; }
        public DateTime CreatDate { get; set; }
        //public List<int> IdDetailKood { get; set; }
        //public int IdDetailKoodrizi { get; set; }
        //[ForeignKey("IdDetailKood")]
        //public virtual DKood DKood { get; set; }
    }
}
