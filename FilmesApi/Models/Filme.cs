using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models;

public class Filme
{
    [Key]
    [Required]
    public int Id { get; set; }


    [Required(ErrorMessage = "O Titulo do Filme é Obrigatório!")]
    public String? Titulo  { get; set; }

    [Required(ErrorMessage = "O Genero do Filme é Obrigatório!")]
    [MaxLength(100)]
    public String? Genero { get; set; }
    
    [Required(ErrorMessage = "A Duração é Obrigatória!")]
    [Range(0, 100, ErrorMessage = "A Duração deve ser no máximo até 2h de filme!")]
    public int Duracao { get; set; }
    
}
