using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.DataAcessLayer.Abstract
{
	public interface IGenericDal<T> where T : class
	{
		void Insert(T entity);
		void Update(T entity);
		void Delete(T entity);
		void GetById (int id);
		List<T> GetAll();
	}
}
