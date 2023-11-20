namespace MultiPageNotesApp.ViewModels;
public partial class AddNotePageViewModel(IAppService appService, IDataService dataService) : BaseViewModel("New note") {

    [ObservableProperty]
    Note note = new();

    [ObservableProperty]
    string selectedColor;

    public ObservableCollection<ColorItem> ColorItems { get; set; } = new ObservableCollection<ColorItem>();

    [RelayCommand]
    void SelectColor(ColorItem colorItem) {

        SelectedColor = colorItem.Color;
    }

    [RelayCommand]
    void Appearing() {
        LoadColors();
    }

    private void LoadColors() {
        ColorItems.Add(new ColorItem { Color = Colors.Yellow.ToHex() });
        ColorItems.Add(new ColorItem { Color = Colors.Red.ToHex() });
        ColorItems.Add(new ColorItem { Color = Colors.Purple.ToHex() });
        ColorItems.Add(new ColorItem { Color = Colors.CornflowerBlue.ToHex() });
        ColorItems.Add(new ColorItem { Color = Colors.Green.ToHex() });

    }

    [RelayCommand]
    async Task CreateNewNoteAsync() {

        dataService.Create(new Note {
            Title = Note.Title,
            Content = Note.Content,
            CreationDate = DateTime.Now,
            Color = SelectedColor
        });

        await appService.NavigateBackAsync(true, "..");
    }
}

