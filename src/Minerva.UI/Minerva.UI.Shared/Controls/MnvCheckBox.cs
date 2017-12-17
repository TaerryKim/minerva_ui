using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Minerva.UI.Controls
{
    public class MnvCheckBox : CheckBox
    {
        #region [ Dependency Properties ]
        public static readonly DependencyProperty MouseOverBrushProperty =
            DependencyProperty.Register(
                "MouseOverBrush", typeof(Brush), typeof(MnvCheckBox));

        public static readonly DependencyProperty MouseClickBrushProperty =
            DependencyProperty.Register(
                "MouseClickBrush", typeof(Brush), typeof(MnvCheckBox));

        public static readonly DependencyProperty MouseOverBorderBrushProperty =
            DependencyProperty.Register(
                "MouseOverBorderBrush", typeof(Brush), typeof(MnvCheckBox));

        public static readonly DependencyProperty MouseClickBorderBrushProperty =
            DependencyProperty.Register(
                "MouseClickBorderBrush", typeof(Brush), typeof(MnvCheckBox));

        public static readonly DependencyProperty CheckImageColorProperty =
            DependencyProperty.Register(
                "CheckImageColor", typeof(Brush), typeof(MnvCheckBox));
        #endregion

        #region [ Public Attributes ]
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

        public Brush MouseClickBorderBrush
        {
            get => (Brush)GetValue(MouseClickBorderBrushProperty);
            set => SetValue(MouseClickBorderBrushProperty, value);
        }

        public Brush CheckImageColor
        {
            get => (Brush)GetValue(CheckImageColorProperty);
            set => SetValue(CheckImageColorProperty, value);
        }
        #endregion
    }
}
