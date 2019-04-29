using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

using Rimid.Library.Models.Enums;

namespace Rimid.Library.Models.Repository
{
    public class UserRepository
    {
        private readonly LibraryEntities _context;

        public UserRepository(LibraryEntities context)
        {
            _context = context;
        }

        public User Get(int id)
        {
            return _context.Users
                .AsNoTracking()
                .FirstOrDefault(x => x.Id == id);
        }

        public IReadOnlyCollection<User> GetObjects()
        {
            return _context.Users
                .AsNoTracking()
                .ToArray();
        }

        public IReadOnlyCollection<User> GetAdministrators()
        {
            return _context.Users
                .AsNoTracking()
                .Where(x => x.PositionId == (int)PositionEnum.Administrator)
                .ToArray();
        }

        public int Save(User user)
        {
            var isExisted = _context.Users.Any(x => x.Id == user.Id);

            return !isExisted
                ? Add(user) 
                : Update(user);
        }

        public int Add(User user)
        {
            var existedUserByLogin = _context.Users.FirstOrDefault(x => x.Login == user.Login);

            if (existedUserByLogin != null)
            {
                return existedUserByLogin.Id;
            }

            var entity = _context.Users.Add(user);

            _context.SaveChanges();

            return entity.Id;
        }

        public int Update(User user)
        {
            var entity = _context.Users.First(x => x.Id == user.Id);
            
            _context.Entry(entity).CurrentValues.SetValues(user);

            _context.SaveChanges();

            return user.Id;
        }

        public void Delete(int id)
        {
            var entity = _context.Users.FirstOrDefault(x => x.Id == id);

            if (entity == null) return;

            _context.Users.Remove(entity);
        }
    }
}
