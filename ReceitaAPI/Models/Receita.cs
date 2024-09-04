using System.ComponentModel.DataAnnotations;

namespace ReceitaAPI.Models;

public class Receita
{
    [Key]
    public int ReceitaId {  get; set; }
    public string? ReceitaName { get; set; }
    public string? ingredientes {  get; set; }
    public string? tipo {  get; set; }
    public string? instrucao { get; set; }   
    public string? tempo { get; set; }
    public int UserId {  get; set; }
    public string? receitaimg {  get; set; }
    public Usuario? Usuario { get; set; }
}
