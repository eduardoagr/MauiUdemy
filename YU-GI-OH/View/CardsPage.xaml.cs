namespace YU_GI_OH.View;

public partial class CardsPage : ContentPage {
    public CardsPage(CardsPageViewModel cardsPageViewModel) {
        InitializeComponent();
        BindingContext = cardsPageViewModel;
    }
}