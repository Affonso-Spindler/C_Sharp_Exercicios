using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroCliente.Extensions
{
    public static class ControlsEx
    {
        #region GetValue

        public static T GetValue<T>(this TextBox value, IFormatProvider provider = null)
        {
            return Utils.GetValue<T>(value.Text, provider);
        }

        public static T GetValue<T>(this ComboBox value, IFormatProvider provider = null)
        {
            return Utils.GetValue<T>(value.SelectedValue, provider);
        }

        public static T GetValue<T>(this CheckBox value, IFormatProvider provider = null)
        {
            return Utils.GetValue<T>(value.Checked, provider);
        }

        public static T GetValue<T>(this MaskedTextBox value, bool clipText = true, IFormatProvider provider = null)
        {
            return Utils.GetValue<T>(clipText ? value.ClipText() : value.Text, provider);
        }

        public static T GetValue<T>(this Label value, IFormatProvider provider = null)
        {
            return Utils.GetValue<T>(value.Text, provider);
        }

        public static T GetValue<T>(this RichTextBox value, IFormatProvider provider = null)
        {
            return Utils.GetValue<T>(value.Text, provider);
        }

        public static T GetValue<T>(this Form value, IFormatProvider provider = null)
        {
            return Utils.GetValue<T>(value.Tag, provider);
        }

        #endregion

        #region SetValue

        public static void SetValue(this TextBox obj, object value, IFormatProvider provider = null)
        {
            obj.Text = Utils.GetValue<string>(value, provider);
        }

        public static void SetValue<T>(this ComboBox obj, object value, IFormatProvider provider = null)
        {
            obj.SelectedValue = Utils.GetValue<T>(value, provider);
        }

        public static void SetValue(this CheckBox obj, object value, IFormatProvider provider = null)
        {
            obj.Checked = Utils.GetValue<bool>(value, provider);
        }

        public static void SetValue(this MaskedTextBox obj, object value, IFormatProvider provider = null)
        {
            obj.Text = Utils.GetValue<string>(value, provider);
        }

        public static void SetValue(this Label obj, object value, IFormatProvider provider = null)
        {
            obj.Text = Utils.GetValue<string>(value, provider);
        }

        public static void SetValue(this RichTextBox obj, object value, IFormatProvider provider = null)
        {
            obj.Text = Utils.GetValue<string>(value, provider);
        }

        public static void SetValue(this Form obj, object value)
        {
            obj.Tag = value;
        }

        #endregion

        #region IsEmpty

        public static bool IsEmpty(this TextBox value)
        {
            return string.IsNullOrEmpty(value.Text);
        }

        public static bool IsEmpty(this MaskedTextBox value)
        {
            return string.IsNullOrEmpty(value.ClipText());
        }

        public static bool IsEmpty(this ComboBox value)
        {
            return value.SelectedIndex == -1;
        }

        #endregion

        #region ClearFields

        public static void ClearFields(this Form value)
        {
            foreach (Control ctrl in value.Controls)
            {
                ctrl.ClearFields();

                (ctrl as TextBox)?.SetValue(null);
                //(ctrl as TextBoxCustom)?.SetValue(null);
                (ctrl as ComboBox)?.SelectIndex(-1);
                (ctrl as CheckBox)?.SetValue(null);
                (ctrl as MaskedTextBox)?.SetValue(null);
                (ctrl as RichTextBox)?.SetValue(null);
            }
        }

        public static void ClearFields(this Control value)
        {
            foreach (Control ctrl in value.Controls)
            {
                ctrl.ClearFields();

                (ctrl as TextBox)?.SetValue(null);
                //(ctrl as TextBoxCustom)?.SetValue(null);
                (ctrl as ComboBox)?.SelectIndex(-1);
                (ctrl as CheckBox)?.SetValue(null);
                (ctrl as MaskedTextBox)?.SetValue(null);
                (ctrl as RichTextBox)?.SetValue(null);
            }
        }

        #endregion
    }
}
