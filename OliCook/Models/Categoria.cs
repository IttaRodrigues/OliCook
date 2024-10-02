using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.SignalR;

namespace OliCook.Models;

[Table("Categoria")]
public class Categoria
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(30)]
    public string Nome { get; set; }

    [StringLength(300)]
    public string Foto { get; set; }
    
    public bool ExibirHome { get; set; } = false;


}