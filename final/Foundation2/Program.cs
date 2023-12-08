using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order();
        Order order2 = new Order();
        order1.SetCustomerName("Charlie");
        order1.SetCustomerAddress("30 King Edward","Kinsington","Johannesburg", "South Africa");

        order2.SetCustomerName("Bob");
        order2.SetCustomerAddress("2900 E Desert Inn Rd Suite #102","Las Vegas", "NV 89121","USA");

        order1.AddProduct("Ground Beef",50001, 76.99, 1);
        order1.AddProduct("Frozen Chicken Gizzards", 1161, 30.99, 2);
        order1.AddProduct("Bulk Grabouw Wors", 88888, 79.99, 2);

        order2.AddProduct("Bulk Country Classic Boerewors",1000, 94.99, 2);
        order2.AddProduct("Pangasius Fish Fillets", 8000, 69.99, 2);
        order2.AddProduct("Farmhouse Ice Cream", 00011110, 44.99, 1);

        order1.GetPackingLabel();
        order1.GetShippingLabel();
        order1.GetOrderTotal();
        Console.WriteLine("--------------------------------------------------\n");
        order2.GetPackingLabel();
        order2.GetShippingLabel();
        order2.GetOrderTotal();

    }
}