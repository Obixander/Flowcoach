using Microsoft.AspNetCore.SignalR.Client;

namespace FlowCoach.UserFrontend.Data
{
    public class SignalRService
    {
        private readonly HubConnection _hubConnection;

        public SignalRService(string hubUrl)
        {
            _hubConnection = new HubConnectionBuilder()
                .WithUrl(hubUrl)
                .Build();
        }
        public SignalRService()
        {
            
        }

        public async Task StartConnectionAsync()
        {
            if (_hubConnection.State == HubConnectionState.Disconnected)
            {
              
                await _hubConnection.StartAsync();
     
            }
  
        }

        public async Task StopConnectionAsync()
        {
            if (_hubConnection.State == HubConnectionState.Connected)
            {
                await _hubConnection.StopAsync();
            }
        }

        public HubConnection HubConnection => _hubConnection;
    }
}
