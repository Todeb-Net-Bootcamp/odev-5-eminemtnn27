using DataAccessLayer.Abstract;
using DataAccessLayer.DbContexts;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Ef
{
    public class EfReaderRepository : IReaderRepository
    {
        private BookContext context;
        public EfReaderRepository(BookContext context)
        {
            this.context = context;
        }

        public IEnumerable<Reader> GetAll()
        {
            return context.Readers.ToList(); //Reader verilerini listeler
        }

        public void Insert(Reader reader)
        {
            context.Readers.Add(reader); //Reader veri ekler
            context.SaveChanges();
        }

        public void Update(Reader reader)
        {
            context.Readers.Update(reader); //Reader verilerini günceller
            context.SaveChanges();
        }
        public void Delete(Reader reader)
        {

            context.Readers.Remove(reader); //Reader verilerini siler
            context.SaveChanges();
        }

        public Reader Get(int id)
        { 
            return context.Readers.FirstOrDefault(x => x.ReaderId == id);
        }
    }
}
