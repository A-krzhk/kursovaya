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
        // ID идентификатор - я предполагаю, что он понадобится для выстраивания зависимостей
        int id;

        //Название задачи 
        string name = "";
        public string Name
        {
            get => name; set => name = value;
        }

        //Время выполнения задачи 
        int time;
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
        List<int> dependenciesID; 
        public void AddDepends(List<int> dependIDs)
        {
            for (int i = 0; i < 0; i++)
            {
                dependenciesID.Add(dependIDs[i]);
            }
        }

        // Конструкторы:
        public Task (string name, int time, List<int> depends)
        {
            id = (new Id()).GenerateID();
            Name = name;
            Time = time;
            AddDepends(depends);
        }
    }
}
