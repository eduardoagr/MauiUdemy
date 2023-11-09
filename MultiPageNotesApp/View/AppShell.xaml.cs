namespace MultiPageNotesApp {
    public partial class AppShell : Shell {
        public AppShell() {
            InitializeComponent();

            Routing.RegisterRoute(nameof(AddNotePage), typeof(AddNotePage));
            Routing.RegisterRoute(nameof(NoteDetailPage), typeof(NoteDetailPage));
        }
    }
}