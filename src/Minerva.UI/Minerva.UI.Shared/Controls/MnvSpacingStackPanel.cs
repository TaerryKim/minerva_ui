using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Minerva.UI.Controls
{
    public class MnvSpacingStackPanel : StackPanel
    {
        #region [ Dependency Properties ]
        public static readonly DependencyProperty SpacingProperty =
            DependencyProperty.Register(
                "Spacing", typeof(double), typeof(MnvSpacingStackPanel), new FrameworkPropertyMetadata(
                    10d,
                    FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsRender));

        public static readonly DependencyProperty PaddingProperty =
            DependencyProperty.Register(
                "Padding", typeof(Thickness), typeof(MnvSpacingStackPanel), new FrameworkPropertyMetadata(
                    new Thickness(),
                    FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsRender));
        #endregion

        #region [ Public Attributes ]
        public double Spacing
        {
            get => (double)GetValue(SpacingProperty);
            set => SetValue(SpacingProperty, value);
        }

        public Thickness Padding
        {
            get => (Thickness)GetValue(PaddingProperty);
            set => SetValue(PaddingProperty, value);
        }

        public bool IsVertical
        {
            get { return Orientation == Orientation.Vertical; }
        }

        internal Dictionary<object, Rect> lastArrangedBounds;

        public MnvSpacingStackPanel()
        {
            lastArrangedBounds = new Dictionary<object, Rect>();

            this.CanHorizontallyScroll = false;
            this.CanVerticallyScroll = false;
        }

        public Rect GetArrangedBound(FrameworkElement element)
        {
            if (!lastArrangedBounds.ContainsKey(element))
                return new Rect(-1, -1, -1, -1);

            return lastArrangedBounds[element];
        }
        #endregion

        #region [ Private Attributes ]
        private Size CollapseThickness(Thickness thickness)
        {
            return new Size(
                thickness.Left + thickness.Right,
                thickness.Top + thickness.Bottom);
        }
        #endregion

        #region [ Protected Attributes ]
        protected override Size MeasureOverride(Size constraint)
        {
            Size stackDesiredSize = new Size();
            Size layoutSlotSize = constraint;

            Size padding = CollapseThickness(this.Padding);

            constraint.Width = Math.Max(0, constraint.Width - padding.Width);
            constraint.Height = Math.Max(0, constraint.Height - padding.Height);

            if (IsVertical)
            {
                layoutSlotSize.Height = double.PositiveInfinity;

                if (this.CanHorizontallyScroll)
                    layoutSlotSize.Width = double.PositiveInfinity;
            }
            else
            {
                layoutSlotSize.Width = double.PositiveInfinity;

                if (this.CanVerticallyScroll)
                    layoutSlotSize.Height = double.PositiveInfinity;
            }

            for (int i = 0, count = this.Children.Count; i < count; ++i)
            {
                UIElement child = this.Children[i];

                if (child == null || child.Visibility != Visibility.Visible)
                    continue;

                child.Measure(layoutSlotSize);
                Size childDesiredSize = child.DesiredSize;

                if (IsVertical)
                {
                    stackDesiredSize.Width = Math.Max(stackDesiredSize.Width, childDesiredSize.Width);
                    stackDesiredSize.Height += childDesiredSize.Height + Spacing;

                    if (i == this.Children.Count - 1)
                        stackDesiredSize.Height -= Spacing;
                }
                else
                {
                    stackDesiredSize.Width += childDesiredSize.Width + Spacing;
                    stackDesiredSize.Height = Math.Max(stackDesiredSize.Height, childDesiredSize.Height);

                    if (i == this.Children.Count - 1)
                        stackDesiredSize.Width -= Spacing;
                }
            }

            stackDesiredSize.Width += padding.Width;
            stackDesiredSize.Height += padding.Height;

            return stackDesiredSize;
        }

        protected override Size ArrangeOverride(Size arrangeSize)
        {
            var rcChild = new Rect(
                new Point(this.Padding.Left, this.Padding.Top),
                arrangeSize);

            double previousChildSize = 0.0;

            Size padding = CollapseThickness(this.Padding);

            for (int i = 0, count = this.Children.Count; i < count; ++i)
            {
                UIElement child = this.Children[i];

                if (child == null || child.Visibility != Visibility.Visible)
                    continue;

                double space = i > 0 ? Spacing : 0;

                if (IsVertical)
                {
                    rcChild.Y += previousChildSize + space;
                    previousChildSize = child.DesiredSize.Height;

                    rcChild.Height = previousChildSize;
                    rcChild.Width = Math.Max(Math.Max(arrangeSize.Width, child.DesiredSize.Width) - padding.Width, 0);
                }
                else
                {
                    rcChild.X += previousChildSize + space;
                    previousChildSize = child.DesiredSize.Width;

                    rcChild.Width = previousChildSize;
                    rcChild.Height = Math.Max(Math.Max(arrangeSize.Height, child.DesiredSize.Height) - padding.Height, 0);
                }

                // chaching
                lastArrangedBounds[child] = rcChild;

                child.Arrange(rcChild);
            }

            return arrangeSize;
        }
        #endregion
    }
}
