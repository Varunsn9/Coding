using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RestSharp.Generic.Main
{
    [TestClass]
    public class BaseClass
    {
        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext context)
        {
            MessageBox.Show("AssemblyInitialize");           
        }
        [TestMethod]
        public void TestMethod1()
        {
            MessageBox.Show("Test Method");
        }
        [AssemblyCleanup]
        public void AssemblyCleanup()
        {
            MessageBox.Show("AssemblyCleanup");
        }
    }
    
}
