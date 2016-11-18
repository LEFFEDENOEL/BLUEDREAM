using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using METIERForadev;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace TestsUnitairesForadev
{
    [TestClass]
    public class UnitTestBLLMain
    {             
        [TestMethod]
        public void TestMethodValidRegex()
        {
            //Assert.IsTrue(BLLForadev.BLLTools.ValidRegex("BONJOURbonjour1@"));
            //Assert.IsTrue(BLLForadev.BLLTools.ValidRegex("BONJOURbonjour1!"));
            //Assert.IsTrue(BLLForadev.BLLMain.ValidRegex("BONJOURbonjour1#"));
            //Assert.IsTrue(BLLForadev.BLLMain.ValidRegex("BONJOURbonjour9&"));
            //Assert.IsTrue(BLLForadev.BLLMain.ValidRegex("BONJOURbon9@"));
            //Assert.IsFalse(BLLForadev.BLLMain.ValidRegex("BONJOURbo1@"));
            //Assert.IsFalse(BLLForadev.BLLMain.ValidRegex("BONJOURBONJOUR1@"));
            //Assert.IsFalse(BLLForadev.BLLMain.ValidRegex("bonjourbonjour1@"));
            //Assert.IsFalse(BLLForadev.BLLMain.ValidRegex("BONJOURbonjour@"));
            //Assert.IsFalse(BLLForadev.BLLMain.ValidRegex("BONJOURbonjour1+"));
            //Assert.IsFalse(BLLForadev.BLLMain.ValidRegex("BONJOURbonjour1"));
            //Assert.IsFalse(BLLForadev.BLLMain.ValidRegex("BONJOURbonjour"));
            //Assert.IsFalse(BLLForadev.BLLMain.ValidRegex("BONJOURBONJOUR"));
            //Assert.IsFalse(BLLForadev.BLLMain.ValidRegex(""));
        }
    }
}

//Assert.IsTrue(BLLForadev.BLLMain.ValidRegex("BONJOUR"));