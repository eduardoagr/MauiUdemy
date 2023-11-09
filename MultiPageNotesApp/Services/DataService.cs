namespace MultiPageNotesApp.Services {
    public class DataService : IDataService {

        IAppService _appService;
        SQLiteConnection _connection;

        public DataService(IAppService appService) {

            _connection = new SQLiteConnection(Constants.GetSQLPath, Constants.openFlags);
            _connection.CreateTable<Note>();
            _appService = appService;
        }

        public void Create(Note note) {
            try {
                int rows = _connection.Insert(note);
                _appService.DisplayToastAsync($"{rows} rows added successfully", ToastDuration.Short);
            } catch (Exception e) {
                Debug.WriteLine(e.Message);
            }
        }

        public void Delete(int id) {
            try {
                var note = GetByID(id);
                if (note != null) {
                    _connection.Delete(note);
                }
            } catch (Exception e) {
                Debug.WriteLine(e.Message);
            }
        }

        public Note GetByID(int id) {
            try {
                return _connection.Table<Note>().FirstOrDefault(n => n.Id == id);
            } catch (Exception e) {
                Debug.WriteLine(e.Message);
            }
            return null;
        }

        public List<Note> Read() {
            try {
                return _connection.Table<Note>().ToList();
            } catch (Exception e) {
                Debug.WriteLine(e.Message);
            }
            return null;
        }
    }
}

