using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


[Table ("TipoDev")]
public class TipoDev
{
   [Key] 
        public byte id {get; set;}

       [Required(ErrorMessage ="Informe o Nome") ]
      [StringLength(30, ErrorMessage ="O Nome deve possuir no máximo 30 caracteristica") ] 
        public string Nome {get; set;}
    
}