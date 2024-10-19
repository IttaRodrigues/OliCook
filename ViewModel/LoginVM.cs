using System.ComponentModel.DataAnnotations;


namespace OliCook.ViewModels;

    public class LoginVM
{
    [Display(Name= "Email ou Nome de Usuario", Prompt = "Informe seu Email ou Nome de Usuario")]
    [Required(ErrorMessage = "Por favor, informe seu email ou nome de usuario")]
    public string Email {get; set;} 

    [Display(Name = "Senha de Acesso", prompt = "*********" )]
    [Requiref(ErrorMessage = " Por favor, informe sua senha")]
    [DataType(DataType.Password)]
    public string  Senha { get; set; }   

    [Display(Name = "Manter Conectado?"  )]
    public bool Lembrar { get; set; } = false;

    public strinf UrlRetorno { get; set; }
}
