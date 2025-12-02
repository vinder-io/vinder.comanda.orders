namespace Vinder.Comanda.Orders.Domain.Repositories;

public interface IOrderRepository : IBaseRepository<Order>
{
    public Task<IReadOnlyCollection<Order>> GetOrdersAsync(
        OrderFilters filters,
        CancellationToken cancellation = default
    );

    public Task<long> CountOrdersAsync(
        OrderFilters filters,
        CancellationToken cancellation = default
    );
}
