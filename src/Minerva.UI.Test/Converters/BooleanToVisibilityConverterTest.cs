using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Windows;
using Minerva.UI.Converters;

namespace Minerva.UI.Test.Converters
{
    [TestClass]
    public class BooleanToVisibilityConverterTest
    {
        [TestCategory("Minerva.UI.Converters.BooleanToVisibilityConverter")]
        [TestMethod]
        public void Invalid_target_type()
        {
            var converter = new BooleanToVisibilityConverter();

            Assert.ThrowsException<InvalidOperationException>(() =>
                converter.Convert(true, typeof(string), null, null));

            Assert.ThrowsException<InvalidOperationException>(() =>
                converter.Convert(true, typeof(int), null, null));

            Assert.ThrowsException<InvalidOperationException>(() =>
                converter.Convert(true, typeof(bool), null, null));
        }

        [TestCategory("Minerva.UI.Converters.BooleanToVisibilityConverter")]
        [TestMethod]
        public void Invalid_value()
        {
            var converter = new BooleanToVisibilityConverter();

            Assert.ThrowsException<InvalidOperationException>(() =>
                converter.Convert(1, typeof(Visibility), null, null));

            Assert.ThrowsException<InvalidOperationException>(() =>
                converter.Convert("hello", typeof(Visibility), null, null));

            Assert.ThrowsException<InvalidOperationException>(() =>
                converter.Convert(Visibility.Visible, typeof(Visibility), null, null));
        }


        [TestCategory("Minerva.UI.Converters.BooleanToVisibilityConverter")]
        [TestMethod]
        public void Invalid_value_and_target_type()
        {
            var converter = new BooleanToVisibilityConverter();

            Assert.ThrowsException<InvalidOperationException>(() =>
                converter.Convert(1, typeof(string), null, null));
        }

        [TestCategory("Minerva.UI.Converters.BooleanToVisibilityConverter")]
        [TestMethod]
        public void Converting_true_to_visible_is_successful()
        {
            var converter = new BooleanToVisibilityConverter();
             
            var res = converter.Convert(true, typeof(Visibility), null, null);
            Assert.AreEqual(typeof(Visibility), res.GetType());
            Assert.AreEqual(Visibility.Visible, (Visibility)res);
        }

        [TestCategory("Minerva.UI.Converters.BooleanToVisibilityConverter")]
        [TestMethod]
        public void Converting_false_to_collapsed_is_successful()
        {
            var converter = new BooleanToVisibilityConverter();

            var res = converter.Convert(false, typeof(Visibility), null, null);
            Assert.AreEqual(typeof(Visibility), res.GetType());
            Assert.AreEqual(Visibility.Collapsed, (Visibility)res);
        }
    }
}
