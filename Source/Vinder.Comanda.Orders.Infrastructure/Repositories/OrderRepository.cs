namespace Vinder.Comanda.Orders.Infrastructure.Repositories;

public sealed class OrderRepository(IMongoDatabase database) :
    BaseRepository<Order>(database, Collections.Orders),
    IOrderRepository
{
    public async Task<IReadOnlyCollection<Order>> GetOrdersAsync(
        OrderFilters filters, CancellationToken cancellation = default)
    {
        var pipeline = PipelineDefinitionBuilder
            .For<Order>()
            .As<Order, Order, BsonDocument>()
            .FilterOrders(filters)
            .Paginate(filters.Pagination)
            .Sort(filters.Sort);

        var options = new AggregateOptions { AllowDiskUse = true };
        var aggregation = await _collection.AggregateAsync(pipeline, options, cancellation);

        var bsonDocuments = await aggregation.ToListAsync(cancellation);
        var orders = bsonDocuments
            .Select(bson => BsonSerializer.Deserialize<Order>(bson))
            .ToList();

        return orders;
    }

    public async Task<long> CountOrdersAsync(
        OrderFilters filters, CancellationToken cancellation = default)
    {
        var pipeline = PipelineDefinitionBuilder
            .For<Order>()
            .As<Order, Order, BsonDocument>()
            .FilterOrders(filters)
            .Count();

        var aggregation = await _collection.AggregateAsync(pipeline, cancellationToken: cancellation);
        var result = await aggregation.FirstOrDefaultAsync(cancellation);

        return result?.Count ?? 0;
    }
}