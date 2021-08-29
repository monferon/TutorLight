using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Tutor.Domain.Entities;

namespace TutorLight.API.Data
{
    public class TutorContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        // public DbSet<Setting> Settings { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Theme> Themes { get; set; }
        public DbSet<Translate> Translates { get; set; }
        public DbSet<Word> Words { get; set; }

        public TutorContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //TODO: Replace user with Indentity framework
            modelBuilder.Entity<User>().HasData(
                new User {Id = 1, Email = "test@mail.ru", Login = "test", Password = "test"},
                new User {Id = 2, Login = "test1", Email = "test1@mail.com", Password = "test"},
                new User {Id = 3, Login = "test2", Email = "test2@mail.com", Password = "test"}
            );

            // TODO: Add Themes
            modelBuilder.Entity<Theme>().HasData(
                new Theme {Id = 1, Name = "Theme1"}
            );

            // TODO: Add Words
            modelBuilder.Entity<Word>().HasData(
                new Word {Id = 1, Name = "TestWord", ThemeId = 1, Picture = new byte[] {0}},
                new Word {Id = 2, Name = "TestWord1", ThemeId = 1, Picture = new byte[] {0}},
                new Word {Id = 3, Name = "TestWord2", ThemeId = 1, Picture = new byte[] {0}}
            );


            // TODO: Add Languages
            modelBuilder.Entity<Language>().HasData(
                new Language {Id = 1, Name = "English"});
            // TODO: Add Translates
            modelBuilder.Entity<Translate>().HasData(
                new Translate
                {
                    Id = 1, WordId = 1, LanguageId = 1, Trans = "TestTranslate1", Audio = "Audio",
                    Trascription = "TestTranscription1"
                },
                new Translate
                {
                    Id = 1, WordId = 2, LanguageId = 1, Trans = "TestTranslate2", Audio = "Audio",
                    Trascription = "TestTranscription2"
                },
                new Translate
                {
                    Id = 1, WordId = 3, LanguageId = 1, Trans = "TestTranslate3", Audio = "Audio",
                    Trascription = "TestTranscription3"
                }
            );
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(
                "Server=127.0.0.1;Port=5432;Database=TutorLight;User Id=postgres;Password=P@ssw0rd;");
        }
    }
}