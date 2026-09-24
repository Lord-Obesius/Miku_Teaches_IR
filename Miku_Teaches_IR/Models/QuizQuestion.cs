namespace Miku_Teaches_IR.Models;

public class QuizQuestion
{
    public int Id { get; set; }

    public string TopicId { get; set; } = "";

    public string Question { get; set; } = "";

    public List<string> Answers { get; set; } = new();

    public int CorrectAnswer { get; set; }

    public string Explanation { get; set; } = "";
}