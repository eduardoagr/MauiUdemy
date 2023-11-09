namespace YU_GI_OH.ViewModel;
public partial class MainPageViewModel : ObservableObject {

    public ObservableCollection<DeckInfo> Decks { get; set; } = new ObservableCollection<DeckInfo>();

    public MainPageViewModel() {
        LoadData();
    }

    [RelayCommand]
    public void SelectedItem(DeckInfo deckInfo) {

        if (deckInfo != null) {

            Shell.Current.GoToAsync($"{nameof(CardsPage)}", true, new Dictionary<string, object> {

                { "DeckInfo", deckInfo }
            });
        }

    }

    private void LoadData() {

        Decks.Clear();

        Decks.Add(new DeckInfo { deckName = "Starter Deck: Yugi" });
        Decks.Add(new DeckInfo { deckName = "Starter Deck: Joey" });
        Decks.Add(new DeckInfo { deckName = "Starter Deck: Kaiba" });
        Decks.Add(new DeckInfo { deckName = "Starter Deck: Pegasus" });
        Decks.Add(new DeckInfo { deckName = "Starter Deck: Jaden Yuki" });
        Decks.Add(new DeckInfo { deckName = "Starter Deck: Syrus Truesdale" });
        Decks.Add(new DeckInfo { deckName = "Starter Deck: Yugi Evolution" });
    }
}