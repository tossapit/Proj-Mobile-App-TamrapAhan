using Project_TA.Models;

namespace Project_TA;

public partial class Post : ContentPage
{
    public string FoodName { get; set; }
    public string Ingredient { get; set; }
    public string FoodRecipes { get; set; }

    public Post()
    {
        InitializeComponent();
        BindingContext = this;
    }

    private void Btn_saveimage_Clicked(object sender, EventArgs e)
    {
        var newRecipe = new Recipes
        {
            FoodName = FoodName,
            Ingredient = Ingredient,
            FoodRecipes = FoodRecipes,
            FoodImage = "default_image.png" // You can set a default image or add functionality to upload an image
        };

        // Assuming you have a static list to store the recipes
        ProfilePage.Recipes.Add(newRecipe);

        // Navigate to ProfilePage
        App.Current.MainPage = new ProfilePage();
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

    private void Btn_upload_Clicked(object sender, EventArgs e)
    {
        // Implement image upload functionality here
    }
}
