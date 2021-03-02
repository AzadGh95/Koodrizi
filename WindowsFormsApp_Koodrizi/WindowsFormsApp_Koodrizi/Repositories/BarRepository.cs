using EntityFramework.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp_Koodrizi.Models;

namespace WindowsFormsApp_Koodrizi.Repositories
{
    public class BarRepository
    {
        readonly private DataBaseContext.DataBaseContext _baseContext;
        public BarRepository()
        {
            _baseContext = new DataBaseContext.DataBaseContext();
        }
        public bool Insert(Models.BarModel bar)
        {
            try
            {
                _baseContext.BarModels.Add(bar);
                _baseContext.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                _baseContext.BarModels.Where(i => i.BarId == id).Delete();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool Update(Models.BarModel bar, int id)
        {
            try
            {
                _baseContext.BarModels.Where(i => i.BarId == id)
                    .Update(x => new Models.BarModel
                    {
                        Adl = bar.Adl,
                        AdlRem = bar.AdlRem,
                        DhanBast = bar.DhanBast,
                        Gram = bar.Gram,
                        IdPerson = bar.IdPerson,
                        TotalWeight = bar.TotalWeight,
                        IsLock = bar.IsLock,
                        Ounce = bar.Ounce,
                        PistachioName = bar.PistachioName,
                        PistachioType = bar.PistachioType,
                        Remaining = bar.Remaining
                    });
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public Models.BarModel Bar(int id)
        {
            try
            {
                return _baseContext.BarModels.Where(i => i.BarId == id).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        public List<Models.BarModel> Bars()
        {
            try
            {
                return _baseContext.BarModels.AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                return null;
                throw;
            }
        }
        public List<BarModel> SearchBar(double weight1,
            double weight2, double ounce1, double ounce2,
            double adl1, double adl2, double gram1, double gram2,
             double dahanbast1, double dahanbast2, string code)
        {
            var bars =
            _baseContext.BarModels
                .Where(x => x.IsLock == false)
                .Where(x => x.Remaining != 0)
                .Where(x => weight2 == 0 || (x.Remaining >= weight1 && x.Remaining <= weight2))
                .Where(x => ounce2 == 0 || (x.Ounce >= ounce1 && x.Ounce <= ounce2))
                .Where(x => gram2 == 0 || (x.Gram >= gram1 && x.Gram <= gram2))
                .Where(x => adl2 == 0 || (x.AdlRem >= adl1 && x.AdlRem <= adl2))
                .Where(x => dahanbast2 == 0 || (x.DhanBast >= dahanbast1 && x.DhanBast <= dahanbast2))
                .Where(x => code == "" || x.Person.Code == code)
                .ToList();
            return bars;
        }
    }
}
