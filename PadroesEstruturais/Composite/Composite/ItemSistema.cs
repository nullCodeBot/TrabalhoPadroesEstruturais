namespace Composite
{
    abstract class ItemSistema
    {
        public string Nome { get; set; }
        public ItemSistema(string nome) => Nome = nome;
        public abstract void Exibir(int nivel);
    }
}