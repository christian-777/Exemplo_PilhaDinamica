using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_PilhaDinamica
{
    internal class PilhaLivro
    {
        public Livro Topo { get; set; }

        public PilhaLivro()
        {
            this.Topo = null;
            Console.WriteLine("Pilha criada com sucesso");
        }

        public void Push(Livro aux)
        {
            aux.Anterior = Topo;
            this.Topo = aux;
        }

        public void Print() 
        {
            Livro aux;
            if (Vazia())
            {
                Console.WriteLine("\nImpossivel Imprimir: Plha vazia");
                return;
            }
            else
            {
                aux= Topo;
                Console.WriteLine("\nOs elementos na pilha sao:\n");
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Anterior;
                }while(aux != null);
                Console.WriteLine("Final da pilha\n");
            }
        }
        public void Pop()
        {
            if(Vazia())
            {
                Console.WriteLine("\nImpossivel Remover: Plha vazia");
                return;
            }
            else
            {
                Topo = Topo.Anterior;
            }
        }
        private bool Vazia()
        {
            //if (Topo == null) return true; else return false;
            //return Topo == null ? true : false;

            if (this.Topo == null)
            {
                return true;
            }
            return false;
        }
    }
}
