namespace kurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task t = new Task();
            t.Init(t);
            Task.tasks.Add(t);

            Console.WriteLine("Все созданные задачи:");
            t.Print();
            Console.WriteLine("Зависимости текущей задачи:");
            for (int i = 0; i < t.dependenciesID.Count; i++)
            {
                Console.WriteLine(t.dependenciesID[i].Name);
            }
        }
    }
}
