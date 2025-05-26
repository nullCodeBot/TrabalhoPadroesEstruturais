using System;

namespace Facade
{
    class Emprestimo
    {
        public void RegistrarEmprestimo(string livro, string usuario)
        {
            Console.WriteLine($"Livro '{livro}' emprestado para {usuario}");
        }
    }
}