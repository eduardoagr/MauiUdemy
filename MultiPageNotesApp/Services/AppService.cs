namespace MultiPageNotesApp.Services;
public class AppService : IAppService {
    public async Task DisplayAlertAsync(string title, string message, string cancelMessage = "Ok") {
        await Shell.Current.DisplayAlert(title, message, cancelMessage);
    }

    public async Task DisplayToastAsync(string text, ToastDuration toastDuration) {
        var toast = Toast.Make(text, toastDuration);
        await toast.Show();
    }

    public async Task NavigateBackAsync(bool animated, string quary = "..") {
        await Shell.Current.GoToAsync(quary, animated);
    }

    public async Task NavigateToAsync(string pageName, bool animated, Dictionary<string, object> objToPass) {
        await Shell.Current.GoToAsync(pageName, animated, objToPass);
    }

    public async Task NavigateToAsync(string pageName, bool animated) {
        await Shell.Current.GoToAsync($"{nameof(AddNotePage)}", animated);
    }

    public async Task ShowPopupAsync(Popup popup) {
        await Shell.Current.CurrentPage.ShowPopupAsync(popup);
    }

    public async Task CloePopUpAsync(Popup popup) {
        await popup.CloseAsync();
    }
}
