using System;
using QBMS.Core.Domain;
using NUnit.Framework;

namespace QBMS.Core.Tests.Domain
{
    [TestFixture]
    public class TestEntityBase
    {
        [Test]
        public void Construct()
        {
            Assert.DoesNotThrow(() => new EntityBaseImpl());
        }

        [Test]
        public void IsNew_GivenIdIsSet_ShouldReturnFalse()
        {
            //---------------Set up test pack-------------------
            var entityBaseImpl = new EntityBaseImpl();
            entityBaseImpl.Id = Guid.NewGuid();
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var isNew = entityBaseImpl.IsNew();
            //---------------Test Result -----------------------
            Assert.IsFalse(isNew);
        }

        [Test]
        public void IsNew_GivenIdIsEmpty_ShouldThrow()
        {
            //---------------Set up test pack-------------------
            var entityBaseImpl = new EntityBaseImpl();
            entityBaseImpl.Id = Guid.Empty;
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var ex = Assert.Throws<InvalidOperationException>(() => entityBaseImpl.IsNew());
            //---------------Test Result -----------------------
            Assert.AreEqual("Id cannot be empty guid", ex.Message);
        }

        public class EntityBaseImpl : EntityBase
        {

        }
    }
}