namespace MultiPageNotesApp.ViewModels;
public partial class AddNotePageViewModel(IAppService appService, IDataService dataService) : BaseViewModel("New note") {

    [ObservableProperty]
    Note note;

    [ObservableProperty]
    Color selectedColor;

    public ObservableCollection<ColorItem> ColorItems { get; set; } = new ObservableCollection<ColorItem>();

    [RelayCommand]
    void SelectColor(ColorItem colorItem) {

        SelectedColor = colorItem.Color;
    }

    [RelayCommand]
    void Appearing() {
        ColorItems.Clear();
        LoadColors();
    }

    private void LoadColors() {
        ColorItems.Add(new ColorItem { Color = Colors.Yellow });
        ColorItems.Add(new ColorItem { Color = Colors.Red });
        ColorItems.Add(new ColorItem { Color = Colors.Purple });
        ColorItems.Add(new ColorItem { Color = Colors.CornflowerBlue });
        ColorItems.Add(new ColorItem { Color = Colors.Green });

    }

    [RelayCommand]
    async Task CreateNewNoteAsync() {

        if (!string.IsNullOrEmpty(Note.Title) || !string.IsNullOrEmpty(Note.Content)) {
            dataService.Create(new Note {
                Title = Note.Title,
                Content = Note.Content,
                CreationDate = DateTime.Now,
                Color = Note.Color
            });

            await appService.NavigateBackAsync(true, "..");
        }
    }
}
