using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.Abstract
{
	public interface IGenericService<T> where T : class
	{
		T GetById(int id);
		List<T> GetAll();
		void Insert(T entity);
		void Update(T entity);
		void Delete(T entity);

	}
}
