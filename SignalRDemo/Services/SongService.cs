using SignalRDemo.Models;
using SignalRDemo.Models.DbContextModel;

namespace SignalRDemo.Services
{
    public class SongService
    {
        private readonly SongManagementDbContext _context;

        public SongService(SongManagementDbContext context)
        {
            _context = context;
        }

        public List<Song> GetAllSongs()
        {
            try
            {
                return _context.Songs.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetAllSongs: {ex.Message}");
                throw;
            }
        }

        public Song GetSongById(int id)
        {
            try
            {
                return _context.Songs.Find(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetSongById: {ex.Message}");
                throw;
            }
        }

        public void CreateSong(Song song)
        {
            try
            {
                _context.Songs.Add(song);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in CreateSong: {ex.Message}");
                throw;
            }
        }

        public void UpdateSong(Song song)
        {
            try
            {
                _context.Songs.Update(song);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UpdateSong: {ex.Message}");
                throw;
            }
        }

        public void DeleteSong(int id)
        {
            try
            {
                var song = _context.Songs.Find(id);
                if (song != null)
                {
                    _context.Songs.Remove(song);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in DeleteSong: {ex.Message}");
                throw;
            }
        }
    }
}