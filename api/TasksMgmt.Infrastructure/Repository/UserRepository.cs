using System.Linq.Expressions;
using TasksMgmt.Core.Entities;
using TasksMgmt.Core.Interfaces;
using TasksMgmt.Infrastructure.Data;

namespace TasksMgmt.Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly TasksDBContext _context;
        public UserRepository(TasksDBContext context) 
        {
            _context = context;
        }
        public User CreateAsync(User entity)
        {
            _context.Users.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public void DeleteAsync(Guid id)
        {
            var user = GetByGuidAsync(id);
            _context.Users.Remove(user);
            _context.SaveChanges();
        }

        public IQueryable<User> GetAllAsync()
        {
            return _context.Users;
        }

        public IQueryable<User> SelectAsync(Expression<Func<User, bool>> predicate)
        {
            return _context.Users.Where(predicate);
        }

        public User GetByGuidAsync(Guid guid)
        {
            return _context.Users.SingleOrDefault(x => x.Id == guid) ?? new User();
        }

        public User UpdateAsync(User entity)
        {
           _context.Users.Update(entity);
           _context.SaveChanges();
           return entity;
        }
    }
}
