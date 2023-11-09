namespace MultiPageNotesApp.ViewModels;
public partial class HomePageViewModel(IAppService appService, IDataService dataService) : BaseViewModel("Home") {

    public ObservableCollection<Note> Notes { get; } = new ObservableCollection<Note>();

    [RelayCommand]
    void Appearing() {
        Notes.Clear();
        GetAllNotes();
    }

    [RelayCommand]
    async Task AddNewNote() {
        await appService.NavigateToAsync($"{nameof(AddNotePage)}", true);
    }

    [RelayCommand]
    async Task GoToDetails(Note note) {
        await appService.NavigateToAsync($"{nameof(NoteDetailPage)}", true,
            new Dictionary<string, object> {
                {"Note", note}
            });
    }

    private void GetAllNotes() {

        var allNotes = dataService.Read();
        Notes.Clear();
        foreach (var note in allNotes) {
            Notes.Add(note);

        }
    }
}
