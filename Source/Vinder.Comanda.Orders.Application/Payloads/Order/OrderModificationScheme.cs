namespace Vinder.Comanda.Orders.Application.Payloads.Order;

public sealed record OrderModificationScheme : IMessage<Result<OrderScheme>>
{
    [property: JsonIgnore]
    public string Id { get; init; } = default!;

    public Status Status { get; init; }
    public Priority Priority { get; init; }
}
