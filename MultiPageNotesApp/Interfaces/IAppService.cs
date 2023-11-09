namespace MultiPageNotesApp.Interfaces {
    public interface IAppService {

        Task NavigateToAsync(string pageName, bool animated, Dictionary<string, object> objToPass);

        Task NavigateBackAsync(bool animated, string quary);

        Task DisplayAlertAsync(string title, string message, string cancelMessage);

        Task NavigateToAsync(string pageName, bool animated);

        Task DisplayToastAsync(string text, ToastDuration toastDuration);

        Task ShowPopupAsync(Popup popup);

        Task CloePopUpAsync(Popup popup);
    }
}
