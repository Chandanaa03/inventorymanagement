using System;
namespace InventoryDataManagementDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:/addressbook/InventoryDataManagementDemo/InventoryDataManagementDemo/demo.json";
             fetchdataforrice Fetchdataforrice = new fetchdataforrice();
            Rice data = Fetchdataforrice.Read(path);

            for (int i = 0; i < data.typesOfRice.Count; i++)
            {
                Console.WriteLine(data.typesOfRice[i].Name);
                Console.WriteLine(data.typesOfRice[i].weight);
                Console.WriteLine(data.typesOfRice[i].Price);
                int value = data.typesOfRice[i].weight * data.typesOfRice[i].Price;

                Console.WriteLine("The value of " + data.typesOfRice[i].Name + "Rice inventory" + value);
                Console.WriteLine();
            } 
                Console.WriteLine("---------------------");

                for (int i=0; i < data.typesOfGrains.Count; i++)
                {
                    Console.WriteLine(data.typesOfGrains[i].Name);
                    Console.WriteLine(data.typesOfGrains[i].weight);
                    Console.WriteLine(data.typesOfGrains[i].Price);
                int value = data.typesOfGrains[i].weight * data.typesOfGrains[i].Price;

                Console.WriteLine("The value of "+ data.typesOfGrains[i].Name+ "grain inventory" + value);
                Console.WriteLine();
            }
            Console.WriteLine("---------------------");

            for (int i = 0; i < data.typesOfwheats.Count; i++)
            {
                Console.WriteLine(data.typesOfwheats[i].Name);
                Console.WriteLine(data.typesOfwheats[i].weight);
                Console.WriteLine(data.typesOfwheats[i].Price);
                int value = data.typesOfGrains[i].weight * data.typesOfGrains[i].Price;

                Console.WriteLine("The value of " + data.typesOfwheats[i].Name + "wheat inventory" + value);
                Console.WriteLine();
            }


            //Console.WriteLine(data.Name);
            //Console.WriteLine(data.weight);
            //Console.WriteLine(data.Price);

        }
    }
}