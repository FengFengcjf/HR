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
    public class usersDAO:DaoBase<users>, IusersDAO
    {
          public List<usersModel> SelectBy(usersModel st)
        {
            List<users> list = SelectBy(e => e.Id.Equals(st.Id));
            List<usersModel> list2 = new List<usersModel>();
            foreach (var item in list)
            {
               usersModel sd = new usersModel()
                {
                    Id =item.Id
                };
                list2.Add(sd);
            }
            return list2;
        }

        public int Add(usersModel st)
        {
            //把DTO转为EO
            users est = new users()
            {
                Id = st.Id
            };
            return Add(est);
        }

        public int Del(Model.usersModel st)
        {
            users est = new users()
            {
                Id = st.Id

            };
            return Delete(est);
        }

        public List<Model.usersModel> Select()
        {
            List<users> list = SelectAll();
            List<usersModel> list2 = new List<usersModel>();
            foreach (users item in list)
            {
                usersModel sm = new usersModel()
                {
                    Id = item.Id,
                    u_name=item.u_name,
                    u_password=item.u_password,
                    u_true_name=item.u_true_name
                };
                list2.Add(sm);
            }
            return list2;
        }

    

        public int Update(usersModel st)
        {
            users est = new users()
            {
                Id = st.Id
            };
            return Update(est);
        }
    }
}
