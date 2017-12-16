using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Windows;
using Minerva.UI.Converters;

namespace Minerva.UI.Test.Converters
{
    [TestClass]
    public class TitleCornerRadiusConverterTest
    {
        [TestCategory("Minerva.UI.Converters.TitleCornerRadiusConverter")]
        [TestMethod]
        public void Invalid_target_type()
        {
            var converter = new TitleCornerRadiusConverter();

            Assert.ThrowsException<InvalidOperationException>(() =>
                converter.Convert(new CornerRadius(15), typeof(string), null, null));

            Assert.ThrowsException<InvalidOperationException>(() =>
                converter.Convert(new CornerRadius(15), typeof(int), null, null));

            Assert.ThrowsException<InvalidOperationException>(() =>
                converter.Convert(new CornerRadius(15), typeof(bool), null, null));
        }

        [TestCategory("Minerva.UI.Converters.TitleCornerRadiusConverter")]
        [TestMethod]
        public void Invalid_value()
        {
            var converter = new TitleCornerRadiusConverter();

            Assert.ThrowsException<InvalidOperationException>(() =>
                converter.Convert(1, typeof(CornerRadius), null, null));

            Assert.ThrowsException<InvalidOperationException>(() =>
                converter.Convert("hello", typeof(CornerRadius), null, null));
        }


        [TestCategory("Minerva.UI.Converters.TitleCornerRadiusConverter")]
        [TestMethod]
        public void Invalid_value_and_target_type()
        {
            var converter = new TitleCornerRadiusConverter();

            Assert.ThrowsException<InvalidOperationException>(() =>
                converter.Convert(1, typeof(string), null, null));
        }

        [TestCategory("Minerva.UI.Converters.TitleCornerRadiusConverter")]
        [TestMethod]
        public void Change_appropriate_radius_for_titlebar()
        {
            var converter = new TitleCornerRadiusConverter();
             
            var res = converter.Convert(new CornerRadius(15), typeof(CornerRadius), null, null);
            Assert.AreEqual(typeof(CornerRadius), res.GetType());
            Assert.AreEqual(new CornerRadius(15, 15, 0, 0), (CornerRadius)res);
        }

        [TestCategory("Minerva.UI.Converters.TitleCornerRadiusConverter")]
        [TestMethod]
        public void Change_appropriate_radius_for_titlebar_from_irregular_input()
        {
            var converter = new TitleCornerRadiusConverter();

            var res = converter.Convert(new CornerRadius(10,12,2,0), typeof(CornerRadius), null, null);
            Assert.AreEqual(typeof(CornerRadius), res.GetType());
            Assert.AreEqual(new CornerRadius(10,12,0,0), (CornerRadius)res);
        }
    }
}
