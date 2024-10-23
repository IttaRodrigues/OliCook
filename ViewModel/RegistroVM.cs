using System.ComponentModel.DataAnnotation;


namespace OliCook.ViewModels;

    public class RegistroVM
    {
        [Display(Name = "Nome Completo", Prompt = "Informe seu Nome Completo")]
        [Required(ErrorMessage = "Por favor, informe seu Nome")]
        [StringLength(60, ErrorMessage = "O Nome deve possuir no maximo 60 caracteres")]
        public string Nome { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento", Prompt = "Informe sua Data de Nascimento")]
        [Required(ErrorMessage = "Por favor, informe sua Data de Nascimento")]        
        public DateTime? DataNascimento { get; set; } = null;

        [Display(Prompt = "Informe seu Email")]
        [Required(ErrorMessage = "Por favor, informe seu Email")]
        [StringLength(100, ErrorMessage = "O Email deve possuir no maximo 100 caracteres")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Senha de Acesso", Prompt = "Informe uma Senha para Acesso")]
        [Required(ErrorMessage = "Por favor, informe sua Senha de Acesso")]
        [StringLength(20, MinimumLength = 6, ErrosMessage = "A senha deve possuir no minimo 6 e no maximo 20 caracteres")]
        public string Senha { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar Senha de Acesso", Prompt = "Confirme sua Senha para Acesso")]
        [Compare("Senha", ErrorMessage = "As Senhas não Conferem.")]
        
        public tring ConfirmacaoSenha { get; set; }
        public IFormFile Foto { get; set; }  

        public bool Termos { get; set; } = false;

        public bool Enviado { get; set; } = false;



    }
