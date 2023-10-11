namespace OrderApi.Models;

public class OrderProduct
{
  public string? Id { get; set; }

  public string? OrderId { get; set; }

  public string? ProductId { get; set; }

  public int? Quantity { get; set; }
}

