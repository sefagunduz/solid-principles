namespace solid_principles.SingleResposibility.Bad
{
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
}
