namespace YU_GI_OH.View {
    public partial class CardDetailPage : ContentPage {
        public CardDetailPage(CardDetailPageViewModel cardDetailViewModel) {
            InitializeComponent();
            BindingContext = cardDetailViewModel;
        }
    }
}