using System;
using System.Windows;
using System.Windows.Controls;

namespace Minerva.UI.Controls
{
    public class NavigationSubMenuItem : RadioButton
    {
        #region [ Dependency Properties ]
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register(
                "Title", typeof(string), typeof(NavigationSubMenuItem));

        public static readonly DependencyProperty NavigatorProperty =
            DependencyProperty.Register(
                "Navigator", typeof(Frame), typeof(NavigationSubMenuItem));

        public static readonly DependencyProperty PageUriProperty =
            DependencyProperty.Register(
                "PageUri", typeof(Uri), typeof(NavigationSubMenuItem));

        public static readonly DependencyProperty PageProperty =
            DependencyProperty.Register(
                "Page", typeof(object), typeof(NavigationSubMenuItem));
        #endregion

        #region [ Public Attributes ]
        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        public Frame Navigator
        {
            get => (Frame)GetValue(NavigatorProperty);
            set => SetValue(NavigatorProperty, value);
        }

        public Uri PageUri
        {
            get => (Uri)GetValue(PageUriProperty);
            set => SetValue(PageUriProperty, value);
        }

        public object Page
        {
            get => (object)GetValue(PageProperty);
            set => SetValue(PageProperty, value);
        }
        #endregion

        #region [ Constructor ]
        public NavigationSubMenuItem()
        {
            GroupName = "MnvMenuGroup";
        }
        #endregion

        #region [ Event Hanler ]
        protected override void OnChecked(RoutedEventArgs e)
        {
            if (Navigator != null)
                Navigator.Navigate(Page);

            base.OnChecked(e);
        }
        #endregion
    }
}
