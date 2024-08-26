namespace Ucu.Poo.Restaurant;

using System.Collections;

/// <summary>
/// Representa una mesa en el restaurante.
/// </summary>
public class Table
{
    private ArrayList order = new ArrayList();
    
    private int number;
    public int Number
    {
        get { return number; }
        set { number = value; }
    }
    
    private bool isOccupied;
    public bool IsOccupied
    {
        get { return isOccupied; }
        set { isOccupied = value; }
    }

    public Table(int number)
    {
        Number = number;
    }
    
    public void Occupy()
    {
        isOccupied = true;
    }

    public void Free()
    {
        IsOccupied = false;
        order.Clear();
    }

    public void AddToOrder(Dish dish)
    {
        order.Add(dish);
    }
    
    public bool HasOrders()
    {
        return order.Count > 0;
    }
}