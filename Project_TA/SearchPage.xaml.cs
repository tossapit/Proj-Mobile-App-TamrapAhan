namespace Project_TA;

public partial class SearchPage : ContentPage
{
	public SearchPage()
	{
		InitializeComponent();
	}

    private void Btn_back_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new MainPage();
    }
}