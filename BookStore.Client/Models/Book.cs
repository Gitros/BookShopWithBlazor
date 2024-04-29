using System.ComponentModel.DataAnnotations;

namespace BookStore.Client.Models;

public class Book
{
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public required string Name { get; set; }

    [Required]
    [StringLength(20)]
    public required string Genre { get; set; }

    [Required]
    [StringLength(50)]
    public required string Author { get; set; }

    [Range(1, 100)]
    public decimal Price { get; set; }
    public DateTime ReleaseDate { get; set; }
}