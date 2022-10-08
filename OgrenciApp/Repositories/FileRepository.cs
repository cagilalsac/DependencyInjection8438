using OgrenciApp.Models;
using OgrenciApp.Repositories.Bases;
using System.Text;

namespace OgrenciApp.Repositories
{
    public class FileRepository : IRepository
    {
        private readonly string _path;

        public FileRepository(string path)
        {
            _path = path;
        }

        public Ogrenci[] Getir()
        {
            File.ReadAllLines(_path, Encoding.UTF8);
        }
    }
}
