namespace MultiPageNotesApp.ViewModels;

public partial class BaseViewModel(string title) : ObservableObject {

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsNotBusy))]
    bool isBusy;

    [ObservableProperty]
    string title = title;

    public bool IsNotBusy => !IsBusy;


}
