using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace EFCore
{
    public class VotingContext : DbContext
    {
        public DbSet<Voter> Voter { get; set; }
        public DbSet<PermissionStatus> Votes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=Voting.db");
    }
    public class Voter
    {
        public int VoterId { get; set; }
        public string PermissionID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DriverLicense { get; set; }
        public string Url { get; internal set; }
    }
    public class PermissionStatus
    {
        [Key]
        public string PermissionId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int VoterId { get; set; }
        public string Url { get; internal set; }
    }
    public class DriverLicense
    {
        public int DriverLicenseID { get; set; }
        public string StateName { get; set; }
        public int DLNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
    public class Candidate
    {
        public int CandidateID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DriverLicenseID { get; set; }
        public int PermissionId { get; set; }

    }
}
