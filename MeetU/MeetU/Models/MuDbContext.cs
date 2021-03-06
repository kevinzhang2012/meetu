﻿//
//  The unique database context used in this project
//  @Yue
//
using System;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MeetU.Models
{
    public class MuDbContext : IdentityDbContext<ApplicationUser>, IDisposable
    {
        public MuDbContext()
            : base("MeetUDB", throwIfV1Schema: false)
        {
        }

        public static MuDbContext Create()
        {
            return new MuDbContext();
        }

        public virtual IDbSet<Meetup> Meetups { get; set; }
        public virtual IDbSet<Join> Joins { get; set; }
        public virtual IDbSet<Comment> Comments { get; set; }
        public virtual IDbSet<Profile> Profiles { get; set; }
        public virtual IDbSet<ProfileNotInUsers> ProfilesNotInUsers { get; set; }
        public virtual IDbSet<UserNotInProfiles> UsersNotInProfiles { get; set; }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<UserNotInProfiles>().ToTable("UsersNotInProfiles");
            builder.Entity<ProfileNotInUsers>().ToTable("ProfilesNotInUsers");
        }
    }
}