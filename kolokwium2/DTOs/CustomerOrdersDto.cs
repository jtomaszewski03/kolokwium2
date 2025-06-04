namespace kolokwium2.DTOs;

public class CustomerOrdersDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? PhoneNumber { get; set; }
    public List<PurchasesDto>? Purchases { get; set; }
}

public class PurchasesDto
{
    public DateTime Date { get; set; }
    public int Rating { get; set; }
    public decimal Price { get; set; }
    public WashingMashineDto WashingMashine { get; set; }
    public ProgramDto Program { get; set; }
}

public class WashingMashineDto
{
    public string Serial { get; set; }
    public double MaxWeight { get; set; }
}

public class ProgramDto
{
    public string Name { get; set; }
    public int Duration { get; set; }
}