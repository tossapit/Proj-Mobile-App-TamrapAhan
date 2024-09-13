namespace Project_TA;

public partial class MySearch : ContentPage
{
	public MySearch()
	{
		InitializeComponent();
	}

    private void Btn_back_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new ProfilePage();
    }
}