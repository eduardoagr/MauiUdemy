namespace MultiPageNotesApp {
    public static class Constants {

        private const string DATABASE_NAME = "NotesData.db3";

        public const SQLiteOpenFlags openFlags = 
            SQLiteOpenFlags.ReadWrite | 
            SQLiteOpenFlags.Create | 
            SQLiteOpenFlags.SharedCache;

        public static string GetSQLPath => Path.Combine(FileSystem.AppDataDirectory, DATABASE_NAME);
       
    }
}
