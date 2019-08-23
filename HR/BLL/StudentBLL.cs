using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lntBLL;
using Model;
using IntDAO;
using IOC;
namespace BLL
{
    public class StudentBLL: IStudentBLL
    {
        IStudentDAO ist = IocCreate.CreateStudenDAO();

        public List<StudentModel> SelectBy(StudentModel st)
        {
            return ist.SelectBy(st);
        }

        public int StudentAdd(StudentModel st)
        {
            return ist.StudentAdd(st);
        }

        public int StudentDel(StudentModel st)
        {
            return ist.StudentDel(st);
        }

        public List<StudentModel> StudentSelect()
        {
            return ist.StudentSelect();
        }

        public int StudentUpdate(StudentModel st)
        {
            return ist.StudentUpdate(st);
        }
    }
}
