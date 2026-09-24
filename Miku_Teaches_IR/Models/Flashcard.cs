namespace Miku_Teaches_IR.Models;

public class Flashcard
{
    public int Id { get; set; }

    public string TopicId { get; set; } = "";

    public string Question { get; set; } = "";
    public string Answer { get; set; } = "";

    public bool IsReviewed { get; set; }
}