namespace ZooManagementApp.Domain.Abstractions;

public abstract class Herbo: Animal
{
    public int KindnessLevel { get; }
    public bool IsContactZooable  => KindnessLevel > 5;
    
    protected Herbo(int food, int number, string name, int kindnessLevel) : base(food, number, name)
    {
        KindnessLevel = kindnessLevel;
    }
}