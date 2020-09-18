using System;
using System.Linq;

namespace EFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new VotingContext())
            {
                // Create
                Console.WriteLine("Inserting a new Vote");
                db.Add(new Voter { Url = "http://blogs.msdn.com/adonet" });
                db.SaveChanges();

                // Read
                Console.WriteLine("Querying for a Vote");
                var blog = db.Votes
                    .OrderBy(b => b.VoterId)
                    .First();

                // Update
                Console.WriteLine("Updating the Votes and adding a Vote");
                blog.Url = "https://devblogs.microsoft.com/dotnet";
                blog.PermissionId.Add(
                    new PermissionStatus
                    {
                        Title = "Hello World",
                        Content = "I wrote an app using EF Core!"
                    });
                db.SaveChanges();

                // Delete
                Console.WriteLine("Delete the Votes");
                db.Remove(blog);
                db.SaveChanges();
            }
    }
}
