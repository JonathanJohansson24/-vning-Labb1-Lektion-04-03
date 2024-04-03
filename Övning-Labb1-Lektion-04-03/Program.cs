namespace Övning_Labb1_Lektion_04_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BoxCollection boxList = new BoxCollection();

            boxList.Add(new Box(10, 10, 10));
            boxList.Add(new Box(15, 15, 15));
            boxList.Add(new Box(20, 20, 20));
            boxList.Add(new Box(25, 25, 25));
            boxList.Add(new Box(30, 30, 30));
            Display(boxList);
            boxList.Remove(new Box(10, 10, 10));
            Display(boxList);

            Box boxToCheck = new Box(20, 20, 20);
            Console.WriteLine(@$"
The box of Width: {boxToCheck.Width} 
The height of: {boxToCheck.Height} 
The length of: {boxToCheck.Length}
The volume of: {boxToCheck.Volume} 
Contains in the list: {boxList.Contains(boxToCheck)}");
        }
        public static void Display(BoxCollection boxes)
        {
            Console.WriteLine($"      Length     Height      Width       Volume");

            foreach (Box boxbox in boxes)
            {
                Console.WriteLine($"        {boxbox.Length}         {boxbox.Height}         {boxbox.Width}          {boxbox.Volume}");
            }
            Console.WriteLine($"    Size of list {boxes.Count}");
        }
    }
}
