using EFentity;
using IntDAO;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class StudentDAO : DaoBase<Student>, IStudentDAO
    {
        public List<StudentModel> SelectBy(StudentModel st)
        {
            List<Student> list = SelectBy(e => e.Id.Equals(st.Id));
            List<StudentModel> list2 = new List<StudentModel>();
            foreach (var item in list)
            {
                StudentModel sd = new StudentModel()
                {
                    Id =item.Id,
                    Name=item.Name
                };
                list2.Add(sd);
            }
            return list2;
        }

        public int StudentAdd(StudentModel st)
        {
            //把DTO转为EO
            Student est = new Student()
            {
                Id = st.Id,
                Name = st.Name
            };
            return Add(est);
        }

        public int StudentDel(Model.StudentModel st)
        {
            Student est = new Student()
            {
                Id = st.Id

            };
            return Delete(est);
        }

        public List<Model.StudentModel> StudentSelect()
        {
            List<Student> list = SelectAll();
            List<StudentModel> list2 = new List<StudentModel>();
            foreach (Student item in list)
            {
                StudentModel sm = new StudentModel()
                {
                    Id = item.Id,
                    Name = item.Name
                };
                list2.Add(sm);
            }
            return list2;
        }

        public int StudentUpdate(StudentModel st)
        {
            Student est = new Student()
            {
                Id = st.Id,
                Name = st.Name
            };
            return Update(est);
        }

   

      
    }
}
