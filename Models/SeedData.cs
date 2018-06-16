// using Microsoft.EntityFrameworkCore;
// using Microsoft.Extensions.DependencyInjection;
// using System;
// using System.Linq;

// namespace ToMeet.Models
// {
//     public static class SeedData
//     {
//         public static void Initialize(IServiceProvider serviceProvider)
//         {
//             using (var context = new ToMeetContext(
//                 serviceProvider.GetRequiredService<DbContextOptions<ToMeetContext>>()))
//             {
//                 // Look for any movies.
//                 if (context.Event.Any())
//                 {
//                     return;   // DB has been seeded
//                 }

//                 context.Event.AddRange(
//                      new Event
//                      {
//                          Publisher = "David",
//                          Title = "When Harry Met Sally",
//                          Location = "Hurstville",
//                          Description = "3V3",
//                          StartTime = DateTime.Parse("2018-6-15"),
//                      } 
//                 );
//                 context.SaveChanges();
//             }
//         }
//     }
// }