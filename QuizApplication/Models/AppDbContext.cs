using Microsoft.EntityFrameworkCore;
using System;
namespace QuizApplication.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }
        public DbSet<Question> questions { get; set; }

        public DbSet<Choice> choices { get; set;}

        public DbSet<ChoiceCollection> choiceCollection{get; set; }

        protected  override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed Question
            modelBuilder.Entity<Question>().HasData(new Question { QuestionId = 1, QuestionHeading = "question1", ChoicesId = 1 });

            //seed Choice
            modelBuilder.Entity<Choice>().HasData(new Choice { Body = "Rome", ChoiceId = 1, Title = "b", FacturalStatement = true, CollectionId = 1 });
            modelBuilder.Entity<Choice>().HasData(new Choice { Body = "Rome", ChoiceId = 2, Title = "b", FacturalStatement = true, CollectionId = 1 });
            modelBuilder.Entity<Choice>().HasData(new Choice { Body = "Naples", ChoiceId = 3, Title = "c", FacturalStatement = false, CollectionId = 1 });
            modelBuilder.Entity<Choice>().HasData(new Choice { Body = "Milan", ChoiceId = 4, Title = "d", FacturalStatement = false, CollectionId = 1 });


            //seed Choices
            modelBuilder.Entity<ChoiceCollection>().HasData((new ChoiceCollection
            {
                ChoiceCollectionId = 1,
                QuestionId = 1,
            }));
            modelBuilder.Entity<ChoiceCollection>().HasData((new ChoiceCollection
            {
                ChoiceCollectionId = 2,
                QuestionId = 2,
            }));


        }
    }
}

