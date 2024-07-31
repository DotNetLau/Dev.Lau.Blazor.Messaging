using Dev.Lau.Blazor.Messaging.Shared.Messages;
using MassTransit;

namespace Dev.Lau.Blazor.Messaging.Services;

public class BusPublisher(IPublishEndpoint publishEndpoint)
{
    public void PublishProductCreated(string name)
    {
        var dto = new ProductCreated { Name = name };

        publishEndpoint.Publish(dto);
    }
}