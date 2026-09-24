namespace Miku_Teaches_IR.Models;

public class BattleScenario
{
    public int Id { get; set; }

    public string Scenario { get; set; } = "";

    public List<string> Choices { get; set; } = new();

    public int CorrectChoice { get; set; }

    public string Explanation { get; set; } = "";
}