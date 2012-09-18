using System;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TileXmlHelper;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            foreach (CultureInfo ci in CultureInfo.GetCultures(CultureTypes.AllCultures))
            {
                Console.WriteLine(new TileXml().GetTileXmlString(ci.Name));
            }

        }
    }
}
