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
        public bool Insert(Models.Bar bar)
        {
            try
            {
                _baseContext.Bars.Add(bar);
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
                _baseContext.Bars.Where(i => i.BarId == id).Delete();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool Update(Models.Bar bar, int id)
        {
            try
            {
                _baseContext.Bars.Where(i => i.BarId == id)
                    .Update(x => new Models.Bar { });
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public Models.Bar Bar(int id)
        {
            try
            {
                return _baseContext.Bars.Where(i => i.BarId == id).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        public List<Models.Bar> Bars()
        {
            try
            {
                return _baseContext.Bars.AsNoTracking().ToList();
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

    }
}
