using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Minerva.UI.Controls
{
    public class MnvRoundCornerButton : Button
    {
        #region [ Dependency Properties ]
        public static readonly DependencyProperty MouseOverBrushProperty =
            DependencyProperty.Register(
                "MouseOverBrush", typeof(Brush), typeof(MnvRoundCornerButton));

        public static readonly DependencyProperty MouseClickBrushProperty =
            DependencyProperty.Register(
                "MouseClickBrush", typeof(Brush), typeof(MnvRoundCornerButton));

        public static readonly DependencyProperty MouseOverBorderBrushProperty =
            DependencyProperty.Register(
                "MouseOverBorderBrush", typeof(Brush), typeof(MnvRoundCornerButton));

        public static readonly DependencyProperty MouseOverForegroundBrushProperty =
            DependencyProperty.Register(
                "MouseOverForegroundBrush", typeof(Brush), typeof(MnvRoundCornerButton));

        public static readonly DependencyProperty MouseClickBorderBrushProperty =
            DependencyProperty.Register(
                "MouseClickBorderBrush", typeof(Brush), typeof(MnvRoundCornerButton));

        public static readonly DependencyProperty MouseClickForegroundBrushProperty =
            DependencyProperty.Register(
                "MouseClickForegroundBrush", typeof(Brush), typeof(MnvRoundCornerButton));

        public static readonly DependencyProperty ButtonBrushProperty =
            DependencyProperty.Register(
                "ButtonBrush", typeof(Brush), typeof(MnvRoundCornerButton));

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register(
                "CornerRadius", typeof(CornerRadius), typeof(MnvRoundCornerButton),
                    new PropertyMetadata(new CornerRadius(5)));
        #endregion

        #region [ Public Attributes ]
        public Brush ButtonBrush
        {
            get => (Brush)GetValue(ButtonBrushProperty);
            set => SetValue(ButtonBrushProperty, value);
        }

        public Brush MouseOverBrush
        {
            get => (Brush)GetValue(MouseOverBrushProperty);
            set => SetValue(MouseOverBrushProperty, value);
        }

        public Brush MouseClickBrush
        {
            get => (Brush)GetValue(MouseClickBrushProperty);
            set => SetValue(MouseClickBrushProperty, value);
        }

        public Brush MouseOverBorderBrush
        {
            get => (Brush)GetValue(MouseOverBorderBrushProperty);
            set => SetValue(MouseOverBorderBrushProperty, value);
        }

        public Brush MouseOverForegroundBrush
        {
            get => (Brush)GetValue(MouseOverForegroundBrushProperty);
            set => SetValue(MouseOverForegroundBrushProperty, value);
        }

        public Brush MouseClickBorderBrush
        {
            get => (Brush)GetValue(MouseClickBorderBrushProperty);
            set => SetValue(MouseClickBorderBrushProperty, value);
        }

        public Brush MouseClickForegroundBrush
        {
            get => (Brush)GetValue(MouseClickForegroundBrushProperty);
            set => SetValue(MouseClickForegroundBrushProperty, value);
        }

        public CornerRadius CornerRadius
        {
            get => (CornerRadius)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
        }
        #endregion
    }
}
