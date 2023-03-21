using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTelefones
{
    public class GuardaNumeros
    {
        public List<Lista> Numeros { get; set; } = new List<Lista>() { };

        public void adicionarNumero(Lista lista)
        {
            Numeros.Add(lista);
        }
        public void removerNumero(Lista lista)
        {
            Numeros.Remove(lista);
        }
    }
}
