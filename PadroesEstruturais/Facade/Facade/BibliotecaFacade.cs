namespace Facade
{
    class BibliotecaFacade
    {
        private Catalogo catalogo = new Catalogo();
        private Usuario usuario = new Usuario();
        private Emprestimo emprestimo = new Emprestimo();

        public void EmprestarLivro(string livro, string nomeUsuario)
        {
            if (!usuario.VerificarMultas(nomeUsuario) && catalogo.VerificarDisponibilidade(livro))
            {
                emprestimo.RegistrarEmprestimo(livro, nomeUsuario);
            }
            else
            {
                Console.WriteLine("Empréstimo não permitido.");
            }
        }
    }
}