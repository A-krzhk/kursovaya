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

        // ID идентификатор - я предполагаю, что он понадобится для выстраивания зависимостей
        // НАДО БУДЕТ ДОРАБОТАТЬ, ЧТОБЫ ГАРАНТИРОВАННО ДАВАЛ УНИКАЛЬНЫЕ ЗНАЧЕНИЯ
        int number = 0;
        public int Number
        {
            get => number;
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                number = value;
            }
        }

        // От чего задача зависит 
        int[] dependencies; // Тут надо бы подумать, стоит ли использовать List<> чтобы можно было добавлять через Add, или делать все вручную через []

        // Тут должен быть метод для добавления зависимостей:
        public void AddDepends(int dependId)
        {

        }

        // Конструкторы:
    }



}
