namespace Composite
{
    class Program
    {
        static void Main()
        {
            var raiz = new Pasta("Documentos");

            var pastaTrabalho = new Pasta("Trabalho");
            pastaTrabalho.Adicionar(new Arquivo("relatorio.docx"));
            pastaTrabalho.Adicionar(new Arquivo("apresentacao.pptx"));

            var pastaPessoal = new Pasta("Pessoal");
            pastaPessoal.Adicionar(new Arquivo("foto.jpg"));
            pastaPessoal.Adicionar(new Arquivo("curriculo.pdf"));

            raiz.Adicionar(pastaTrabalho);
            raiz.Adicionar(pastaPessoal);
            raiz.Exibir(0);
        }
    }
}