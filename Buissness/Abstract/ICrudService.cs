﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buissness.Abstract
{
    public interface ICrudService<T>
    {
        void Add(T t);
        void Update(T t);
        void Delete(T t);
        void Get(T t);
    }
}
