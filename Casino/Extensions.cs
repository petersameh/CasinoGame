using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Casino
{
    public static class Extensions
    {
        public static List<T> Shuffle<T>(this List<T> original)
        {
            Random rand = new Random();
            List<T> lst = new List<T>(original);
            for (int i = lst.Count - 1; i >= 1; i--)
            {
                int j = rand.Next(0, i + 1);
                T tmp = lst[j];
                lst[j] = lst[i];
                lst[i] = tmp;
            }
            return lst;
        }
    }
}
