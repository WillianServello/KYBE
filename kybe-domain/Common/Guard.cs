using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kybe_domain.Common
{
    public static class Guard
    {
        public static string AgainstNullOrWhiteSpace(string value, string name)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException($"{name} é obrigatório e não pode ser vazio");

            return value;
        }
    }
}
