using System;
using System.Collections;
using System.Collections.Generic;
using WhatToDo.Database;

namespace WhatToDo
{
    public class DbTaskLoader
    {
        private IDatabase database;
        private ILogger logger;

        public DbTaskLoader(IDatabase database)
        {
            this.database = database;
        }

        public IEnumerable<Task> LoadTaskForDay(DateTime dateTime)
        {
            return (IEnumerable<Task>)this.database.Load(dateTime);
        }
    }
}