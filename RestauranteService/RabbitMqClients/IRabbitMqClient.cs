using RestauranteService.Dtos;

namespace RestauranteService.RabbitMqClients
{
    public interface IRabbitMqClient
    {
        public void PublicaRestaurante(RestauranteReadDto restauranteReadDto);
    }
}
