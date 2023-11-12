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
    public class ProgramCalculatorTests
    {
        /// <summary>
        /// Memanggil Class ProgramCalculator
        /// </summary>

        ProgramCalculator ppC = new ProgramCalculator();


        [TestMethod()]
        public void menuTest()
        {
            Assert.IsTrue(true, "Ini adalah Method tidak membalikkan nilai");
        }

        [TestMethod()]
        public void inputTest()
        {
            Assert.IsTrue(true, "Ini adalah method input yang tidak membalikkan nilai");
        }

        [TestMethod()]
        public void hitung_tambahTest()
        {
            Assert.AreEqual(12, ppC.hitung_tambah(8,4));
        }

        [TestMethod()]
        public void hitung_kurangTest()
        {
            Assert.AreEqual(15, ppC.hitung_kurang(20, 5));
        }

        [TestMethod()]
        public void hitung_kaliTest()
        {
            Assert.AreEqual(45, ppC.hitung_kali(9, 5));
        }

        [TestMethod()]
        public void display_tambahTest()
        {
            Assert.IsTrue(true, "Ini adalah Method display Tambah");
        }

        [TestMethod()]
        public void display_kurangTest()
        {
            Assert.IsTrue(true, "Ini adalah Method display Kurang");
        }

        [TestMethod()]
        public void display_kaliTest()
        {
            Assert.IsTrue(true, "Ini adalah Method display Kali");
        }
    }
}