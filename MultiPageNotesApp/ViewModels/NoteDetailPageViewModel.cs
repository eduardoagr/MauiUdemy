namespace MultiPageNotesApp.ViewModels;

[QueryProperty("Note", "Note")]
public partial class NoteDetailPageViewModel : ObservableObject {

    [ObservableProperty]
    Note note;
}
