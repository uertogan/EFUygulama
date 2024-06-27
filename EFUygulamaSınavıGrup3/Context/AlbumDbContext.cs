using EFUygulamaSınavıGrup3.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFUygulamaSınavıGrup3.Context
{
    public class AlbumDbContext : DbContext
    {
        public DbSet<Yonetici> Yoneticiler {  get; set; }
        public DbSet<Album> Albumler {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server =LENOVO-V15IIL;database=AlbumDb;uid=sa;pwd=123456;trustservercertificate=true");
        }

    }
}
