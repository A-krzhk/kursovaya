using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// В этом классе должны создаваться задачи для планировщика,
// у каждой задачи должен быть массив зависимостей + ID, это будет использоваться для создания самого дерева,
// все остальное - возможно пригодится/возможно добавится или перепишется в дальнейшем
namespace kurs
{
    public class Task
    {
        static List<Task> tasks; // 
        // ID идентификатор - я предполагаю, что он понадобится для выстраивания зависимостей
        int id;

        //Название задачи 
        string name = "";
        public string Name
        {
            get => name; set => name = value;
        }

        //Время выполнения задачи 
        int time = 0;
        public int Time
        {
            get => time; 
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                time = value;
            }
        }

        //Описание задачи 
        //пока что п+п, к логике слабо относится
       
        
        // От чего задача зависит 
        List<Task> dependenciesID; 
        //найти сущетвует ли задача с таким названием 
        // если нет вызвать new Task()
        public void AddDepends(List<Task> dependIDs)
        {
            for (int i = 0; i < dependIDs.Count; i++)
            {
                if (!tasks.Contains(dependIDs[i]))
                {
                    // Надо сказать пользователю создать новый элемент 
                    // НАДО ИСПРАВИТЬ CW
                    Console.WriteLine("Сперва создайте эл");
                    

                    
                    Task newTask = new Task();
                }
                else
                {
                    dependenciesID.Add(dependIDs[i]);
                }
            }
            
        }

        public void Init(Task task)
        {
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите время");
            int time = Int32.Parse(Console.ReadLine());


            while (true)
            {
                string choice = Console.ReadLine();
                switch (choice) {
                    case "1":
                        Console.WriteLine("Введите номер задачи, которую хотите добавить в зависимости");
                        Print();
                        int pos = Int32.Parse(Console.ReadLine());
                        dependenciesID.Add(tasks[pos-1]);
                        break;
                    case "2":
                        Task Added = new Task();
                        Init(Added);
                        break;
                    case "3":
                        return;

                }
            } 
        }

        public void Print()
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i+1} {tasks[i].Name}");
            }
        }

        // Конструктор:
        public Task ()
        {
            id = (new Id()).GenerateID();
            tasks.Add(this);
        }
    }
}
