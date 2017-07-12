using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Proyecto_Progra_3
{
    class ClaseRUT
    {
        public String formatear(string RUT)
        {
            int cont = 0;
            String format;
            if (RUT.Length == 0)
            {
                return "";
            }
            else
            {
                RUT.Replace(".", "");
                format = "" + RUT.Substring(RUT.Length - 1);
                for (int i = RUT.Length - 2; i >= 0; i--)
                {
                    format = RUT.Substring(i, 1) + format;
                    cont++;
                    if (cont == 3 && i != 0)
                    {
                        format = "." + format;
                        cont = 0;
                    }
                }
                return format;
            }
        }
        public bool valida_Email(string eMail)
        {
            Regex email_expresionRegular = new Regex(@"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))|(_)" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$", RegexOptions.Compiled);

            if (!email_expresionRegular.IsMatch(eMail))
            {
                return false;
            }
            else
            {

                return true;
            }
        }
    }
}
