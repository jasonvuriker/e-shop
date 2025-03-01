using System.ComponentModel.DataAnnotations;

namespace eShopNew.Entities;

public class Role
{
    [Key]
    public int Id { get; set; }

    [Required, MaxLength(255)]
    public string RoleName { get; set; }

    public List<string> Privileges { get; set; }
}