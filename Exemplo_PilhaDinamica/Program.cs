using Exemplo_PilhaDinamica;

internal class Program
{
    private static void Main(string[] args)
    {
        PilhaLivro mpl = new PilhaLivro();
        Livro livro = new Livro("Poeira em auto mar", "Pestana", 2000);
        mpl.Push(livro);
        mpl.Push(new Livro("A volta dos que nao foram", "Andre", 2025));
        mpl.Print();
        mpl.Pop();
        mpl.Print();
        mpl.Pop();
        mpl.Print();
        mpl.Pop();
    }
}