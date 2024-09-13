using Project_TA.Services;

namespace Project_TA
{
    public partial class MainPage : ContentPage
    {
        Services.GenerateFood gen = new Services.GenerateFood();
        

        public MainPage()
        {
            InitializeComponent();

            gen.Generate();
            this.BindingContext = gen;

            
        }

        private void Button_Clicked_BoiledFood(object sender, EventArgs e)
        {
            App.Current.MainPage = new BoiledFood();
        }

        private void ImageButton_Clicked_ProfilePage(object sender, EventArgs e)
        {
            App.Current.MainPage = new ProfilePage();
        }

        private void Button_Clicked_FriedFood(object sender, EventArgs e)
        {
            App.Current.MainPage = new FriedFood();
        }

        private void Button_Clicked_StirFryFood(object sender, EventArgs e)
        {
            App.Current.MainPage = new StirFryFood();
        }

        private void Button_Clicked_SteamedFood(object sender, EventArgs e)
        {
            App.Current.MainPage = new SteamedFood();
        }

        private void Button_Clicked_GrilledFood(object sender, EventArgs e)
        {
            App.Current.MainPage = new GrilledFood();
        }

        private void Button_Clicked_Salad(object sender, EventArgs e)
        {
            App.Current.MainPage = new Salad();
        }

        private void Btn_post_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new Post();
        }

        private void Btn_search_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new SearchPage();
        }
    }


}
