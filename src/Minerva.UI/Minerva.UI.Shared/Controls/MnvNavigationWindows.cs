using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;

namespace Minerva.UI.Controls
{
    [ContentProperty("Content")]
    [DefaultProperty("Content")]
    public class MnvNavigationWindows : Window
    {
        #region [ Dependency Properties ]
        public static readonly DependencyProperty TitleBackgroundProperty =
            DependencyProperty.Register(
                "TitleBackground", typeof(Brush), typeof(MnvNavigationWindows));
        
        public static readonly DependencyProperty TitleForegroundBrushProperty =
            DependencyProperty.Register(
                "TitleForegroundBrush", typeof(Brush), typeof(MnvNavigationWindows));

        public static readonly DependencyProperty NavigationWidthProperty =
            DependencyProperty.Register(
                "NavigationWidth", typeof(GridLength), typeof(MnvNavigationWindows), new PropertyMetadata(new GridLength(0, GridUnitType.Auto)));

        public static readonly DependencyProperty CaptionHeightProperty =
            DependencyProperty.Register(
                "CaptionHeight", typeof(int), typeof(MnvNavigationWindows), new PropertyMetadata(30));

        public static readonly DependencyProperty NavigationControlProperty =
            DependencyProperty.Register(
                "NavigationControl", typeof(ContentControl), typeof(MnvNavigationWindows));

        public static readonly DependencyProperty MaximizeButtonProperty =
            DependencyProperty.Register(
                "MaximizeButton", typeof(bool), typeof(MnvNavigationWindows), new PropertyMetadata(true));

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register(
                "CornerRadius", typeof(CornerRadius), typeof(MnvNavigationWindows),
                    new PropertyMetadata());

        public static readonly DependencyProperty ShadowSizeProperty =
            DependencyProperty.Register(
                "ShadowSize", typeof(Thickness), typeof(MnvNavigationWindows),
                    new PropertyMetadata());
        #endregion

        #region [ Private Attributes ]
        private CornerRadius _tmpRadius;
        private Button _maximizeBtn;
        #endregion

        #region [ Public Attributes ]
        public Brush TitleBackground
        {
            get => (Brush)GetValue(TitleBackgroundProperty);
            set => SetValue(TitleBackgroundProperty, value);
        }

        public Brush TitleForegroundBrush
        {
            get => (Brush)GetValue(TitleForegroundBrushProperty);
            set => SetValue(TitleForegroundBrushProperty, value);
        }

        public int CaptionHeight
        {
            get => (int)GetValue(CaptionHeightProperty);
            set => SetValue(CaptionHeightProperty, value);
        }

        /// <summary>
        /// width size of Navigation bar
        /// </summary>
        public GridLength NavigationWidth
        {
            get => (GridLength)GetValue(NavigationWidthProperty);
            set => SetValue(NavigationWidthProperty, value);
        }

        /// <summary>
        /// Content area for navigation bar
        /// </summary>
        public ContentControl NavigationControl
        {
            get => (ContentControl)GetValue(NavigationControlProperty);
            set => SetValue(NavigationControlProperty, value);
        }
        public bool MaximizeButton
        {
            get => (bool)GetValue(MaximizeButtonProperty);
            set => SetValue(MaximizeButtonProperty, value);
        }

        public CornerRadius CornerRadius
        {
            get => (CornerRadius)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
        }

        public Thickness ShadowSize
        {
            get => (Thickness)GetValue(ShadowSizeProperty);
            set => SetValue(ShadowSizeProperty, value);
        }
        #endregion

        #region [ Private Methods ]
        private void InitializeCommands()
        {
            this.SetResourceReference(StyleProperty, typeof(MnvNavigationWindows));

            // Set commands
            this.CommandBindings.Add(new CommandBinding(SystemCommands.MinimizeWindowCommand, Minimize_Execute));
            this.CommandBindings.Add(new CommandBinding(SystemCommands.MaximizeWindowCommand, Maximize_Execute));
            this.CommandBindings.Add(new CommandBinding(SystemCommands.RestoreWindowCommand, Restore_Execute));
            this.CommandBindings.Add(new CommandBinding(SystemCommands.CloseWindowCommand, Close_Execute));
        }
        #endregion

        #region [ Constructor ]
        public MnvNavigationWindows()
        {
            InitializeCommands();
        }
        #endregion

        #region [ Command Properties ]
        private void Close_Execute(object sender, ExecutedRoutedEventArgs e)
        {
            SystemCommands.CloseWindow(this);
        }

        private void Maximize_Execute(object sender, ExecutedRoutedEventArgs e)
        {
            _tmpRadius = CornerRadius;
            CornerRadius = new CornerRadius(0);

            _maximizeBtn.Command = SystemCommands.RestoreWindowCommand;
            SystemCommands.MaximizeWindow(this);
        }

        private void Restore_Execute(object sender, ExecutedRoutedEventArgs e)
        {
            CornerRadius = _tmpRadius;

            _maximizeBtn.Command = SystemCommands.MaximizeWindowCommand;
            SystemCommands.RestoreWindow(this);
        }

        private void Minimize_Execute(object sender, ExecutedRoutedEventArgs e)
        {
            SystemCommands.MinimizeWindow(this);
        }

        #endregion

        #region [ Public Override Methods ]
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            _maximizeBtn = GetTemplateChild("PART_MaximizeBtn") as Button;
        }
        #endregion      
    }
}
