using Project_TA.Models;
using System.Collections.ObjectModel;

namespace Project_TA;

public partial class ProfilePage : ContentPage
{
    public static ObservableCollection<Recipes> Recipes { get; set; }

    public ProfilePage()
    {
        InitializeComponent();
        if (Recipes == null)
        {
            Recipes = new ObservableCollection<Recipes>();
        }
        BindingContext = this;
    }

    private void Btn_home_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new MainPage();
    }

    private void Btn_post_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new Post();
    }

    private void Btn_profile_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new ProfilePage();
    }

    private void Btn_MySearch_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new MySearch();
    }
}
