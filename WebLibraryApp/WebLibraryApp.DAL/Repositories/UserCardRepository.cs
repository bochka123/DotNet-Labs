using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;
using WebLibraryApp.DAL.EF;
using WebLibraryApp.DAL.Entities;
using WebLibraryApp.DAL.Interfaces;


namespace WebLibraryApp.DAL.Repoositories
{
    class UserCardRepository : IRepository<UserCard>
    {

        private DataContext db;
        public UserCardRepository(DataContext context)
        {
            db = context;
        }
        public void Create(UserCard item)
        {
            db.UserCards.Add(item);
        }

        public void Delete(int id)
        {
            UserCard userCard = db.UserCards.Find(id);
            if (userCard != null)
            {
                db.UserCards.Remove(userCard);
            }
        }

        public IEnumerable<UserCard> Find(Expression<Func<UserCard, bool>> predicate)
        {
            return db.UserCards.Where(predicate).ToList();
        }

        public UserCard Get(int id)
        {
            return db.UserCards.Find(id);
        }

        public IEnumerable<UserCard> GetAll()
        {
            return db.UserCards;
        }

        public void Update(UserCard item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
