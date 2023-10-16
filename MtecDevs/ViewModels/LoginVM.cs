using System.ComponentModel.DataAnnotations;


namespace MtecDevs.ViewModels;

    public class LoginVM
    {
        [Display(Name = "Email ou nome de usuário", Prompt ="informe seu Email ou Nome de Usuário")]
         [Required (ErrorMessage ="Por Favor, informe seu email ou nome de usuário")]  
      public string Email {get; set;}  

         [Display(Name = "Senha de Acesso", Prompt ="informe sua Senha")]
         [Required (ErrorMessage ="Por Favor, informe sua Senha")]  
         [DataType(DataType.Password)] 
       public string Senha {get; set;}  
       
         [Display(Name = "Manter Conectado?")] 
        public bool Lembrar {get; set;}  = false;
       
         public string UrlRetorno {get; set;}  
    }
