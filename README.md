As you will see in my current solution, I have:
- a shell for the API in `OrderApi/Controllers/OrderController.cs`
- a service in `OrderApi/Services/OrderService.cs` that would hold any and all business logic regarding orders.
- a repository in `OrderApi/Repositories/OrderRepository.cs` that simply maintains a list of orders added in-memory.
    - this is obviously not a production solution
- a test that:
    - creates an instance of an Order
    - `Create`s the order via the `OrderApi/Services/OrderService.cs`
    - Asserts that the `List` function returns a list containing the previously `Create`d `Order`.
- My next steps would be:
    - use the built-in dependency injection tools to inject a repository into the service and a service into the controller
    - create a higher level test that exercises the controller's code as well
    - rinse/repeat for other actions
    - create a repository interface
    - adjust service constructor to accept anything that implements the repository interface
    - implement that interface with a repository that actually stores the data in a database
    - consider the testing tools for c# and possibly adjust the service tests to simply ensure that they apply the business logic and then delegate to the repository for data storage (likely through some sort of test double).
        - Python's Django uses a test database that makes the test double unnecessary. If c# has something similar then the test double is not necessary, but if it takes too long or is too flakey to do something similar then I would introduce a test double.
        - I like to exercise as much code as possible (to be as close to production as possible) in my tests which is why I prefer to avoid test doubles, but if exercising all codes takes too long or is too flakey to be reliable then I'm happy to introduce the test double.
    - I assume that I can use some sort of user identity middleware to authenticate and authorize as needed. This would allow my `List` controller action to only return orders for the authenticated customer.
- I have proposed a normalized data model to make updates easy and save storage space. We can always denormalize later if necessary, for example, if joins are taking too long and introducing latency issues.
    - The first things that would need created are customer and product models. Without them we cannot create orders.
    - Customers have the following fields:
        - first name
        - last name
        - age
        - phone
        - address id (foreign key reference to an address table -- an argument could be made to flatten this on the customer directly)
    - Addresses have the following fields:
        - street
        - city
        - state
        - zip
    - Products have the following fields:
        - name
        - description
        - quantity available
        - price
    - Order has the following fields:
        - customer (foreign key reference to customer table)
        - status (open, fulfilled, cancelled)
    - Finally, we have an OrderProduct table to handle the many-to-many relationship
        - order id
        - product id
        - quantity (need to know how many the customer wants)
    
