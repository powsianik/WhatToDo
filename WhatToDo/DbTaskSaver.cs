using WhatToDo.Database;

namespace WhatToDo
{
    public class DbTaskSaver
    {
        private IDatabase database;

        public DbTaskSaver(IDatabase database)
        {
            this.database = database;
        }

        public void SaveTask(Task taskToSave)
        {
            this.database.Write(taskToSave);
        }
    }
}

