﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_Planner.Repos
{
    public interface IRepository<T> : IDisposable
        where T : class
    {
        IEnumerable<T> GetCollection(); // получение всех объектов
        T GetByIndex(int id); // получение одного объекта по id
        bool Create(T item); // создание объекта
        bool Update(T item); // обновление объекта
        void Delete(int id); // удаление объекта по id
        void Save();  // сохранение изменений
    }
}
