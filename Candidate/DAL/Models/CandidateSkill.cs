namespace DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CandidateSkill")]
    public partial class CandidateSkill
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CVNo { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SkillNo { get; set; }

        [StringLength(10)]
        public string gvhgfhf { get; set; }

        public virtual Candidate Candidate { get; set; }

        public virtual Skill Skill { get; set; }
    }
}
