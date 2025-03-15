using EasyCashIdentityProject.DataAcessLayer.Abstract;
using EasyCashIdentityProject.DataAcessLayer.Concrete.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.DataAcessLayer.Repositories
{
	public class GenericRepository<T> : IGenericDal<T> where T : class
	{
		public void Delete(T entity)
		{
			using var context = new EasyCashIdentityProjectDbContext();
			context.Set<T>().Remove(entity);
			context.SaveChanges();
		}

		public List<T> GetAll()
		{
			using var context = new EasyCashIdentityProjectDbContext();
			var datas= context.Set<T>().ToList();
			return datas;
		}

		public T GetById(int id)
		{
			using var context = new EasyCashIdentityProjectDbContext();
			var data = context.Set<T>().Find(id);
			return data;
		}

		public void Insert(T entity)
		{
			using var context = new EasyCashIdentityProjectDbContext();
            context.Set<T>().Add(entity);
			context.SaveChanges();
		}

		public void Update(T entity)
		{
			using var context = new EasyCashIdentityProjectDbContext();
			context.Set<T>().Update(entity);
			context.SaveChanges();
		}
	}
}
