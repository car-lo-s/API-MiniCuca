using System.ComponentModel.DataAnnotations;

namespace ReceitaAPI.Models;

public class Usuario
{
    [Key]
    public int UserId { get; set; }
    public string? nome {  get; set; }
    public string? email {  get; set; }
    public string ? password { get; set; }
    public string? foto {  get; set; }
    public ICollection<Receita>? Receitas { get; set; }
}
