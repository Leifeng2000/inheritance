public class Enemy
{
    private string myColor="";
    protected string a="";
    protected string b="";
    protected string c="";
    public int attack=0;
    public int health=100;
    public Enemy(int attack, int health)
    {
        this.attack=attack;
        this.health=health;
    }
    public Enemy(string a, string b, string c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }
    public virtual void SetColor()
    {
        myColor="Yellow";
    }
}