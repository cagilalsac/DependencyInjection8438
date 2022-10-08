using OgrenciApp.Models;
using OgrenciApp.Repositories.Bases;

namespace OgrenciApp.Services
{
    public class OgrenciService
    {
        private readonly IRepository _repository;

        public OgrenciService(IRepository repository) // constructor injection
        {
            _repository = repository;
        }

        public Ogrenci[] OgrencileriGetir()
        {
            return _repository.Getir();
        }
    }
}
