namespace Miku_Teaches_IR.Models;

public class StudyTopic
{
    public string Id { get; set; } = "";
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";

    public string Actor { get; set; } = "";
    public string Objective { get; set; } = "";
    public string Method { get; set; } = "";

    public List<string> KeyIdeas { get; set; } = new();
    public List<string> Criticisms { get; set; } = new();
}