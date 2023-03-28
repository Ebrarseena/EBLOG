﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class // T burada entity'nin karşılığı olan değer olacak
    {
        void Insert (T t);
        void Delete (T t);  
        void Update (T t);  
        List<T> GetAll ();
        T GetById(int id);
    }
}
