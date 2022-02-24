using Microsoft.EntityFrameworkCore;
using StarterM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarterM.Data
{
    public class OperaContext:DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Opera>().HasData(
                new Opera
                {
                    OperaID = 1,
                    Title = "Cosi Fan Tutte",
                    Year = 1790,
                    Composer = "Wolfgang Amadeus Mozart",
                },
                new Opera
                {
                    OperaID = 2,
                    Title = "Rigoletto",
                    Year = 1851,
                    Composer = "Giuseppe Verdi",
                },
                new Opera
                {
                    OperaID = 3,
                    Title = "Nixon in China",
                    Year = 1987,
                    Composer = "John Adams"
                },
                new Opera
                {
                    OperaID = 4,
                    Title = "Wozzeck",
                    Year = 1922,
                    Composer = "Alban Berg"
                }
             );

            modelBuilder.Entity<Comment>().HasData(
              new Comment { CommentId = 1, OperaID = 1, UserName = "user1", UserComment = "comment1", LastModified = DateTime.Now },
              new Comment { CommentId = 2, OperaID = 1, UserName = "user2", UserComment = "comment2", LastModified = DateTime.Now },
              new Comment { CommentId = 3, OperaID = 2, UserName = "user3", UserComment = "comment3", LastModified = DateTime.Now },
              new Comment { CommentId = 4, OperaID = 2, UserName = "user4", UserComment = "comment4", LastModified = DateTime.Now }
              );


        }


        public OperaContext(DbContextOptions<OperaContext> options)
            :base(options)
        {

        }

        public DbSet<Opera>  Operas { get; set; }
        public DbSet<Comment>  Comments { get; set; }
    }
}
