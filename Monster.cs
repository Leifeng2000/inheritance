using System.Diagnostics.Contracts;

public class Monster:Enemy
{
    int valueTemp=3;
    public Monster(int attack, int health) : base(attack, health)
    {
        
    }
    public Monster(string a, string b, string c) : base(a,b,c)
    {
        
    }
    public override void SetColor()
    {
        base.SetColor();
        Console.WriteLine("Gia tri nay la mau mac dinh",valueTemp.ToString());
    }
}