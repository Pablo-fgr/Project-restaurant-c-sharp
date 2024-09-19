using Pav.Parcial2Rec.Dominio.Entidades;
using System.Linq.Expressions;

namespace Pav.Parcial2Rec.Dominio.Repositorios;

public interface IRepositorio : IDisposable
{
    List<TEntity> ListarTodos<TEntity>(params string[] incluidos) where TEntity : EntityBase;
    List<TEntity> Listar<TEntity>(Expression<Func<TEntity, bool>> predicado, params string[] incluidos)
        where TEntity : EntityBase;
    TEntity? ObtenerElPrimero<TEntity>(Expression<Func<TEntity, bool>> predicado, params string[] incluidos)
        where TEntity : EntityBase;
    void Agregar<TEntity>(TEntity entidad) where TEntity : EntityBase;
    void Actualizar<TEntity>(TEntity entidad) where TEntity : EntityBase;
    void ActualizarSoloLosCamposIncluidos<TEntity>(TEntity entidad, params Expression<Func<TEntity, object>>[] campos)
        where TEntity : EntityBase;
    void Eliminar<TEntity>(TEntity entidad) where TEntity : EntityBase;
    TEntity? ObtenerPorId<TEntity>(Guid id, params string[] incluidos) where TEntity : EntityBase;


}