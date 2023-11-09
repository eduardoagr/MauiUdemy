namespace YU_GI_OH {
    public partial class MainPage : ContentPage {
        public MainPage(MainPageViewModel mainPageViewModel) {
            InitializeComponent();
            BindingContext = mainPageViewModel;
        }
    }
}