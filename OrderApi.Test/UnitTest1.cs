using Xunit;
using OrderApi.Repositories;
using OrderApi.Services;
using OrderApi.Models;

namespace OrderApi.Test;
public class OrderServiceTest
{
    [Fact]
    public void TestCreate()
    {
        // arrange
        var order = new Order()
        {
            Id = "order-id",
            Status = OrderStatus.Open,
            CustomerId = "customer-id",
            OrderProducts = new OrderProduct[]{
                new OrderProduct() { OrderId = "order-id", ProductId = "product-id-1", Quantity = 1 },
                new OrderProduct() { OrderId = "order-id", ProductId = "product-id-2", Quantity = 2 },
                new OrderProduct() { OrderId = "order-id", ProductId = "product-id-3", Quantity = 3 },
            },
        };
        var orderService = new OrderService(new OrderRepository());

        // act
        var createdOrder = orderService.Create(order);
        Assert.Equal(order, createdOrder);


        // assert
        var allOrders = orderService.List();
        Assert.Contains(order, allOrders);
    }
}
