using Grpc.Core;
using gRoom.gRPC.Messages;

namespace gRoom.gRPC.Services;

public class GroomService : Groom.GroomBase
{
    private readonly ILogger<GroomService> _logger;
    public GroomService(ILogger<GroomService> logger)
    {
        _logger = logger;
    }

    public override Task<RoomRegistrationResponse> RegisterToRoom(RoomRegistrationRequest request, ServerCallContext context)
    {
        _logger.LogInformation("Service called...");
        var rnd = new Random();
        var roomNum = rnd.Next(1, 100);
        _logger.LogInformation($"Room no. {roomNum}");
        var resp = new RoomRegistrationResponse { RoomId = roomNum };
        return Task.FromResult(resp);
    }

    public override async Task<NewsStreamStatus> SendNewsFlash(IAsyncStreamReader<NewsFlash> newsStream, ServerCallContext context)
    {
        while (await newsStream.MoveNext())
        {
            var news = newsStream.Current;
            Console.WriteLine($"News Flash: {news.NewsItem}");
        }

        return new NewsStreamStatus { Success = true };
    }
}
