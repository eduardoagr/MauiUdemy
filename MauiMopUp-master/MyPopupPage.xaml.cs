using Mopups.Pages;

namespace MauiMopUp;

public partial class MyPopupPage : PopupPage {
    public event EventHandler<string> DataReturned;

    public MyPopupPage(MyPopupPageViewModel myPopupPageViewModel) {
        InitializeComponent();
        BindingContext = myPopupPageViewModel;
    }
}