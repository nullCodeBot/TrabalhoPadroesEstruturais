using System;
using System.Collections.Generic;

namespace Composite
{
    class Pasta : ItemSistema
    {
        private List<ItemSistema> _itens = new List<ItemSistema>();

        public Pasta(string nome) : base(nome) { }

        public void Adicionar(ItemSistema item)
        {
            _itens.Add(item);
        }

        public override void Exibir(int nivel)
        {
            Console.WriteLine(new string(' ', nivel) + "+ Pasta: " + Nome);
            foreach (var item in _itens)
                item.Exibir(nivel + 2);
        }
    }
}