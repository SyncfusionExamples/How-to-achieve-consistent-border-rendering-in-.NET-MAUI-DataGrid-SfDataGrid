namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
#if ANDROID
            dataGrid.DefaultStyle.GridLineStrokeThickness *= (float)DeviceDisplay.MainDisplayInfo.Density;
            dataGrid.DefaultStyle.HeaderGridLineStrokeThickness *= (float)DeviceDisplay.MainDisplayInfo.Density;
#endif
        }
    }
}
