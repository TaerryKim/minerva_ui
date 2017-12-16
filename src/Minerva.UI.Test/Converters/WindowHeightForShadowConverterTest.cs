using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Windows;
using Minerva.UI.Converters;

namespace Minerva.UI.Test.Converters
{
    [TestClass]
    public class WindowHeightForShadowConverterTest
    {
        [TestCategory("Minerva.UI.Converters.WindowHeightForShadowConverter")]
        [TestMethod]
        public void Invalid_target_type()
        {
            var converter = new WindowHeightForShadowConverter();

            Assert.ThrowsException<InvalidOperationException>(() =>
                converter.Convert(new object[] { (double)100.0, new Thickness(5)}, typeof(string), null, null));

            Assert.ThrowsException<InvalidOperationException>(() =>
                converter.Convert(new object[] { (double)100.0, new Thickness(5) }, typeof(bool), null, null));
        }

        [TestCategory("Minerva.UI.Converters.WindowHeightForShadowConverter")]
        [TestMethod]
        public void Invalid_first_value()
        {
            var converter = new WindowHeightForShadowConverter();

            Assert.ThrowsException<InvalidOperationException>(() =>
                converter.Convert(new object[] { true, new Thickness(5) }, typeof(double), null, null));

            Assert.ThrowsException<InvalidOperationException>(() =>
                converter.Convert(new object[] { "Hello", new Thickness(5) }, typeof(double), null, null));
        }

        [TestCategory("Minerva.UI.Converters.WindowHeightForShadowConverter")]
        [TestMethod]
        public void Invalid_second_value()
        {
            var converter = new WindowHeightForShadowConverter();

            Assert.ThrowsException<InvalidOperationException>(() =>
                converter.Convert(new object[] { (double)100.0, 15 }, typeof(double), null, null));

            Assert.ThrowsException<InvalidOperationException>(() =>
                converter.Convert(new object[] { (double)100.0, "Hello" }, typeof(double), null, null));
        }


        [TestCategory("Minerva.UI.Converters.WindowHeightForShadowConverter")]
        [TestMethod]
        public void Invalid_value_and_target_type()
        {
            var converter = new WindowHeightForShadowConverter();

            Assert.ThrowsException<InvalidOperationException>(() =>
                converter.Convert(new object[] { "Hello", 15 }, typeof(double), null, null));
        }

        [TestCategory("Minerva.UI.Converters.WindowHeightForShadowConverter")]
        [TestMethod]
        public void Change_appropriate_radius_for_titlebar()
        {
            var converter = new WindowHeightForShadowConverter();

            var res = converter.Convert(new object[] { (double)100, new Thickness(5) }, typeof(double), null, null);
            Assert.AreEqual(typeof(double), res.GetType());
            Assert.AreEqual(110, (double)res);
        }

        [TestCategory("Minerva.UI.Converters.WindowHeightForShadowConverter")]
        [TestMethod]
        public void Change_appropriate_radius_for_titlebar_from_irregular_input()
        {
            var converter = new WindowHeightForShadowConverter();

            var res = converter.Convert(new object[] { (double)100.0, new Thickness(5,2,3,1) }, typeof(double), null, null);
            Assert.AreEqual(typeof(double), res.GetType());
            Assert.AreEqual(103, (double)res);
        }
    }
}
