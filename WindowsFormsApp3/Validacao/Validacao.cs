using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WindowsFormsApp3.Validacao
{
    public static class Validacao
    {
       
        public static string ValidacaoString(this string texto)
        {
            return string.IsNullOrWhiteSpace(texto) ? throw new Exception("Propriedade deve esta preenchida.") : texto;
        }
    }
}
