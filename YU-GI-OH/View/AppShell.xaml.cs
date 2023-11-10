namespace YU_GI_OH {
    public partial class AppShell : Shell {
        public AppShell() {
            InitializeComponent();

            var assembly = GetType().Assembly;
            string viewsNamespace = "YU_GI_OH.View"; // Adjust to match your folder structure

            Dictionary<string, Type> pageRoutes = new();

            foreach (var type in assembly.GetTypes()) {
                if (type.Namespace == viewsNamespace && type.Name.EndsWith("Page")) {
                    // Extract the route name from the type's name
                    string routeName = type.Name;

                    // Register the route name and associated type in the dictionary
                    pageRoutes.Add(routeName, type);
                }
            }

            // Now you can use the 'pageRoutes' dictionary to register your routes
            foreach (var kvp in pageRoutes) {
                Routing.RegisterRoute(kvp.Key, kvp.Value);
            }
        }
    }
}