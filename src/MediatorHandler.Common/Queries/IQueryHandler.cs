namespace MediatorHandler.Common.Queries;

public interface IQueryHandler<P, T> where P : IQuery
{
    Task<T> ExecuteQueryAsync(P parameters);
}
