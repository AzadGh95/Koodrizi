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
        public bool Insert(Models.FinalKoodriziModel finalKoodrizi)
        {
            try
            {
                _baseContext.FinalKoodriziModels.Add(finalKoodrizi);
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
                _baseContext.FinalKoodriziModels.Where(i => i.FinalKoodId == id).Delete();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool Update(Models.FinalKoodriziModel finalKoodrizi, int id)
        {
            try
            {
                _baseContext.FinalKoodriziModels.Where(i => i.FinalKoodId == id)
                    .Update(x => new FinalKoodriziModel
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

        public Models.FinalKoodriziModel FinalKoodrizi(int id)
        {
            try
            {
                return _baseContext.FinalKoodriziModels.Where(i => i.FinalKoodId == id).FirstOrDefault();
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
                var f = _baseContext.FinalKoodriziModels.Count();
                return f;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public List<Models.FinalKoodriziModel> FinalKoodrizis()
        {
            try
            {
                return _baseContext.FinalKoodriziModels.AsNoTracking().ToList();
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        public Models.FinalKoodriziModel FinalKoodrizi(string search)
        {
            try
            {
                return _baseContext.FinalKoodriziModels.Where(i => i.KoodNumber == search).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

    }
}
