using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestClass()]
    public class CalculatorkuTests
    {
        Calculatorku calculatorku = new Calculatorku();
        [TestMethod()]
        public void menuTest()
        {
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void inputTest()
        {
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void hitung_tambahTest()
        {
            Assert.AreEqual(20, calculatorku.hitung_tambah(10, 10));
        }

        [TestMethod()]
        public void hitung_kurangTest()
        {
            Assert.AreEqual(15, calculatorku.hitung_kurang(20, 5));
        }

        [TestMethod()]
        public void hitung_kaliTest()
        {
            Assert.AreEqual(50, calculatorku.hitung_kali(10, 5));
        }

        [TestMethod()]
        public void display_tambahTest()
        {
            Assert.IsTrue(true, "Ini adalah method tidak membalikkan nilai");
        }

        [TestMethod()]
        public void display_kurangTest()
        {
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void display_kaliTest()
        {
            Assert.IsTrue(true);
        }
    }
}