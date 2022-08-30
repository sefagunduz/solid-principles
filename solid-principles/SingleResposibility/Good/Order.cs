namespace solid_principles.SingleResposibility.Good
{
    public class Order
    {
        public int OrderId { get; set; }
        public decimal TotalPrice { get; set; }
        public int BuyerId { get; set; }
    }
}
