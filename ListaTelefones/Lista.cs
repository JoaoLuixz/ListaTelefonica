using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTelefones
{
    public class Lista
    {
        public string Nome { get; set; } = string.Empty;
        public string Numero { get; set; } = String.Empty;
        public override string ToString()
        {
            return $"Nome:{Nome} -- Número:{Numero}";
        }

    }
}
