using System.ComponentModel.DataAnnotations;

namespace eShopNew.Entities;

public class Country
{
    [Key]
    public int Id { get; set; }

    [Required, MaxLength(2)]
    public string Iso { get; set; }

    [Required, MaxLength(80)]
    public string Name { get; set; }

    [Required, MaxLength(80)]
    public string UpperName { get; set; }

    [MaxLength(3)]
    public string Iso3 { get; set; }

    public short? NumCode { get; set; }

    public int PhoneCode { get; set; }
}