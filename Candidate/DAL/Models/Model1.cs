using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Candidate> Candidates { get; set; }
        public virtual DbSet<CandidateSkill> CandidateSkills { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Candidate>()
                .HasMany(e => e.CandidateSkills)
                .WithRequired(e => e.Candidate)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CandidateSkill>()
                .Property(e => e.gvhgfhf)
                .IsFixedLength();

            modelBuilder.Entity<Skill>()
                .HasMany(e => e.CandidateSkills)
                .WithRequired(e => e.Skill)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Skill>()
                .HasMany(e => e.Jobs)
                .WithRequired(e => e.Skill)
                .HasForeignKey(e => e.RequiredSkillId)
                .WillCascadeOnDelete(false);
        }
    }
}
