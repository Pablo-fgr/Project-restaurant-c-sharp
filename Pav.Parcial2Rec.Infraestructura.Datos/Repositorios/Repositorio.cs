using Microsoft.EntityFrameworkCore;
using Pav.Parcial2Rec.Dominio.Entidades;
using Pav.Parcial2Rec.Dominio.Repositorios;
using System.Linq.Expressions;

namespace Pav.Parcial2Rec.Infraestructura.Datos.Repositorios;

public class Repositorio : IRepositorio
{
    private readonly PavParcialRecContext _context;
    public Repositorio(PavParcialRecContext context)
    {
        ArgumentNullException.ThrowIfNull(context);
        _context = context;
    }

    public void Actualizar<TEntity>(TEntity entidad) where TEntity : EntityBase
    {
        _context.Update(entidad);
        _context.SaveChanges();
    }
    //nuevo metodo
    public void ActualizarSoloLosCamposIncluidos<TEntity>(TEntity entidad, params Expression<Func<TEntity, object>>[] campos)
        where TEntity : EntityBase
    {
        // Adjuntar la entidad al contexto si no está siendo rastreada
        _context.Set<TEntity>().Attach(entidad);

        // Marcar solo los campos especificados como modificados
        foreach (var campo in campos)
        {
            _context.Entry(entidad).Property(campo).IsModified = true;
        }

        // Guardar los cambios
        _context.SaveChanges();
    }

    public void Agregar<TEntity>(TEntity entidad) where TEntity : EntityBase
    {
        _context.Set<TEntity>().Add(entidad);
        _context.SaveChanges();
    }

    public void Dispose()
    {
        _context.Dispose();
        GC.SuppressFinalize(this);
    }

    public void Eliminar<TEntity>(TEntity entidad) where TEntity : EntityBase
    {
        _context.Set<TEntity>().Remove(entidad);
        _context.SaveChanges();
    }

    private IQueryable<TEntity> Incluir<TEntity>(IQueryable<TEntity> consulta, string[] incluidos)
        where TEntity : EntityBase
    {
        var incluidosConsulta = consulta;

        foreach (var incluido in incluidos)
        {
            incluidosConsulta = incluidosConsulta.Include(incluido);
        }

        return incluidosConsulta;
    }

    public List<TEntity> Listar<TEntity>(Expression<Func<TEntity, bool>> predicado, params string[] incluidos)
        where TEntity : EntityBase
    {
        return Incluir(_context.Set<TEntity>(), incluidos).Where(predicado).ToList();
    }

    public List<TEntity> ListarTodos<TEntity>(params string[] incluidos) where TEntity : EntityBase
    {
        return Incluir(_context.Set<TEntity>(), incluidos).ToList();
    }

    public TEntity? ObtenerElPrimero<TEntity>(Expression<Func<TEntity, bool>> predicado, params string[] incluidos)
        where TEntity : EntityBase
    {
        return Incluir(_context.Set<TEntity>(), incluidos).FirstOrDefault(predicado);
    }

    public TEntity? ObtenerPorId<TEntity>(Guid id, params string[] incluidos) where TEntity : EntityBase
    {
        return Incluir(_context.Set<TEntity>(), incluidos).SingleOrDefault(e => e.Id == id);
    }
}
