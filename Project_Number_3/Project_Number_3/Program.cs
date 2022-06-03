using System;
using System.IO;

namespace Project_Number_3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // Правия инстанция от StereamReader зада прочета съответния файл 
            StreamReader reader = new StreamReader("Clients.txt");

            //Прочитам първия ред от текстовия файл
            string line = reader.ReadLine();

            //Прочитам останалите редове от текстовия файл
            while (line != null)
            {
                Console.WriteLine(line);
                line = reader.ReadLine();
            }
            reader.Close();


            ////Fruits

            ////Apples input
            //Console.WriteLine();
            //Console.WriteLine("Enter the quantity apples that the client bought");
            //double quantityApples = double.Parse(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine("Enter apples wholesalePrice price for 1kg");
            //double wholesalePriceApples = double.Parse(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine("Enter apples retailPrice price for 1kg");
            //double retailPriceApples = double.Parse(Console.ReadLine());

            ////Oranges input
            //Console.WriteLine();
            //Console.WriteLine("Enter the oranges quantity that the client bought");
            //double quantityOranges = double.Parse(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine("Enter oranges wholesalePrice price for 1kg");
            //double wholesalePriceOranges = double.Parse(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine("Enter oranges retailPrice price for 1kg");
            //double retailPriceOranges = double.Parse(Console.ReadLine());

            ////Bananas input
            //Console.WriteLine();
            //Console.WriteLine("Enter bananas the quantity that the client bought");
            //double quantityBananas = double.Parse(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine("Enter bananas wholesalePrice price for 1kg");
            //double wholesalePriceBananas = double.Parse(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine("Enter bananas retailPrice price for 1kg");
            //double retailPriceBananas = double.Parse(Console.ReadLine());

            ////Cheries input
            //Console.WriteLine();
            //Console.WriteLine("Enter the cheries quantity that the client bought");
            //double quantityCheries = double.Parse(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine("Enter cheries wholesalePrice for 1kg");
            //double wholesalePriceCheries=double.Parse(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine("Enter cheries retailPrice price for 1kg");
            //double retailPriceCheries = double.Parse(Console.ReadLine());

            ////Plums input
            //Console.WriteLine();
            //Console.WriteLine("Enter the plums quantity that the client bought");
            //double quantityPlums = double.Parse(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine("Enter plums wholesalePrice price for 1kg");
            //double wholesalePricePlums = double.Parse(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine("Enter  retailPrice price for 1kg");
            //double retailPricePlums = double.Parse(Console.ReadLine());


            ////Veggies

            ////Peppers input
            //Console.WriteLine();
            //Console.WriteLine("Enter the peppers quantity that the client bought");
            //double quantityPeppers = double.Parse(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine("Enter peppers wholesalePrice price for 1kg");
            //double wholesalePricePeppers = double.Parse(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine("Enter peppers retailPrice price for 1kg");
            //double retailPricePepers = double.Parse(Console.ReadLine());

            ////Cucumbers input
            //Console.WriteLine();
            //Console.WriteLine("Enter the cucumbers quantity that the client bought");
            //double quantityCucumbers = double.Parse(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine("Enter cucumbers wholesalePrice price for 1kg");
            //double wholesalePriceCucumbers = double.Parse(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine("Enter cucumbers retailPrice price for 1kg");
            //double retailPriceCucumbers = double.Parse(Console.ReadLine());

            ////Cabbages input
            //Console.WriteLine();
            //Console.WriteLine("Enter the cabbage quantity that the client bought");
            //double quantityCabbage = double.Parse(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine("Enter cabbage wholesalePrice price for 1kg");
            //double wholesalePriceCabbages = double.Parse(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine("Enter cabbage retailPrice price for 1kg");
            //double retailPriceCabages = double.Parse(Console.ReadLine());

            ////Potatoes input
            //Console.WriteLine();
            //Console.WriteLine("Enter the potatoes quantity that the client bought");
            //double quantityPotatoes = double.Parse(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine("Enter potatoes wholesalePrice price for 1kg");
            //double wholesalePricePotatoes = double.Parse(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine("Enter potatoes retailPrice price for 1kg");
            //double retailPricePotatoes = double.Parse(Console.ReadLine());

            ////Tomatoes input
            //Console.WriteLine();
            //Console.WriteLine("Enter the tomatoes quantity that the client bought");
            //double quantityTomatoes = double.Parse(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Enter tomatoes wholesalePrice price for 1kg");
            //double wholesalePriceTomatoes = double.Parse(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine("Enter tomatoes retailPrice price for 1kg");
            //double retailPriceTomatoes = double.Parse(Console.ReadLine());


            //Fruits Apples = new Fruits("Apples" ,quantityApples ,wholesalePriceApples,retailPriceApples);
            //Fruits Oranges = new Fruits("Oranges" ,quantityOranges,wholesalePriceOranges ,retailPriceOranges);
            //Fruits Bananas = new Fruits("Bananas" ,quantityBananas ,wholesalePriceBananas ,retailPriceBananas);
            //Fruits Cherries = new Fruits("Cheries" ,quantityCheries ,wholesalePriceCheries ,retailPriceCheries);
            //Fruits Plums = new Fruits("Plums" ,quantityPlums ,wholesalePricePlums ,retailPricePlums);

            //Vegetables Peppers = new Vegetables("Peppers" ,quantityPeppers ,wholesalePricePeppers ,retailPricePepers);
            //Vegetables Cucumbers = new Vegetables("Cucumbers",quantityCucumbers ,wholesalePriceCucumbers ,retailPriceCucumbers);
            //Vegetables Cabbages = new Vegetables("Cabbages", quantityCabbage ,wholesalePriceCabbages ,retailPriceCabages);
            //Vegetables Potatoes = new Vegetables("Potatoes" ,quantityPotatoes ,wholesalePricePotatoes ,retailPricePotatoes);
            //Vegetables Tomatoes = new Vegetables("Tomatoes" ,quantityTomatoes ,wholesalePriceTomatoes ,retailPriceTomatoes);
           
            // Fruits Client_1_JohnC = new Fruits(Console.ReadLine(),double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));

            // Fruits Client_1_JohnA = new Fruits(Console.ReadLine(), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            Console.WriteLine();

            //Client 1
            Console.WriteLine();
            Console.WriteLine("Enter a number of fruit that Client_1 bought");
            int Client_01Fruits=int.Parse(Console.ReadLine());
            
            for (int i=1;i<=Client_01Fruits;i++) 
            { 
                
                Console.WriteLine("Enter the name of Fruit ,the quantity ,wholesale price and retail price");
                Fruits Client_1_John = new Fruits(Console.ReadLine(), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                Console.WriteLine();
            }

            //Client 2
            Console.WriteLine();
            Console.WriteLine("Enter a number of fruit that Client_1 bought");
            int Client_02Fruits = int.Parse(Console.ReadLine());

            for (int i = 1; i <= Client_01Fruits; i++)
            {

                Console.WriteLine("Enter the name of Fruit ,the quantity ,wholesale price and retail price");
                Fruits Client_2_John = new Fruits(Console.ReadLine(), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                Console.WriteLine();
            }
            

            //Client 3
            Console.WriteLine();
            Console.WriteLine("Enter a number of fruit that Client_1 bought");
            int Client_03Fruits = int.Parse(Console.ReadLine());

            for (int i = 1; i <= Client_01Fruits; i++)
            {

                Console.WriteLine("Enter the name of Fruit ,the quantity ,wholesale price and retail price");
                Fruits Client_3_John = new Fruits(Console.ReadLine(), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                Console.WriteLine();
            }

            //Client 4
            Console.WriteLine();
            Console.WriteLine("Enter a number of fruit that Client_1 bought");
            int Client_04Fruits = int.Parse(Console.ReadLine());

            for (int i = 1; i <= Client_01Fruits; i++)
            {

                Console.WriteLine("Enter the name of Fruit ,the quantity ,wholesale price and retail price");
                Fruits Client_4_John = new Fruits(Console.ReadLine(), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                Console.WriteLine();
            }

            //Client 5
            Console.WriteLine();
            Console.WriteLine("Enter a number of fruit that Client_1 bought");
            int Client_05Fruits = int.Parse(Console.ReadLine());

            for (int i = 1; i <= Client_01Fruits; i++)
            {

                Console.WriteLine("Enter the name of Fruit ,the quantity ,wholesale price and retail price");
                Fruits Client_05_John = new Fruits(Console.ReadLine(), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                Console.WriteLine();
            }

            //Client 6
            Console.WriteLine();
            Console.WriteLine("Enter a number of fruit that Client_1 bought");
            int Client_06Fruits = int.Parse(Console.ReadLine());

            for (int i = 1; i <= Client_01Fruits; i++)
            {

                Console.WriteLine("Enter the name of Fruit ,the quantity ,wholesale price and retail price");
                Fruits Client_06_John = new Fruits(Console.ReadLine(), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                Console.WriteLine();
            }

            //Client 7
            Console.WriteLine();
            Console.WriteLine("Enter a number of fruit that Client_1 bought");
            int Client_07Fruits = int.Parse(Console.ReadLine());

            for (int i = 1; i <= Client_01Fruits; i++)
            {

                Console.WriteLine("Enter the name of Fruit ,the quantity ,wholesale price and retail price");
                Fruits Client_07_John = new Fruits(Console.ReadLine(), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                Console.WriteLine();
            }

            //Client 8
            Console.WriteLine();
            Console.WriteLine("Enter a number of fruit that Client_1 bought");
            int Client_08Fruits = int.Parse(Console.ReadLine());

            for (int i = 1; i <= Client_01Fruits; i++)
            {

                Console.WriteLine("Enter the name of Fruit ,the quantity ,wholesale price and retail price");
                Fruits Client_08_John = new Fruits(Console.ReadLine(), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                Console.WriteLine();
            }

            //Client 9
            Console.WriteLine();
            Console.WriteLine("Enter a number of fruit that Client_1 bought");
            int Client_09Fruits = int.Parse(Console.ReadLine());

            for (int i = 1; i <= Client_01Fruits; i++)
            {

                Console.WriteLine("Enter the name of Fruit ,the quantity ,wholesale price and retail price");
                Fruits Client_09_John = new Fruits(Console.ReadLine(), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                Console.WriteLine();
            }

            //Client 10
            Console.WriteLine();
            Console.WriteLine("Enter a number of fruit that Client_1 bought");
            int Client_10Fruits = int.Parse(Console.ReadLine());

            for (int i = 1; i <= Client_01Fruits; i++)
            {

                Console.WriteLine("Enter the name of Fruit ,the quantity ,wholesale price and retail price");
                Fruits Client_10_John = new Fruits(Console.ReadLine(), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                Console.WriteLine();
            }
            // Create a StreamWriter instance
            StreamWriter writer = new StreamWriter("Bills.txt");
            // Ensure the writer will be closed when no longer used
            using (writer)
            {
                // Loop through the numbers from 1 to 20 and write them
                //for (int i = 1; i <= 7; i++)
                //{
                //    writer.WriteLine(i);
                //}

                //Console.WriteLine();
                //writer.WriteLine("Client_1:John bought 20 kg of cherries and his bill is " + (20 * 15));
                writer.WriteLine("Client_01:_John---20kg Cheries and 1kg apples and his bill is "+(20*15)+1*2);
                writer.WriteLine("Client_02: _Carl---30kg Bananas"+(30*1.80));
                writer.WriteLine("Client_03:_Ana---40kg Tomatoes and 40kg Cucumbers"+());
                writer.WriteLine("Client_04:_Mike---20kg Cabbage and 20.500 Potatoes");
                writer.WriteLine("Client_05:_AJ---30.300kg Cucumbers,30.500 Tomatoes and 2kg Peppers");
                writer.WriteLine("Enterprise_01: Shop_1---50kg Pepers and 60kg Tomatoes");
                writer.WriteLine("Enterprise_02: Shop_2---60kg Cabbage and 70kg Cucumbers");
                writer.WriteLine("Enterprise_03: Resturant 10kg Pepers ,10kg Cucumbers,10kg Tomatoes,10kg Cabbage,10kg Potatoes,20 kg Bananas");
                writer.WriteLine("Client_06: Retail_Customer_1---1kg Plums");
                writer.WriteLine("Client_07: Retail_Customer_2---2kg Oranges");
            }

        }
    }
}
