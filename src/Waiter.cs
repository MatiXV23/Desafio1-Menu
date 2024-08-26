using System.Collections;

namespace Ucu.Poo.Restaurant;

/// <summary>
/// Representa un mozo en el restaurante, encargado de atender mesas.
/// </summary>
public class Waiter
{
    private ArrayList assignedTables = new ArrayList();

    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public void AssignTable(Table NTable)
    {
        this.assignedTables.Add(NTable);
    }

    public void TakeOrder(Table NTable, Dish Order)
    {
        NTable.AddToOrder(Order);
    }
}