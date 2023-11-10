namespace YU_GI_OH.ViewModel;

[QueryProperty("Card", "Card")]
public partial class CardDetailPageViewModel(IHttpService httpService) : ObservableObject {

    [ObservableProperty]
    Card card;

    [ObservableProperty]
    CardDetail cardDetail;

    [RelayCommand]
    async Task OnApearing() {
        await GetInfo(Card.name);
    }

    private async Task<CardDetail> GetInfo(string name) {
        var rootobject = await httpService.GetAsync($"http://yugiohprices.com/api/card_data/{name}");

        var jsonString = JsonSerializer.Serialize(rootobject);

        var data = JsonSerializer.Deserialize<ParentObj>(jsonString);

        return data.data;
    }
}
