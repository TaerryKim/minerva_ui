using Minerva.UI.Controls.Menus;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Minerva.UI.Controls
{
    public class NavigationMenuBar : ContentControl
    {
        #region [ Dependency Properties ] 
        public static readonly DependencyProperty MenuItemsProperty =
            DependencyProperty.Register(
                "MenuItems", typeof(NavigationMenuCollection), typeof(NavigationMenuBar));

        public static readonly DependencyProperty TitleBackgroundProperty =
            DependencyProperty.Register(
                "TitleBackground", typeof(Brush), typeof(NavigationMenuBar));
        #endregion

        #region [ Public Attributes ]
        public NavigationMenuCollection MenuItems
        {
            get => (NavigationMenuCollection)GetValue(MenuItemsProperty);
            set => SetValue(MenuItemsProperty, value);
        }

        public Brush TitleBackground
        {
            get => (Brush)GetValue(TitleBackgroundProperty);
            set => SetValue(TitleBackgroundProperty, value);
        }
        #endregion

        #region [ Constructor ]
        public NavigationMenuBar()
        {
            SetCurrentValue(MenuItemsProperty, new NavigationMenuCollection());
        }
        #endregion
    }
}
