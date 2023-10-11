namespace OrderApi.Models;

public class Address
{
  public string? Id { get; set; }

  public string? Street { get; set; }

  public string? City { get; set; }

  // TODO: is string best type here?
  // probably use an enum
  public State? State { get; set; }

  // TODO: is string best type here?
  public string? PostalCode { get; set; }
}

public enum State
{
  IA,
  NE,
}
