namespace OrderApi.Models;

public class Customer
{
  public string? Id { get; set; }

  public string? FirstName { get; set; }

  public string? LastName { get; set; }

  public byte? Age { get; set; }

  public string? Phone { get; set; }

  // TODO: foreign key relationship
  public string? AddressId { get; set; }
}
