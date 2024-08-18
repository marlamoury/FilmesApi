using System.ComponentModel.DataAnnotations;


namespace FilmesApi.Data.Dtos;

public class CreateFilmeDto
{
    [Required(ErrorMessage = "O Titulo do Filme é Obrigatório!")]
    public String? Titulo { get; set; }

    [Required(ErrorMessage = "O Genero do Filme é Obrigatório!")]
    [StringLength(100, ErrorMessage ="O tamanho do gênero não pode exceder 50 caracteres")]
    public String? Genero { get; set; }

    [Required(ErrorMessage = "A Duração é Obrigatória!")]
    [Range(0, 100, ErrorMessage = "A Duração deve ser no máximo até 2h de filme!")]
    public int Duracao { get; set; }
}
