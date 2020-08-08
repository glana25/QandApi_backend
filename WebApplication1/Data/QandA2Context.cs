using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace QqndAApi.Data
{
    public partial class QandA2Context : DbContext
    {
        public QandA2Context()
        {
        }

        public QandA2Context(DbContextOptions<QandA2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Answers> Answers { get; set; }
        public virtual DbSet<Questions> Questions { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(LocalDb)\\MSSQLLocalDB;Database=QandA2;Trusted_Connection=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Answers>(entity =>
            {
                entity.HasIndex(e => e.QuestionId);

                entity.HasIndex(e => e.UserId);

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.Answers)
                    .HasForeignKey(d => d.QuestionId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Answers)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Questions>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.UserId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
