namespace YU_GI_OH.ViewModel;

[QueryProperty("DeckInfo", "DeckInfo")]
public partial class CardsPageViewModel(IHttpService httpService) : ObservableObject {

    [ObservableProperty]
    DeckInfo deckInfo;

    [ObservableProperty]
    bool isBusy;

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
        CardList.Clear();

        IsBusy = true;

        var cards = await httpService.GetAsync<CardInfo>($"https://yugiohprices.com/api/set_data/{deckName}");


        if (cards != null) {

            foreach (var card in cards.data.cards) {

                var encodedName = Uri.EscapeDataString(card.name);

                var cardDetail = await httpService.GetAsync<CardDetail>(
                    $"https://db.ygoprodeck.com/api/v7/cardinfo.php?name={encodedName}");

                card.id = cardDetail.Data.FirstOrDefault().Id;
                card.description = cardDetail.Data.FirstOrDefault().Desc;
                card.atk = cardDetail.Data.FirstOrDefault().Atk;
                card.def = cardDetail.Data.FirstOrDefault().Def;
                card.Race = cardDetail.Data.FirstOrDefault().Race;
                card.Level = cardDetail.Data.FirstOrDefault().Level;
                card.Attribute = cardDetail.Data.FirstOrDefault().Attribute;


                var path = Path.Combine(FileSystem.CacheDirectory, card.id.ToString() + "jpg");
                if (!File.Exists(path)) {

                    var file = File.Create(path);
                    file.Write(await httpService.GetByteArrayAsync(card.image_url));
                }

                card.image_path = path;

                CardList.Add(card);
            }
        }

        IsBusy = false;
    }
}
