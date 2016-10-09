using System;
using Moq;
using WhatToDo.Database;
using Xunit;

namespace WhatToDo.UnitTests
{
    public class DbTaskLoaderTests
    {
        private Mock<IDatabase> mockDatabase;
        private DbTaskLoader sut;

        public DbTaskLoaderTests()
        {
            this.mockDatabase = new Mock<IDatabase>();
            this.sut = new DbTaskLoader(this.mockDatabase.Object);
        }

        [Fact]
        public void LoadTaskForDay_OnceCallWrite_FromIDatabaseImpl()
        {
            this.sut.LoadTaskForDay(new DateTime());

            this.mockDatabase.Verify(db => db.Load(It.IsAny<DateTime>()), Times.Once());
        }
    }
}