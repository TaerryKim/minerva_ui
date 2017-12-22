using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Minerva.UI.Extensions
{
    public class AttachedProperties
    {
        #region [ HideExpanderArrow AttachedProperty ]
        [AttachedPropertyBrowsableForType(typeof(Expander))]
        public static void SetHideExpanderArrow(DependencyObject obj, bool value)
        {
            obj.SetValue(HideExpanderArrowProperty, value);
        }

        // Using a DependencyProperty as the backing store for HideExpanderArrow.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HideExpanderArrowProperty =
            DependencyProperty.RegisterAttached("HideExpanderArrow", typeof(bool), typeof(AttachedProperties), new UIPropertyMetadata(false, OnHideExpanderArrowChanged));

        private static void OnHideExpanderArrowChanged(DependencyObject o, DependencyPropertyChangedEventArgs e)
        {
            Expander expander = (Expander)o;

            if (expander.IsLoaded)
            {
                UpdateExpanderArrow(expander, (bool)e.NewValue);
            }
            else
            {
                expander.Loaded += new RoutedEventHandler((x, y) => UpdateExpanderArrow(expander, (bool)e.NewValue));
            }
        }

        private static void UpdateExpanderArrow(Expander expander, bool visible)
        {
            Grid headerGrid =
                VisualTreeHelper.GetChild(
                    VisualTreeHelper.GetChild(
                            VisualTreeHelper.GetChild(
                                VisualTreeHelper.GetChild(
                                    VisualTreeHelper.GetChild(
                                        expander,
                                        0),
                                    0),
                                0),
                            0),
                        0) as Grid;

            headerGrid.Children[0].Visibility = visible ? Visibility.Collapsed : Visibility.Visible;
            headerGrid.Children[1].Visibility = visible ? Visibility.Collapsed : Visibility.Visible;
            headerGrid.Children[2].SetValue(Grid.ColumnProperty, visible ? 0 : 1); 
            headerGrid.Children[2].SetValue(Grid.ColumnSpanProperty, visible ? 2 : 1); 
            headerGrid.Children[2].SetValue(ContentPresenter.MarginProperty, visible ? new Thickness(0) : new Thickness(4, 0, 0, 0));
        }

        #endregion
    }
}
