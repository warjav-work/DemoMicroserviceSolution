namespace BlazorServerWebUI.Models
{
    public class OrderViewModel
    {
        public string OrderId { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderedOn { get; set; }
        public List<OrderDetailViewModel> OrderDetails { get; set; }
    }

}
