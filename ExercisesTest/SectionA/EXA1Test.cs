using System;
using System.CodeDom;
using System.Diagnostics;
using System.IO;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class ExA1Test
    {
        [TestMethod]
        public void ExA1_TestWithAName()
        {
            TestHelper help = new TestHelper();
            ExA1.Main(null);
            help.AssertOutputContains(ExA1.myName);
            help.AssertOutputContains(ExA1.myEmail);
        }
    }
}
