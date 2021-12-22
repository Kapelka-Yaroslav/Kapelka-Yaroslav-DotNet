using Students.Data.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Students.Data.Interfaces
{
    public interface IStudCont
    {

        public void Add(Student stud)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> toList()
        {
            throw new NotImplementedException();
        }

    }
}
