# Single Responsibility
The single-responsibility principle: "There should never be more than one reason for a class to change." In other words, every class should have only one responsibility.

## Bad

```cs

    public class Order
    {
        public int OrderId { get; set; }
        public decimal TotalPrice { get; set; }
        public int BuyerId { get; set; }

        public void CreateNewOrder(Order order)
        {
            // create new order
        } 

        public void SaveCutomerToDatabase(Order order)
        {
            // save customer to database
        }
    }

```


## Good

```cs

    public class Order
    {
        public int OrderId { get; set; }
        public decimal TotalPrice { get; set; }
        public int BuyerId { get; set; }
    }

    public class OrderManager
    {
        public void CreateNewOrder(Order order)
        {
            // create new order
        }
    }

    public class Repository
    {
        public void SaveCutomerToDatabase(Order order)
        {
            // save customer to database
        }
    }

```