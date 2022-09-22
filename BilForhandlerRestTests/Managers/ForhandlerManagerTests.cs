using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilForhandlerRest.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilModelLib.model;

namespace BilForhandlerRest.Managers.Tests
{
    [TestClass()]
    public class ForhandlerManagerTests
    {
        private IForhandlerManager mgr; 

        [TestInitialize]
        public void BeforeEachTest()
        {
            mgr = new ForhandlerManager();

        }


        [TestMethod()]
        public void CreateTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ReadTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        [DataRow(null)]
        [DataRow("")]
        [DataRow("         ")]
        public void ReadNavn1(String? navn)
        {
            // arrange
            // tom

            // act
            List <Forhandler> result = mgr.Read(navn);

            //assert
            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod()]
        [DataRow("peter")]
        [DataRow("PeTer")]
        public void ReadNavn2(String navn)
        {
            // arrange
            // tom

            // act
            List<Forhandler> result = mgr.Read(navn);

            //assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count);
        }

        [TestMethod()]
        [DataRow("Martin")]
        public void ReadNavn3(String navn)
        {
            // arrange
            // tom

            // act
            List<Forhandler> result = mgr.Read(navn);

            //assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count);
        }

        [TestMethod()]
        public void UpdateTest()
        {
            Assert.Fail();
        }
    }
}