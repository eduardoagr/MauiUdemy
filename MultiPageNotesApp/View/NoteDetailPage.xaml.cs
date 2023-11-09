namespace MultiPageNotesApp.View {
    public partial class NoteDetailPage : ContentPage {
        public NoteDetailPage(NoteDetailPageViewModel noteDetailPage) {
            InitializeComponent();
            BindingContext = noteDetailPage;
        }

    }
}