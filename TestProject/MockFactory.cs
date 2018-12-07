using Moq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
   public  class MockFactory
    {
        public static Mock<DbSet<T>> CreateDbSetMock<T>(IEnumerable<T> elements) where T : class
        {
            var elementsAsQueryable = elements.AsQueryable();
            var dbSetMock = new Mock<DbSet<T>>();

            dbSetMock.As<IQueryable<T>>().Setup(m => m.Provider).Returns(elementsAsQueryable.Provider);
            dbSetMock.As<IQueryable<T>>().Setup(m => m.Expression).Returns(elementsAsQueryable.Expression);
            dbSetMock.As<IQueryable<T>>().Setup(m => m.ElementType).Returns(elementsAsQueryable.ElementType);
            dbSetMock.As<IQueryable<T>>().Setup(m => m.GetEnumerator()).Returns(elementsAsQueryable.GetEnumerator());

            return dbSetMock;
        }
        public static Mock<DbSet<T>> CreateMockDbSetWithObjects<T>(IEnumerable<T> mockObjects) where T : class, new()
        {
            Mock<DbSet<T>> mockDbSet = new Mock<DbSet<T>>();
            mockDbSet.SetupGet(m => m.Local).Returns(new ObservableCollection<T>(mockObjects));

            IQueryable<T> mockComponentsAsQueryable = mockObjects.AsQueryable();
            mockDbSet.As<IQueryable<T>>().Setup(m => m.Provider).Returns(mockComponentsAsQueryable.Provider);
            mockDbSet.As<IQueryable<T>>().Setup(m => m.Expression).Returns(mockComponentsAsQueryable.Expression);
            mockDbSet.As<IQueryable<T>>().Setup(m => m.ElementType).Returns(mockComponentsAsQueryable.ElementType);
            mockDbSet.As<IQueryable<T>>().Setup(m => m.GetEnumerator())
                .Returns(mockComponentsAsQueryable.GetEnumerator());

             mockDbSet.SetupGet(m => m.Add(It.IsAny<T>())).Returns(new T());
            return mockDbSet;
        }

    }
}
