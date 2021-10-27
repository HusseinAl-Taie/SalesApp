using System;
using System.Collections.Generic;


namespace SalesApp.dev_src.Data.Repositories
{

    public interface ICrdRepository<T, U>
    {
        T Create(T t);
        public IList<T> Read();
        public void Delete(U u);
    }
}
