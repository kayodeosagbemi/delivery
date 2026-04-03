using delivery_consumer_app.Models;
using delivery_consumer_app.PageModels;

namespace delivery_consumer_app.Pages
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