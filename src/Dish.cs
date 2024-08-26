namespace Ucu.Poo.Restaurant;

/// <summary>
/// Representa un platillo individual en el menú del restaurante.
/// </summary>
public class Dish
{
    private string name;
    public string Name
    {
        get{return name;} 
        set { name = value; }
    }

    private int price;

    public int Price
    {
        get { return price; }
        set { price = value; }
    }

    private bool isVegetarian;

    public bool IsVegetarian
    {
        get { return isVegetarian; }
        set { isVegetarian = value; }
    }
}