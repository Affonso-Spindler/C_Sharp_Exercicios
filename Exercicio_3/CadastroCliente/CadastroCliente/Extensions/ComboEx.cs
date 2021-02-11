using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ComboBox;

namespace CadastroCliente.Extensions
{
    public static class ComboEx
    {
        public static T SelectedItem<T>(this ComboBox value)
        {
            return (T)value.SelectedItem;
        }

        public static T SelectedValue<T>(this ComboBox value)
        {
            return (T)value.SelectedValue;
        }

        public static void SelectIndex(this ComboBox value, int index)
        {
            value.SelectedIndex = index;
        }

        public static void AddRange(this ObjectCollection value, int[] sizes)
        {
            foreach (int size in sizes)
            {
                value.Add(size);
            }
        }
    }
}
