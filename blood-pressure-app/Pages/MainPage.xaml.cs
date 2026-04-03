using blood_pressure_app.Models;
using blood_pressure_app.PageModels;

namespace blood_pressure_app.Pages
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