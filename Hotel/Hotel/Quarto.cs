using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class Quarto
    {
        public string NomeAluguel { get; set; }

        public string Email { get; set; }
        public int Numeracao { get; set; }



       //Construtor
       public Quarto(string nome, string email, int numeracao)
        {
            this.NomeAluguel = nome;
            this.Email = email;
            this.Numeracao = numeracao;

        }




        

    }
}
