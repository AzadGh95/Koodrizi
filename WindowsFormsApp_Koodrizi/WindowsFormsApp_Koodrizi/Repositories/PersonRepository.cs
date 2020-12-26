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
        public bool Insert(Person person)
        {
            try
            {
                _baseContext.People.Add(person);
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
                _baseContext.People.Where(i => i.PersonId == id).Delete();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool Update(Person person,int id) {
            try
            {
                _baseContext.People.Where(i => i.PersonId == id).Update(x => new Person {
                    Name = person.Name,
                    AvgDate = person.AvgDate,
                    PhoneNumber = person.PhoneNumber,
                    Total = person.Total,
                });
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public Person People(int id)
        {
            try
            {
                return _baseContext.People.Where(i => i.PersonId == id).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        public List<Person> Peoples()
        {
            try
            {
                return _baseContext.People.AsNoTracking().ToList();
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

    }
}
