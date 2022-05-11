using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodeVotar
{
    public class Voto
    {
        public string podeVotar(int idade)
        {
            if (idade > 18)
                return "Pode votar";
            if (idade < 16)
                return "Não pode votar";
            return "Voto opcional";
        }
    }
}
