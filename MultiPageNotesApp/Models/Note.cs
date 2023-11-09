namespace MultiPageNotesApp.Models;

[Table("Notes")]
public class Note {

    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    public string Title { get; set; }

    public string Content { get; set; }

    public string Color { get; set; }

    public DateTime CreationDate { get; set; }

}
