namespace Miku_Teaches_IR.Models;

public class StudyProgress
{
    public int XP { get; set; }

    public int CorrectAnswers { get; set; }

    public int QuestionsAnswered { get; set; }

    public HashSet<int> ReviewedFlashcards { get; set; } = new();

    public HashSet<int> ReviewAgain { get; set; } = new();
}