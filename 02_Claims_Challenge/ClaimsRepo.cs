using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using static _02_Claims_Challenge.Claims;

namespace _02_Claims_Challenge
{
    public class Claims_Repository
    {
        private readonly Queue<Claims> queue;

        public Claims_Repository()
        {
            queue = new Queue<Claims>();
        }
        public void AddtoQueue(Claims claim)
        {
            queue.Enqueue(claim);
        }
        public Claims GetNextClaim()
        {
            return queue.Dequeue();
        }
        public Queue<Claims> GetClaims()
        {
            return queue;
        }
    }
}
