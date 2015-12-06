using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace VariableSizedWrapGrid
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void ToggleButton_OnChecked(object sender, RoutedEventArgs e)
        {
            ShowGroupedView(true);
        }

        private void ToggleButton_OnUnchecked(object sender, RoutedEventArgs e)
        {
            ShowGroupedView(false);
        }

        private void ShowGroupedView(bool show)
        {
            if (Grouped != null && UnGrouped != null)
            {
                Grouped.Visibility = show ? Visibility.Visible : Visibility.Collapsed;
                UnGrouped.Visibility = !show ? Visibility.Visible : Visibility.Collapsed;
            }
        }
    }
}
