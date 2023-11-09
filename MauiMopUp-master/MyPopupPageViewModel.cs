using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using Mopups.Services;

namespace MauiMopUp {
    public partial class MyPopupPageViewModel : ObservableObject {

        public event Action<object> ResultReady;

        [ObservableProperty]
        object data;

        [ObservableProperty]
        object name;

        [RelayCommand]
        async Task closePopUp() {

            var result = Name; // Set the result data.

            // Notify the result is ready.
            ResultReady?.Invoke(result);

            await MopupService.Instance.PopAsync();

            if (result != null) {
                await Shell.Current.DisplayAlert("here", Name.ToString(), "OK");
            }


        }
    }
}
