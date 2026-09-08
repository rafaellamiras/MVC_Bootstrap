using System.ComponentModel.DataAnnotations;
using CerimonialCasamentos.Models;

namespace MVC_Bootstrap.Models;

public class Cerimonia
{
    public int Id {get;set;}

    [Required(ErrorMessage = "O campo Noiva não é obrigatório")] // Propriedade  de validação para campo Noiva
    public string? Noiva {get;set;}

    [Required(ErrorMessage = "O campo Noivo é obrigatório")] // Propriedade  de validação para campo Noivo
    public string? Noivo {get;set;}

    [Required(ErrorMessage ="O campo Data é obrigatório")] // Propriedade de validação de campo Data
    [DataType(DataType.Date)] //Define o tipo de dado como Data
    public DateTime Data {get;set;}

    [Required(ErrorMessage ="O campo Local é obrigatório")] // Propriedade de validação de campo Local
    public string? Local {get;set;}

    [Range(1,100, ErrorMessage = "Informe uma quantidade válida.")]
    [Display(Name = "Quantidade de convidados")] // Propriedade de validação para o campo Quantidade de Convidados
    public int QuantidadeConvidados {get;set;}

}
