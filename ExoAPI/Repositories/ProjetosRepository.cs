using ExoAPI.Contexts;
using ExoAPI.Models;

namespace ExoAPI.Repositories
{
    public class ProjetosRepository
    {
        private readonly ExoAPIContext _context;

        public ProjetosRepository(ExoAPIContext context)
        {
            _context = context;
        }
        
        public List<Projetos> Listar()
        {
            return _context.Projetos.ToList();
        }
        
        public Projetos BuscarPorId(int id)
        {
            return _context.Projetos.Find(id);
        }

        public void Cadastrar(Projetos projeto)
        {
            _context.Projetos.Add(projeto);
            _context.SaveChanges();
        }

        public void Atualizar(int id, Projetos projeto)
        {
            Projetos projetosearch = _context.Projetos.Find(id);

            if (projetosearch != null)
            {
                projetosearch.Titulo = projeto.Titulo;
                projetosearch.DataDeInicio = projeto.DataDeInicio;
                projetosearch.Tecnologias = projeto.Tecnologias;
                projetosearch.StatusDoProjeto = projeto.StatusDoProjeto;
            }

            _context.Projetos.Update(projetosearch);

            _context.SaveChanges();
        }
        public void Deletar(int id)
        {
            Projetos projeto = _context.Projetos.Find(id);
            _context.Projetos.Remove(projeto);
            _context.SaveChanges();
        }
    }
}
