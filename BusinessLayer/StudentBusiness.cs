using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class StudentBusiness
    {
        private readonly StudentRepository studentRepository;

        public StudentBusiness()
        {
            this.studentRepository = new StudentRepository();
        }
        public List<Student> GetAllStudents() 
        {
            return this.studentRepository.GetAllStudents();
        }
        public void EnableInsert(Student a)
        {
            this.studentRepository.AddStudent(a);
        }
        public List<Student> GreaterThenAVER(Decimal Averag)
        {
            return GetAllStudents().Where(s => s.Average > Averag).ToList();
        }
       
    }
}
