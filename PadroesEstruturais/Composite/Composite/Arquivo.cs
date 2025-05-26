using System;

namespace Composite
{
    class Arquivo : ItemSistema
    {
        public Arquivo(string nome) : base(nome) { }

        public override void Exibir(int nivel)
        {
            Console.WriteLine(new string(' ', nivel) + "- Arquivo: " + Nome);
        }
    }
}