using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
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
        public static string GetEnumDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes = fi.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

            if (attributes != null && attributes.Any())
            {
                return attributes.First().Description;
            }

            return value.ToString();
        }
    }
}
