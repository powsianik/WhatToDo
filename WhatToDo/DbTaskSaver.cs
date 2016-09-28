using System;
using WhatToDo.Database;

namespace WhatToDo
{
    public class DbTaskSaver
    {
        private IDatabase database;
        private ILogger logger;

        public DbTaskSaver(IDatabase database, ILogger logger)
        {
            this.database = database;
            this.logger = logger;
        }

        public void SaveTask(Task taskToSave)
        {
            try
            {
                this.database.Write(taskToSave);
            }
            catch (Exception ex)
            {
                
                this.logger.LogException(ex.Message);
            }
            
        }
    }
}

