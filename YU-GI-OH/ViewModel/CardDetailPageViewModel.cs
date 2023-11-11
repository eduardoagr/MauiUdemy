namespace YU_GI_OH.ViewModel;

[QueryProperty("Card", "Card")]
public partial class CardDetailPageViewModel : ObservableObject {

    [ObservableProperty]
    Card card;
}
