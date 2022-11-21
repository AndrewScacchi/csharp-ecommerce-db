//class Employee
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }

    //relation 1 to many with Order(should be payment?)
    public List<Order> Orders { get; set; }
}


