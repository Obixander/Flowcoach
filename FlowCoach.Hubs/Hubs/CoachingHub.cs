using FlowCoach.Entities;
using Microsoft.AspNetCore.SignalR;

namespace FlowCoach.Hubs.Hubs
{
    public class CoachingHub : Hub
    {
        public async Task<Coaching> GetCoachingAsyncBy(int id)
        {
            throw new NotImplementedException();
        }
    }
}
