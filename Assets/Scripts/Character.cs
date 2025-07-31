[System.Serializable] // inspectorda görünmesi için
public class Character
{
    public string name = "";
    public float age = 0;
    public string weapon = "";
    public float money = 0;

    public Character() // boş şekilde tanımlama yapabilmek için 
    {

    }

    public Character(string name, float age, string weapon, float money)
    {
        this.name = name;
        this.age = age;
        this.weapon = weapon;
        this.money = money;
    }
}
