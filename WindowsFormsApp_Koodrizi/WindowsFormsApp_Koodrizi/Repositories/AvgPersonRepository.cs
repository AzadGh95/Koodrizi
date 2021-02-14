using EntityFramework.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Koodrizi.Repositories
{
    public class AvgPersonRepository
    {
        readonly private DataBaseContext.DataBaseContext _baseContext;
        public AvgPersonRepository()
        {
            _baseContext = new DataBaseContext.DataBaseContext();
        }

        public bool Insert(Models.AvgPersonModel avgModel)
        {
            try
            {
                _baseContext.AvgPersonModels.Add(avgModel);
                _baseContext.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //public Models.AvgPersonModel AvgPersonModel(int id)
        //{
        //    try
        //    {
        //        return _baseContext.AvgPersonModels.Where(i => i.Id == id).FirstOrDefault();
        //    }
        //    catch (Exception)
        //    {
        //        return null;
        //        throw;
        //    }
        //}

        public List<Models.AvgPersonModel> AvgPersonModels(int personId)
        {
            try
            {
                return _baseContext.AvgPersonModels.Where(i => i.Id == personId).ToList();
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
        public List<Models.AvgPersonModel> AvgPersonModels()
        {
            try
            {
                return _baseContext.AvgPersonModels.ToList();
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        public bool DeleteAvgPerson(int avgId)
        {
            try
            {
                _baseContext.AvgPersonModels.Where(x => x.Id == avgId).Delete();

                _baseContext.DKoods.Where(i => i.AvgId == avgId)
               .Update(x => new Models.DKood
               {
                   AvgId = 0
               });
                return true;

            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }
    }
}
