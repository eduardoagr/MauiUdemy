namespace MultiPageNotesApp.Models;
public interface IDataService {

    void Create(Note note);

    List<Note> Read();

    void Delete(int id);

    Note GetByID(int id);
}

