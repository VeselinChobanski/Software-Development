using RegisterAndLoginFirst.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegisterAndLoginFirst.Repository;

public class UserRepository : IUserRepositiry
{
    readonly UserContext _context;
    public UserRepository(UserContext context)
    {
        _context = context;
    }
    public void Add(User item)
    {
        _context.Users.Add(item);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        _context.Users.Remove(GetById(id));
        _context.SaveChanges();
    }

    public List<User> GetAll()
    {
        return _context.Users.ToList();
    }

    public User GetById(int id)
    {
        return _context.Users.FirstOrDefault(x => x.UserId == id);
    }

    public void Update(int id, User newEntity)
    {
        User currentUser = GetById(id);
        currentUser.Username = newEntity.Username;
        currentUser.Password = newEntity.Password;
        currentUser.UserId = newEntity.UserId;
        _context.SaveChanges();
    }
}
