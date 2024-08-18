using AutoMapper;
using FilmesApi.Data.Dtos;
using FilmesApi.Models;

namespace FilmesApi.Profile
{
    public class FilmeProfile : AutoMapper.Profile
    {
        public FilmeProfile()
        {
            // Mapeamento de Filme para FilmeDTO e vice-versa
            //CreateMap<Filme, FilmeDTO>();
            CreateMap<CreateFilmeDto, Filme>();

            // Adicione outros mapeamentos conforme necessário
        }
    }
}
