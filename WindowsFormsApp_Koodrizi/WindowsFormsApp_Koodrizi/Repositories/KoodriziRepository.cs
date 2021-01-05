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
        public bool Insert(Models.DKood koodrizi)
        {
            try
            {
               // koodrizi.DId=_baseContext.DKoods.Count() + 1;
                _baseContext.DKoods.Add(koodrizi);
                _baseContext.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                _baseContext.DKoods.Where(i => i.BarId == id).Delete();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool Update(Models.DKood koodrizi, int id)
        {
            try
            {
                _baseContext.DKoods.Where(i => i.DId == id)
                    .Update(x => new Models.DKood
                    {
                        Price = koodrizi.Price,
                        SellDate = koodrizi.SellDate,
                        Weight = koodrizi.Weight,
                        ArrivedDate = koodrizi.ArrivedDate,
                        BarId = koodrizi.BarId,
                        FinalKoodId = koodrizi.FinalKoodId,
                        PercentRoyat = koodrizi.PercentRoyat,
                    });
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public Models.DKood Koodrizi(int id)
        {
            try
            {
                return _baseContext.DKoods.Where(i => i.DId == id).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        public List<Models.DKood> Koodrizis()
        {
            try
            {
                return _baseContext.DKoods.AsNoTracking().ToList();
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

    }
}
