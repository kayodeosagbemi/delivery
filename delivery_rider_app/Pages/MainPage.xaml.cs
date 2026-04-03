using delivery_rider_app.Models;
using delivery_rider_app.PageModels;

namespace delivery_rider_app.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}