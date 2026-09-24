using System.Text.Json;
using Microsoft.JSInterop;
using Miku_Teaches_IR.Models;

namespace Miku_Teaches_IR.Services;

public class ProgressService
{
    private readonly IJSRuntime _js;

    private const string StorageKey = "ir-study-progress";

    public StudyProgress Progress { get; private set; } = new();

    public ProgressService(IJSRuntime js)
    {
        _js = js;
    }

    public async Task LoadAsync()
    {
        var json = await _js.InvokeAsync<string?>(
            "irStudy.load",
            StorageKey);

        if (!string.IsNullOrWhiteSpace(json))
        {
            Progress =
                JsonSerializer.Deserialize<StudyProgress>(json)
                ?? new StudyProgress();
        }
    }

    public async Task SaveAsync()
    {
        var json = JsonSerializer.Serialize(Progress);

        await _js.InvokeVoidAsync(
            "irStudy.save",
            StorageKey,
            json);
    }

    public async Task AddXP(int amount)
    {
        Progress.XP += amount;
        await SaveAsync();
    }

    public async Task RecordAnswer(bool correct)
    {
        Progress.QuestionsAnswered++;

        if (correct)
        {
            Progress.CorrectAnswers++;
            Progress.XP += 10;
        }

        await SaveAsync();
    }

    public async Task MarkFlashcardReviewed(int id)
    {
        Progress.ReviewedFlashcards.Add(id);
        await SaveAsync();
    }

    public async Task AddToReview(int id)
    {
        Progress.ReviewAgain.Add(id);
        await SaveAsync();
    }

    public async Task RemoveFromReview(int id)
    {
        Progress.ReviewAgain.Remove(id);
        await SaveAsync();
    }

    public double Accuracy
    {
        get
        {
            if (Progress.QuestionsAnswered == 0)
                return 0;

            return
                (double)Progress.CorrectAnswers /
                Progress.QuestionsAnswered *
                100;
        }
    }
}