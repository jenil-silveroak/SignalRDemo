using SignalRDemo.Models;
using SignalRDemo.Models.DbContextModel;

namespace SignalRDemo.Services
{
    public class SungByService
    {
        private readonly SongManagementDbContext _context;

        public SungByService(SongManagementDbContext context)
        {
            _context = context;
        }

        public List<SungBy> GetAllSungBys()
        {
            try
            {
                return _context.SungBys.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetAllSungBys: {ex.Message}");
                throw;
            }
        }

        public SungBy GetSungByById(int id)
        {
            try
            {
                return _context.SungBys.Find(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetSungByById: {ex.Message}");
                throw;
            }
        }

        public void CreateSungBy(SungBy sungBy)
        {
            try
            {
                _context.SungBys.Add(sungBy);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in CreateSungBy: {ex.Message}");
                throw;
            }
        }

        public void UpdateSungBy(SungBy sungBy)
        {
            try
            {
                _context.SungBys.Update(sungBy);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UpdateSungBy: {ex.Message}");
                throw;
            }
        }

        public void DeleteSungBy(int id)
        {
            try
            {
                var sungBy = _context.SungBys.Find(id);
                if (sungBy != null)
                {
                    _context.SungBys.Remove(sungBy);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in DeleteSungBy: {ex.Message}");
                throw;
            }
        }

        public void DeleteSungBySongId(int id)
        {
            try
            {
                var sungBy = _context.SungBys.Where(x=>x.SongId == id).ToList();
                if(sungBy.Count != 0)
                {
                    foreach(var item in sungBy)
                    {
                        _context.SungBys.Remove(item);
                        _context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in DeleteSungBy: {ex.Message}");
                throw;
            }
        }
    }
}
