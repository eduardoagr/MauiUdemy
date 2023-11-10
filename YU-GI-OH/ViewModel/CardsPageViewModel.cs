namespace YU_GI_OH.ViewModel;

[QueryProperty("DeckInfo", "DeckInfo")]
public partial class CardsPageViewModel(IHttpService httpService) : ObservableObject {

    [ObservableProperty]
    DeckInfo deckInfo;

    public ObservableCollection<Card> CardList { get; } = new ObservableCollection<Card>();

    [RelayCommand]
    async Task OnApearing() {
        await GetCardNamesAsync(DeckInfo.deckName);
    }

    [RelayCommand]
    async Task SelectedCard(Card card) {

        if (card != null) {
            await Shell.Current.GoToAsync($"{nameof(CardDetailPage)}", true, new Dictionary<string, object> {

           {"Card", card }

           });
        }
    }


    public async Task GetCardNamesAsync(string deckName) {

        var rootobject = await httpService.GetAsync($"https://yugiohprices.com/api/set_data/{deckName}");

        var jsonString = JsonSerializer.Serialize(rootobject);

        var data = JsonSerializer.Deserialize<Rootobject>(jsonString);


        CardList.Clear();
        foreach (var card in data.data.cards) {

            var encodedCardName = Uri.EscapeDataString(card.name);

            card.ImageBytes = await httpService.GetByteArrayAsync($"http://yugiohprices.com/api/card_image/{encodedCardName}");

            CardList.Add(card);
        }
    }
}
