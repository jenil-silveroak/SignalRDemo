using Microsoft.AspNetCore.SignalR;
using SignalRDemo.Models;

namespace SignalRDemo.SignalRServices
{
    public class SongHub : Hub
    {
        private readonly IHubContext<SongHub> _hubContext;

        public SongHub(IHubContext<SongHub> hubContext)
        {
            _hubContext = hubContext;
        }

        public async Task UpdateSong(Song song)
        {
            await _hubContext.Clients.All.SendAsync("ReceiveUpdateSong", song);
        }

        public async Task DeleteSong(int songId)
        {
            await _hubContext.Clients.All.SendAsync("ReceiveDeleteSong", songId);
        }
    }
}
