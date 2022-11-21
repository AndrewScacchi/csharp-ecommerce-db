//class Product
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public float Price { get; set; }

    //relation 1 to many with Order
    public List<Order> Orders { get; set; }
}

