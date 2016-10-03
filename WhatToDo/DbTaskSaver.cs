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
            if (taskToSave.Date > DateTime.Today + new TimeSpan(29, 0, 0, 0))
            {
                this.logger.LogException("Próba zapisania zadania na zbyt odległą datę.");
                return;
            }

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

