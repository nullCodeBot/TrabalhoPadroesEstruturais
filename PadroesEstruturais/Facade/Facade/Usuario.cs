using System;

namespace Facade
{
    class Usuario
    {
        public bool VerificarMultas(string nome)
        {
            Console.WriteLine($"Verificando multas para o usuário: {nome}");
            return false;
        }
    }
}