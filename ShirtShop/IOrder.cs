namespace ShirtShop
{
    public interface IOrder
    {
        string List { get; set; }
        int OrderNumber { get; set; }
        int PriceSum { get; set; }

        void AddProduct();
        void RemoveProduct();
        string SendEmail();
    }
}