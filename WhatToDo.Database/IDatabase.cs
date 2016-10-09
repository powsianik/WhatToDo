using System.Collections.Generic;

namespace WhatToDo.Database
{
    public interface IDatabase
    {
        void Write(object entity);
        object Load(params object[] param);
    }
}