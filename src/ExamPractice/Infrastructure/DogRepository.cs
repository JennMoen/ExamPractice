using ExamPractice.Data;
using ExamPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamPractice.Infrastructure
{    //repository is the level that queries the database and gets data from it
    public class DogRepository
    {
        //Don't forget dependency injection--you need to inject ApplicationDbContext so your repository knows what it is--won't worth without it
        private ApplicationDbContext _db;

        public DogRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        //query for returning a list of dogs from database
        public IQueryable<Dog> GetDogs()
        {
            return from d in _db.Dogs
            select d;
        }


    }
}
