using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using Mopups.Services;

namespace MauiMopUp {
    public partial class MainPageViewModel(MyPopupPageViewModel myPopupPageViewModel) : ObservableObject {

        [RelayCommand]
        async Task ShowPopUp() {
            myPopupPageViewModel.Data = "eduardo";
            await MopupService.Instance.PushAsync(new MyPopupPage(myPopupPageViewModel));
        }
    }
}
