using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MtecDevs.Models;

    public class Usuario
    {
          
     [Required(ErrorMessage ="Informe o Nome") ]
     [StringLength(60, ErrorMessage ="O Nome deve possuir no máximo 30 caracteristica") ] 
        public string Nome {get; set;}

     [DataType(DataType.Date) ]
     [Display(Name = "Data de Nascimento")]
     [Required(ErrorMessage = "Informe a data de nascimento")]   
        public DateTime DataNascimento {get; set;}

     [StringLength(300)] 
        public string foto {get; set;}

     [Display (Name = "Tipo de Desenvolvesor")]
     [Required(ErrorMessage = "Informe o tipo de Desenvolvedor")] 
         public byte TipoDevId {get; set; }
         [ForeignKey("TipoDevId")]
         public TipoDev TipoDev  {get; set;}
    }