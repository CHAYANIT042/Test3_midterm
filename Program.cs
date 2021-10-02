using System;
using System.Collections.Generic;

namespace FlowersStore
{
    class Program
    {
        static void Main(string[] args)
        {
            string decide = "y";
            string selectFlower;
            FlowerStore flowerStore = new FlowerStore();
            do
            {
                Console.WriteLine("Select number for buy flower :");
                flowerStore.ShowFlowers();
                selectFlower = Console.ReadLine();
                flowerStore.FlowerCheck(selectFlower);

                Console.WriteLine("You can stop this progress ? exit for >> exit << progress and pressany key for continue");
                decide = Console.ReadLine();
                if (decide == "exit")
                {
                    Console.Write("Current my cart");
                    flowerStore.showCart();
                }
            }
            while (decide != "exit");
        }
    }

    class FlowerStore
    {
        public List<string> flowerList = new List<string>();
        List<string> cart = new List<string>();
        public FlowerStore()
        {
            flowerList.Add("Rose");
            flowerList.Add("Lotus");
        }
        public void addToCart(string name)
        {
            cart.Add(name);
        }

        public void showCart()
        {
            if (cart.Count == 0)
            {
                Console.WriteLine("Cart is empty");
            }
            else
            {
                Console.WriteLine("My Cart :");
                foreach (string i in cart)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void FlowerCheck(string selectFlower)
        {
            switch (selectFlower)
            {
                case "1":
                    addToCart(flowerList[0]);
                    Console.WriteLine("Added " + flowerList[0]);
                    break;
                case "2":
                    addToCart(flowerList[1]);
                    Console.WriteLine("Added " + flowerList[1]);
                    break;
                default:
                    Console.WriteLine("Not Added to cart. found select number of flower");
                    break;
            }
        }

        public void ShowFlowers()
        {
            foreach (string i in flowerList)
            {
                Console.Write((flowerList.IndexOf(i) + 1) + " ");
                Console.WriteLine(i);
            }
        }
    }
}
