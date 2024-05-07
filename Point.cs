using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurs
{
    public class Point<T>
    {
        public T? Data { get; set; }
        public Point<T>? Previous { get; set; }

        public Point()
        {
            this.Data = default(T); // для присвоения ссылочным типам null, а типам значений 0
            this.Previous = null;
        }

        public Point(T data)
        {
            this.Data = data;
            this.Previous = null;
        }

        public override string? ToString()
        {
            return Data == null ? "" : Data.ToString();
        }

        public override int GetHashCode()
        {
            return Data == null ? 0 : Data.GetHashCode();
        }
    }
}
