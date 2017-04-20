using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamPractice.Services.Models
{   //DTO = Data Transfer Object; it's the view model you're going to pass to the front end
    public class DogDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        //my DTO looks just like my database model--that's ok if you don't have any protected fields you need to leave in the database

    }
}
