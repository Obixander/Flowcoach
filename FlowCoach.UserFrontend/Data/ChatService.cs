
using Microsoft.AspNetCore.SignalR.Client;

namespace FlowCoach.UserFrontend.Data
{
    public class ChatService : IAsyncDisposable
    {
        private readonly HubConnection _hubConnection;
        public ChatService()
        {
            _hubConnection = new HubConnectionBuilder()
                .WithUrl("https://localhost:7003/chathub") // Replace with your API URL
                .Build();
        }

        public async Task StartConnectionAsync()
        {
            await _hubConnection.StartAsync();
        }

        public async Task SendMessage(string user, string message)
        {
            await _hubConnection.InvokeAsync("SendMessage", user, message);
        }

        public async Task SubscribeToMessages(Action<string, string> onMessageReceived)
        {
            _hubConnection.On("ReceiveMessage", onMessageReceived);
        }

        public async ValueTask DisposeAsync()
        {
            await _hubConnection.DisposeAsync();
        }
    }
}
