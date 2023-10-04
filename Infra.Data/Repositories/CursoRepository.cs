using Domain.Interfaces.Repositories;
using Domain.Models;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Repositories
{
    public class CursoRepository : GenericRepository<Curso>, ICursoRepository
    {
        protected readonly WebApiContext _context;
        protected readonly DbSet<Curso> _curso;
        public CursoRepository(WebApiContext context) : base(context)
        {
            _context = context;
            _curso = context.Set<Curso>();
        }
    }
}
