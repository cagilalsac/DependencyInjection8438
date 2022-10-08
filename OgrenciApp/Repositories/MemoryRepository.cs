using OgrenciApp.Data;
using OgrenciApp.Models;
using OgrenciApp.Repositories.Bases;

namespace OgrenciApp.Repositories
{
    public class MemoryRepository : IRepository
    {
        public Ogrenci[] Getir()
        {
            return OgrenciData.Ogrenciler;
        }
    }
}
