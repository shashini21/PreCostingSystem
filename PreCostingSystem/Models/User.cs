using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PreCostingSystem.Models
{
    [Table("PreCosting_sys_User", Schema = "dbo")]
    public class User
    {
        [Key]
        [Column("nUserId")]
        public int UserId { get; set; }

        [Column("cUserName")]
        [StringLength(50)]
        public string? UserName { get; set; }

        [Required]
        [Column("cLogName")]
        [StringLength(25)]
        public string LogName { get; set; } = string.Empty;

        [Column("cPassword")]
        [StringLength(255)]
        public string? Password { get; set; }

        [Column("nAccessLvlID")]
        public int? AccessLevel { get; set; }

        [Column("LastLoginDate")]
        public DateTime? LastLoginDate { get; set; }

        [Column("UserCreationDate")]
        public DateTime? UserCreationDate { get; set; }

        [Column("cCreatedBy")]
        [StringLength(50)]
        public string? CreatedBy { get; set; }
    }
}
