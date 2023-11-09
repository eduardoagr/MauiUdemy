namespace MultiPageNotesApp.View {
    public partial class AddNotePage : ContentPage {
        public AddNotePage(AddNotePageViewModel addNotePageViewModel) {
            InitializeComponent();
            BindingContext = addNotePageViewModel;
        }
    }
}