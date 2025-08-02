using System.Collections.Generic;

[System.Serializable]
public class Enemy
{
    public string name;
    public float damage;
    public float health;
    public string type;
    public string weapon = "empty";

    public Enemy()
    {

    }

    public Enemy(string name, string type, float health, float damage)
    {
        this.name = name;
        this.type = type;
        this.health = health;
        this.damage = damage;
    }
}

[System.Serializable]
public class Enemies
{
    public List<Enemy> enemies = new List<Enemy>();
}

