namespace Vinder.Comanda.Orders.Application.Payloads.Order;

public sealed record OrderCreationScheme : IMessage<Result<OrderScheme>>
{
    public Fulfillment Fulfillment { get; init; }
    public Priority Priority { get; init; }
    public Metadata Metadata { get; init; } = default!;
    public IEnumerable<Item> Items { get; init; } = [];
}
