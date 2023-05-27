using ClassLibrary1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Repository
{
    public class RepositoryBase<T> where T : class
    {
        BankAccountTypeContext context;
        DbSet<T> set;
        public RepositoryBase()
        {
            context = new BankAccountTypeContext();
            set = context.Set<T>();
        }
        

        public List<T> getAll()
        {
            return set.ToList();
        }

        public bool Create(T entity)
        {
            try
            {
                set.Add(entity);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(T entity)
        {
            try {
                set.Remove(entity);
                context.SaveChanges();
                return true;
            } catch
            {
                return false;
            }
        }

        public void Update(T entity)
        {
            var tracker = context.Attach(entity);
            tracker.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
