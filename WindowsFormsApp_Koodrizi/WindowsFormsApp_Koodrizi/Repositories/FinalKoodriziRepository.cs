using EntityFramework.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp_Koodrizi.Models;

namespace WindowsFormsApp_Koodrizi.Repositories
{
    public class FinalKoodriziRepository
    {
        readonly private DataBaseContext.DataBaseContext _baseContext;
        public FinalKoodriziRepository()
        {
            _baseContext = new DataBaseContext.DataBaseContext();
        }
        public bool Insert(Models.FinalKoodrizi finalKoodrizi)
        {
            try
            {
                _baseContext.FinalKoodrizis.Add(finalKoodrizi);
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
                _baseContext.Koodrizis.Where(i => i.BarId == id).Delete();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool Update(Models.FinalKoodrizi finalKoodrizi, int id)
        {
            try
            {
                _baseContext.FinalKoodrizis.Where(i => i.FinalKoodId == id)
                    .Update(x => new FinalKoodrizi
                    {
                        // FinalKoodId = finalKoodrizi.FinalKoodId,
                        KoodName = finalKoodrizi.KoodName,
                        KoodNumber = finalKoodrizi.KoodNumber,
                        TotalOunce = finalKoodrizi.TotalOunce,
                        TotalPrice = finalKoodrizi.TotalPrice,
                        TotalWeight = finalKoodrizi.TotalWeight,
                    });
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public Models.FinalKoodrizi FinalKoodrizi(int id)
        {
            try
            {
                return _baseContext.FinalKoodrizis.Where(i => i.FinalKoodId == id).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
        public int LastIdFinalKoodrizi()
        {
            try
            {
                var f = _baseContext.FinalKoodrizis.Count();
                return f;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public List<Models.FinalKoodrizi> FinalKoodrizis()
        {
            try
            {
                return _baseContext.FinalKoodrizis.AsNoTracking().ToList();
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        public Models.FinalKoodrizi FinalKoodrizi(string search)
        {
            try
            {
                return _baseContext.FinalKoodrizis.Where(i => i.KoodNumber == search).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

    }
}
