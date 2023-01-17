using PlatformService.Data;
using PlatformService.Interface;
using PlatformService.Models;

namespace PlatformService.Service
{
    public class PlatformRepo : IPlatformRepo
    {
        private readonly AppDbContext _context;            
        public PlatformRepo(AppDbContext context)
        {
            _context = context;
        }
        public void CreatePlatform(Platform platform)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Platform> GetAllPlatforms()
        {
            throw new NotImplementedException();
        }

        public Platform GetPlatformById(int id)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            return(_context.SaveChanges() >= 0);
        }

        public Platform UpdatePlatformById(int id)
        {
            throw new NotImplementedException();
        }
    }
}