using System.Windows.Forms;

namespace CadastroCliente.Extensions
{
    public static class MaskEx
    {
        public static string ClipText(this MaskedTextBox value)
        {
            string text = "";

            //MASKFULL - Obtém um valor que indica se todas as entradas necessárias e opcionais foram inseridas na máscara de entrada.
            if (value.MaskFull)
            {
                //TextMaskFormat - Obtém ou define um valor que determina se os literais e os caracteres de prompt são incluídos na cadeia de caracteres formatada.
                value.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals; // Retorne apenas o texto inserido pelo usuário 
                text = value.Text; //salva numa variavel
                value.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                //Retorne o texto inserido pelo usuário, bem como quaisquer caracteres definidos na máscara e quaisquer instâncias do caractere de prompt.
            }
            return text;
        }
    }
}
