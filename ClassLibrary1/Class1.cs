using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public class Pair
    {
        public int First { get; set; }
        public int Second { get; set; }
        public Pair()
        {
            First = 10;
            Second = -10;
        }
        /// <summary>
        /// Присваивает значения соответствующим переменным
        /// </summary>
        /// <param name="first">int first</param>
        /// <param name="second">int second</param>
        public Pair(int first, int second)
        {
            First = first;
            Second = second;
        }
        /// <summary>
        /// Сравнивает первую пару чисел со второй
        /// </summary>
        /// <param name="pair">Pair pair</param>
        /// <returns></returns>
        public bool IsBigger(Pair pair)
        {
            if (this.First >= pair.First && this.Second > pair.Second) return true;
            return false;
        }
        /// <summary>
        /// Присваивает новые значения соответствующим переменным
        /// </summary>
        /// <param name="first">int first</param>
        /// <param name="second">int second</param>
        public void SetParams(int first, int second)
        {
            First = first;
            Second = second;
        }
        /// <summary>
        /// Сравнение - больше ли первая пара чисел
        /// </summary>
        /// <param name="pair1">Pair pair1</param>
        /// <param name="pair2">Pair pair2</param>
        /// <returns></returns>
        public static bool operator >(Pair pair1, Pair pair2)
        {
            if (pair1.First >= pair2.First && pair1.Second > pair2.Second) return true;
            return false;

        }
        /// <summary>
        /// Сравнение - меньше ли первая пара чисел
        /// </summary>
        /// <param name="pair1">Pair pair1</param>
        /// <param name="pair2">Pair pair2</param>
        /// <returns></returns>
        public static bool operator <(Pair pair1, Pair pair2)
        {
            if (pair1.First < pair2.First && pair1.Second <= pair2.Second) return true;
            return false;
        }
    }
}
