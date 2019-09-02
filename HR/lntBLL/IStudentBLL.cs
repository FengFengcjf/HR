using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lntBLL
{
    public interface IStudentBLL
    {
        int StudentAdd(StudentModel st);
        int StudentDel(StudentModel st);
        int StudentUpdate(StudentModel st);
        List<StudentModel> StudentSelect();
            List<StudentModel> SelectBy(StudentModel st);
    }
}
