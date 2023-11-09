namespace MultiPageNotesApp.View {
    public partial class HomePage : ContentPage {
        public HomePage(HomePageViewModel homePageViewModel) {
            InitializeComponent();

            BindingContext = homePageViewModel;
        }
    }
}