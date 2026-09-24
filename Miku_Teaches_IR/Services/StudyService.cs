using Miku_Teaches_IR.Data;
using Miku_Teaches_IR.Models;

namespace Miku_Teaches_IR.Services;

public class StudyService
{
    public IReadOnlyList<StudyTopic> Topics => StudyData.Topics;

    public IReadOnlyList<Flashcard> Flashcards => StudyData.Flashcards;

    public IReadOnlyList<QuizQuestion> QuizQuestions =>
        StudyData.QuizQuestions;

    public IReadOnlyList<BattleScenario> Battles =>
        StudyData.Battles;

    public StudyTopic? GetTopic(string id)
    {
        return Topics.FirstOrDefault(x => x.Id == id);
    }

    public List<Flashcard> GetFlashcardsForTopic(string topicId)
    {
        return Flashcards
            .Where(x => x.TopicId == topicId)
            .ToList();
    }

    public List<QuizQuestion> GetQuizForTopic(string topicId)
    {
        return QuizQuestions
            .Where(x => x.TopicId == topicId)
            .ToList();
    }
}