using RestauranteService.Dtos;

namespace RestauranteService.IItemServiceHttpClients
{
    public interface IItemServiceHttpClient
    {
        public void EnviaRestauranteParaItemService(RestauranteReadDto readDto);
    }
}
