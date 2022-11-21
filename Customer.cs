//status can be a boolean
public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }

    //relation 1 to many with Order
    public List<Order> Orders { get; set; }
}


