namespace ConsoleApp11
{
    public static class Extension
    {
        public static void GetAnimals(this Animal[] animals)
        {
            foreach (var item in animals)
            {
                if (item is Eagle)
                {
                    Eagle eagle = (Eagle)item;
                    if (eagle.Age > 25) Console.WriteLine($"Eagle age : {eagle.Age}");
                    else Console.WriteLine("25 den asagidir");
                }
                else if (item is Snake)
                {
                    Snake snake = (Snake)item;
                    if (snake.Length > 20) Console.WriteLine($"Snake length : {snake.Length}");
                    else Console.WriteLine("20 den asagidir");
                }
            }
        }
    }
}
