using Dev.Lau.Blazor.Messaging.Shared.Messages;
using MassTransit;

namespace Dev.Lau.Blazor.Messaging.Api.Consumers;

public class ProductCreatedConsumer : IConsumer<ProductCreated>
{
    public Task Consume(ConsumeContext<ProductCreated> context)
    {
        throw new NotImplementedException();
    }
}