using SignalRDemo.Models;
using SignalRDemo.Models.DbContextModel;

namespace SignalRDemo.Services
{
    public class SingerService
    {
        private readonly SongManagementDbContext _context;

        public SingerService(SongManagementDbContext context)
        {
            _context = context;
        }

        public List<Singer> GetAllSingers()
        {
            try
            {
                return _context.Singers.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetAllSingers: {ex.Message}");
                throw;
            }
        }

        public Singer GetSingerById(int id)
        {
            try
            {
                return _context.Singers.Find(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetSingerById: {ex.Message}");
                throw;
            }
        }

        public void CreateSinger(Singer singer)
        {
            try
            {
                _context.Singers.Add(singer);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in CreateSinger: {ex.Message}");
                throw;
            }
        }

        public void UpdateSinger(Singer singer)
        {
            try
            {
                var existingSinger = _context.Singers.Find(singer.SingerId);
                if (existingSinger != null)
                {
                    _context.Entry(existingSinger).CurrentValues.SetValues(singer);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UpdateSinger: {ex.Message}");
                throw;
            }
        }

        public void DeleteSinger(int id)
        {
            try
            {
                var singer = _context.Singers.Find(id);
                if (singer != null)
                {
                    _context.Singers.Remove(singer);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in DeleteSinger: {ex.Message}");
                throw;
            }
        }
    }
}