namespace Project_TA;

public partial class StirFryFood : ContentPage
{
	public StirFryFood()
	{
		InitializeComponent();
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
}