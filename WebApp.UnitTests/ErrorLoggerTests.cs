using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Services;

namespace WebApp.UnitTests
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        //Testing a void method
        [Test]
        public void Log_WhenCalled_SetTheLastErrorProperty()
        {
            var logger = new ErrorLogger();

            logger.Log("a");

            Assert.That(logger.LastError, Is.EqualTo("a"));
        }

        //Testing method that throws an exception
        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ThrowArguementNullException(string error)
        {
            var logger = new ErrorLogger();

            Assert.That(() => logger.Log(error), Throws.ArgumentNullException);
        }

        //Testing method that raises an event
        [Test]
        public void Log_ValidError_RaiseErrorLoggedEvent()
        {
            //arrenge 
            var logger = new ErrorLogger();

            //subscribe to the event
            var id = Guid.Empty;
            logger.ErrorLogged += (sender, args) => { id = args; };

            //act
            logger.Log("a");

            //assert
            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }

        //Testing proteted and private methods
        //Do not test them as they are only iplementation details
    }
}
