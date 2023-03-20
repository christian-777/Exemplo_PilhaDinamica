using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_PilhaDinamica
{
    internal class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Ano { get; set; }
        public Livro Anterior { get; set; }

        public Livro(string titulo, string autor, int ano)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Ano = ano;
            this.Anterior = null;
        }

        public override string ToString()
        {
            return (">>>> Dados do livro <<<<\nTitulo: "+this.Titulo+"\nAutor: "+this.Autor+"\nAno de Publiacao: "+this.Ano+"\n\n");
        }
    }
}
