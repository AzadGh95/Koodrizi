using EntityFramework.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp_Koodrizi.Models;

namespace WindowsFormsApp_Koodrizi.Repositories
{
    public class PersonRepository
    {
        readonly private DataBaseContext.DataBaseContext _baseContext;
        public PersonRepository()
        {
            _baseContext = new DataBaseContext.DataBaseContext();
        }
        public bool Insert(PersonModel person)
        {
            try
            {
                _baseContext.PersonModels.Add(person);
                _baseContext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                var error = e.Message;
                throw;
            }
           
        
        }

        public bool Delete(int id)
        {
            try
            {
                _baseContext.PersonModels.Where(i => i.PersonId == id).Delete();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool Update(PersonModel person,int id) {
            try
            {
                _baseContext.PersonModels.Where(i => i.PersonId == id)
                    .Update(x => new PersonModel {
                    Name = person.Name,
                    AvgDate = person.AvgDate,
                    BaseDate = person.BaseDate,
                    Bedehi = person.Bedehi,
                    Code = person.Code,
                    PhoneNumber = person.PhoneNumber,
                    Total = person.Total,
                });
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public PersonModel People(int id)
        {
            try
            {
                return _baseContext.PersonModels.Where(i => i.PersonId == id).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        public int People(string code)
        {
            try
            {
                return _baseContext.PersonModels.Where(i => i.Code == code).FirstOrDefault().PersonId;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<PersonModel> Peoples()
        {
            try
            {
                return _baseContext.PersonModels.AsNoTracking().ToList();
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

    }
}
