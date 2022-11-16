using System.ComponentModel.DataAnnotations;

namespace CIPMApplication2.Models;

public class Common
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Email is required")]
    public string Email { get; set; }

    [MaxLength(13)]
    [Required]
    public string Phone { get; set; }
   
    [Required]
    public string Address { get; set; }

    [Required]
    public string City { get; set; }

    [Required]
    public string State { get; set; }
    public DateTime Created { get; set; }
    [Required]
    public MembershipStatus Status { get; set; }

    public enum MembershipStatus
    {
        Active = 101,
        Inactive,
        Suspended
    }

    public enum Gender
    {
        Male,
        Female,
        Others
    }
}
