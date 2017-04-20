using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamPractice.Models
{
    public class Dog
    {
        //always assign an ID property to each class so it can have a unique identifier in the database
        public int Id { get; set; }

        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }

    }
}
