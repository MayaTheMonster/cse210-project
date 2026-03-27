using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orderer = new List<Order>();

        Order one = new Order("Neuro");
        one.GetOrderDetails("US-93","Nothing","Arizona","US");
        one.GetOrderProducts("Toilet",04,9997.33,78);
        one.GetOrderProducts("Mug",03,10.09,103);
        one.GetOrderProducts("Karaoke CD",02,3.01,300);
        one.GetOrderProducts("Limited edition plushie",01,60,8);
        orderer.Add(one);
        Order two = new Order("ManOfTheHole");
        two.GetOrderDetails("Tanaru River","Tanaru Indigenous Territory","Rondônia","Brazil");
        two.GetOrderProducts("Tree bark",38,0.99,7);
        two.GetOrderProducts("Pre-placed campfire",70,30.00,1);
        two.GetOrderProducts("Coconut tree",99,12,4);
        orderer.Add(two);
        Order three = new Order("MR.BUSINESSMAN");
        three.GetOrderDetails("Terry Ave N","Seattle","Washington","EUA");
        three.GetOrderProducts("Eye Phone schematics",1001,10004,1);
        three.GetOrderProducts("Moving truck",102,2034.13,3);
        three.GetOrderProducts("Expensive Lawyer",2016,3333.33,10);
        orderer.Add(three);

        foreach (Order order in orderer)
        {
            order.ReturnShippingLabel();
            order.ReturnPackingLabel();
            order.CheckoutGroceries();
        }

    }
}