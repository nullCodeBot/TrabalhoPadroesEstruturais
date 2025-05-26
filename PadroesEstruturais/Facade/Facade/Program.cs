namespace Facade
{
    class Program
    {
        static void Main()
        {
            var biblioteca = new BibliotecaFacade();
            biblioteca.EmprestarLivro("O Pequeno Príncipe", "João");
        }
    }
}