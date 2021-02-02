using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp_Koodrizi.Models;

namespace WindowsFormsApp_Koodrizi.DataBaseContext
{
    public class DataBaseContext : System.Data.Entity.DbContext
    {
        public DataBaseContext() : base("KoodContext")
        {
        }
        static DataBaseContext()
        {
            System.Data.Entity.Database.SetInitializer(
            new System.Data.Entity.DropCreateDatabaseIfModelChanges<DataBaseContext>());
        }
        public DbSet<PersonModel> PersonModels { get; set; }

        public DbSet<Models.BarModel> BarModels { get; set; }
        public DbSet<Models.DKood> DKoods { get; set; }
        public DbSet<Models.FinalKoodriziModel> FinalKoodriziModels { get; set; }


    }
}
