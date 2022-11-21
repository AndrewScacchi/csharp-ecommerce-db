//class Order
public class Order
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public int Amount { get; set; }
    public bool Status { get; set; }

    //relation 1 to many with Customer
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }

    //relation 1 to many with Employee
    public int EmployeeId { get; set; }
    public Employee Employee { get; set; }

    //relation 1 to many with Payments
    public List<Payment> Payments { get; set; }

    //relation 1 to many with Products
    public List<Product> Products { get; set; }
}