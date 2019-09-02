using EFentity;
using IntDAO;
using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class usersDAO:DaoBase<users>, IusersDAO
    {
        static MyDbcontext db = CreateDbContext();

        //用于监测Context中的Entity是否存在，如果存在，将其Detach，防止出现问题。
        private Boolean RemoveHoldingEntityInContext(users entity)
        {
            var objContext = ((IObjectContextAdapter)db).ObjectContext;
            var objSet = objContext.CreateObjectSet<users>();
            var entityKey = objContext.CreateEntityKey(objSet.EntitySet.Name, entity);
            Object foundEntity;
            var exists = objContext.TryGetObjectByKey(entityKey, out foundEntity);

            if (exists)
            {
                objContext.Detach(foundEntity);
            }

            return (exists);

        }


        private static MyDbcontext CreateDbContext()
        {
            //从当前请求的线程取值
            db = CallContext.GetData("s") as MyDbcontext;
            if (db == null)
            {
                db = new MyDbcontext();
                //把上下文对象存入当前请求的线程中
                CallContext.SetData("s", db);
            }
            return db;
        }
        public List<usersModel> SelectBy(usersModel st)
        {
            List<users> list = SelectBy(e => e.Id.Equals(st.Id));
            List<usersModel> list2 = new List<usersModel>();
            foreach (var item in list)
            {
               usersModel sd = new usersModel()
                {
                   Id = item.Id,
                   u_name = item.u_name,
                   u_password = item.u_password,
                   u_true_name = item.u_true_name,
                   Gid = item.Gid
               };
                list2.Add(sd);
            }
            return list2;
        }
        public DataTable show()
        {
            string sql= "select u.Id,u.u_name,u.u_password,u.u_true_name, g.gname from [dbo].[users]u left join [dbo].[Guanli] g     on u.Gid=g.Id";
            return DBHelper.SelectTable(sql);
        }

        public usersModel Login(usersModel st)
        {
            //users u = new users();      
            //List<users> list = SelectBy(e => e.u_name.Equals(st.u_name) && e.u_password.Equals(st.u_password));
            //foreach (users item in list)
            //{
            //    if (item == null || item.Equals(""))
            //    {
            //        return 0;
            //    }
            //    else
            //    {
            //        return list[0].Id;

            //    }
            //}
            //return 0;

            var u = db.userss.Where(e => e.u_name.Equals(st.u_name) && e.u_password.Equals(st.u_password)).Select(e => e).ToList();
            foreach (var item in u)
            {
                usersModel us = new usersModel()
                {
                    Id=item.Id,
                    u_name=item.u_name,
                    u_password=item.u_password,
                    u_true_name=item.u_true_name,
                    Gid=item.Gid
                   
                   
                };
                return us;
            }
            return null;
        }
       

        public int Add(usersModel st)
        {
            //把DTO转为EO
            users est = new users()
            {
                Id = st.Id,
                u_name = st.u_name,
                u_password = st.u_password,
                u_true_name = st.u_true_name,
                Gid = st.Gid
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

        GuanliDAO d = new GuanliDAO();
        public List<Model.usersModel> Select()
        {          
            var result =db.Database.SqlQuery<usersModel>($@"select u.Id,u.u_name,u.u_password,u.u_true_name, g.gname  from  [dbo].[users]u left join [dbo].[Guanli] g   on u.Gid=g.Id").ToList();
            return result;
        }

        public Dictionary<string,object>  Fenye(int pageIndex)
        {
            int rows = 0;
            List<users> list = FenYe<int>(e => e.Id, e => e.Id > 0, ref rows, pageIndex, 3);
            List<usersModel> dt = new List<usersModel>();
            foreach (users item in list)
            {
                usersModel um = new usersModel()
                {
                    Id = item.Id  ,
                    u_name=item.u_name,
                    u_password=item.u_password,
                    u_true_name=item.u_true_name,
                    Gid=item. Gid         
                };

                if (item.Gid==1)
                {
                    um.gname = "人事专员";
                }else if (item.Gid == 2)
                {
                    um.gname = "人事经理";
                }             
                else if (item.Gid == 3)
                {
                    um.gname = "薪酬专员";
                }
                else if (item.Gid == 4)
                {
                    um.gname = "薪酬经理";
                }
                else if (item.Gid == 5)
                {
                    um.gname = "招聘专员";
                }
                else if (item.Gid == 6)
                {
                    um.gname = "招聘经理";
                }
                else if (item.Gid == 7)
                {
                    um.gname = "应聘者";
                }
                else if (item.Gid == 8)
                {
                    um.gname = "系统管理员";
                }
                else if (item.Gid == 9)
                {
                    um.gname = "CEO";
                }
                dt.Add(um);
            }
            //获取总行数
            List<users> list3 = db.userss.OrderBy(e => e.Id).Where(e => e.Id > 0).ToList();
            rows = list3.Count();
            //获取总页数
            double page = rows / 3.00;
            int pages = int.Parse(Math.Ceiling(page).ToString());
            Dictionary<string, object> di = new Dictionary<string, object>();
            di["dt"] = dt;
            di["rows"] = rows;
            di["pages"] = pages;
            return di;


        }


        public object JXMain(int gid, string fid)
        {
            string sql = "";
            if (fid != null)
            {
                //查询子集                   
                sql = string.Format(@"select* from 
[dbo].[Pop] q inner join   [dbo].[GuanliPop] rq on
q.id=rq.PopID where rq.GuanliID={0} and q.PID={1}", gid, fid);
            }
            else
            {
                //查询父集
                sql = string.Format(@"select* from 
[dbo].[Pop] q inner join   [dbo].[GuanliPop] rq on
q.id=rq.PopID where rq.GuanliID={0} and q.PID=0
", gid);
            }

            DataTable dt = DBHelper.SelectTable(sql);
            return JsonConvert.SerializeObject(dt);
        }



        public int Update(usersModel st)
        {
            users est = new users()
            {
                Id = st.Id,
                u_name = st.u_name,
                u_password = st.u_password,
                u_true_name = st.u_true_name,
                Gid = st.Gid
            };
            return Update(est);
        }
    }
}
