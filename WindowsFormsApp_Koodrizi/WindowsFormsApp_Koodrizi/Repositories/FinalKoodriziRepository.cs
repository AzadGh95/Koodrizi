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
        public bool Insert(FinalKoodrizi finalKoodrizi)
        {
            try
            {
                _baseContext.FinalKoodrizis.Add(finalKoodrizi);
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

        public bool Update(FinalKoodrizi finalKoodrizi, int id)
        {
            try
            {
                _baseContext.FinalKoodrizis.Where(i => i.FinalKoodId == id)
                    .Update(x => new FinalKoodrizi
                    {
                        KoodId = finalKoodrizi.FinalKoodId,
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

        public FinalKoodrizi FinalKoodrizi(int id)
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

        public List<FinalKoodrizi> FinalKoodrizis()
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

    }
}
