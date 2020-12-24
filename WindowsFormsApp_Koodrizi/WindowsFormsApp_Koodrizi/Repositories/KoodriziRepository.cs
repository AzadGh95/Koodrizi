using EntityFramework.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp_Koodrizi.Models;

namespace WindowsFormsApp_Koodrizi.Repositories
{
    public class KoodriziRepository
    {
        readonly private DataBaseContext.DataBaseContext _baseContext;
        public KoodriziRepository()
        {
            _baseContext = new DataBaseContext.DataBaseContext();
        }
        public bool Insert(Models.Koodrizi koodrizi)
        {
            try
            {
                _baseContext.Koodrizis.Add(koodrizi);
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
                _baseContext.Koodrizis.Where(i => i.BarId == id).Delete();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool Update(Models.Koodrizi koodrizi, int id)
        {
            try
            {
                _baseContext.Koodrizis.Where(i => i.KoodId == id)
                    .Update(x => new Models.Koodrizi
                    {
                    Price = koodrizi.Price,
                    SellDate = koodrizi.SellDate,
                    Weight = koodrizi.Weight,
                    ArrivedDate = koodrizi.ArrivedDate,
                    BarId = koodrizi.BarId,
                    
                    });
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public Models.Koodrizi Koodrizi(int id)
        {
            try
            {
                return _baseContext.Koodrizis.Where(i => i.KoodId == id).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        public List<Models.Koodrizi> Koodrizis()
        {
            try
            {
                return _baseContext.Koodrizis.AsNoTracking().ToList();
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

    }
}
