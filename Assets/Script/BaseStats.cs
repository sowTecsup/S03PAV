using UnityEngine;

public class BaseStats 
{
    // Relación de Composición
    public int health 
    {
        get { return health; }
        set
        {
            if (value < 0)
                health = 0;
            else
                health = value;
        }
    }




    private int power;
    public int Power => power;
    public void SetPower(int power)
    {
        this.power = power; 
    }

    public int Speed;
    public int Knockback;
    public int XP;

    public BaseStats(int health , int power, int speed, int knockback , int xp)
    {
        this.health = health;
        this.power = power;
        Speed = speed;
        Knockback = knockback;
        XP = xp;
    }
   
    ~BaseStats()
    {
        Debug.Log("Eliminado por el garbage collector");
    }
}
