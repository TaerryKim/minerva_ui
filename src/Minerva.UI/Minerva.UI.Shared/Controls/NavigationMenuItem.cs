using Minerva.UI.Controls.Menus;
using System.Windows;
using System.Windows.Controls;

namespace Minerva.UI.Controls
{
    public class NavigationMenuItem : RadioButton
    {
        #region [ Dependency Properties ]
        public static readonly DependencyProperty NormalSourceProperty =
            DependencyProperty.Register(
                "NormalSource", typeof(string), typeof(NavigationMenuItem));

        public static readonly DependencyProperty ActivatedSourceProperty =
            DependencyProperty.Register(
                "ActivatedSource", typeof(string), typeof(NavigationMenuItem));

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register(
                "Title", typeof(string), typeof(NavigationMenuItem));

        public static readonly DependencyProperty SubMenuItemsProperty =
            DependencyProperty.Register(
                "SubMenuItems", typeof(NavigationSubMenuCollection), typeof(NavigationMenuItem));
        #endregion

        #region [ Public Methods ]
        public string NormalSource
        {
            get => (string)GetValue(NormalSourceProperty);
            set => SetValue(NormalSourceProperty, value);
        }
        public string ActivatedSource
        {
            get => (string)GetValue(ActivatedSourceProperty);
            set => SetValue(ActivatedSourceProperty, value);
        }
        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        public NavigationSubMenuCollection SubMenuItems
        {
            get => (NavigationSubMenuCollection)GetValue(SubMenuItemsProperty);
            set => SetValue(SubMenuItemsProperty, value);
        }
        #endregion

        #region [ Constructor ]
        public NavigationMenuItem()
        {
            SetCurrentValue(SubMenuItemsProperty, new NavigationSubMenuCollection());
        }
        #endregion
    }
}
