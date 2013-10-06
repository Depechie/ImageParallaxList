using System;
using System.Windows;
using System.Windows.Navigation;
using ImageParallaxList.Converters;
using Microsoft.Phone.Controls;

namespace ImageParallaxList
{
    public partial class DetailsPage : PhoneApplicationPage
    {
        private bool _sliderConvertValueSet = false;
        private const double ZeroDouble = 0;

        // Constructor
        public DetailsPage()
        {
            InitializeComponent();
        }

        // When page is navigated to set data context to selected item in list
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (DataContext == null)
            {
                string selectedIndex = "";
                if (NavigationContext.QueryString.TryGetValue("selectedItem", out selectedIndex))
                {
                    int index = int.Parse(selectedIndex);
                    DataContext = App.ViewModel.Items[index];
                    _sliderConvertValueSet = false;
                }
            }
        }

        private void ContentPanel_OnLayoutUpdated(object sender, EventArgs e)
        {
            if (!_sliderConvertValueSet && !Double.IsInfinity(ScrollViewer.ScrollableHeight) && !ScrollViewer.ScrollableHeight.Equals(ZeroDouble))
            {
                var slideValue = this.Image.ActualHeight - this.ImageControl.ActualHeight;
                var slideConvert = slideValue/this.ScrollViewer.ScrollableHeight;

                ScrollViewerOffsetConverter.ConvertValue = slideConvert;

                _sliderConvertValueSet = true;
            }
        }
    }
}