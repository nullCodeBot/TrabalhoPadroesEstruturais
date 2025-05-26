using System;

namespace Facade
{
    class Catalogo
    {
        public bool VerificarDisponibilidade(string livro)
        {
            Console.WriteLine($"Verificando disponibilidade do livro: {livro}");
            return true;
        }
    }
}