
namespace YU_GI_OH {
    public partial class AppShell : Shell {
        public AppShell() {
            InitializeComponent();

            Routing.RegisterRoute(nameof(CardsPage), typeof(CardsPage));
        }
    }
}