using Microsoft.EntityFrameworkCore;

namespace ToMeet.Models
{
    public class ToMeetContext : DbContext
    {
        public ToMeetContext (DbContextOptions<ToMeetContext> options)
            : base(options)
        {
        }

        public DbSet<ToMeet.Models.Event> Event { get; set; }
    }
}