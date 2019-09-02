using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFentity;
using Model;
using IntDAO;
using System.Data.Entity.Infrastructure;
using System.Runtime.Remoting.Messaging;

namespace DAO
{
 public   class GuanliDAO:DaoBase<Guanli> ,IGuanliDAO
    {
        static MyDbcontext db = CreateDbContext();

        //用于监测Context中的Entity是否存在，如果存在，将其Detach，防止出现问题。
        private Boolean RemoveHoldingEntityInContext(Guanli entity)
        {
            var objContext = ((IObjectContextAdapter)db).ObjectContext;
            var objSet = objContext.CreateObjectSet<Guanli>();
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


        public List<GuanliModel> SelectBy(GuanliModel st)
        {
            List<Guanli> list = SelectBy(e => e.Id.Equals(st.Id));
            List<GuanliModel> list2 = new List<GuanliModel>();
            foreach (var item in list)
            {
                GuanliModel sd = new GuanliModel()
                {
                    Id = item.Id,
                    gname = item.gname,
                    Explain=item.Explain,
                    Available=item.Available
                };
                list2.Add(sd);
            }
            return list2;
        }

        public int Add(GuanliModel st)
        {
            //把DTO转为EO
            Guanli est = new Guanli()
            {
                Id = st.Id,
               gname = st.gname,
               Explain=st.Explain,
               Available=st.Available

              
            };
            return Add(est);
        }

        public int Del(Model.GuanliModel st)
        {
            Guanli est = new Guanli()
            {
                Id = st.Id

            };
            return Delete(est);
        }

        public List<Model.GuanliModel> Select()
        {
            List<Guanli> list = SelectAll();
            List<GuanliModel> list2 = new List<GuanliModel>();
            foreach (Guanli item in list)
            {
                GuanliModel sm = new GuanliModel()
                {
                    Id = item.Id,
                    gname = item.gname
                    ,Explain=item.Explain,
                    Available=item.Available
                };
                list2.Add(sm);
            }
            return list2;
        }

        public int Update(GuanliModel st)
        {
            Guanli est = new Guanli()
            {
                Id = st.Id,
                gname = st.gname,
                Explain=st.Explain,
                Available=st.Available
            };
            return Update(est);
        }
        public Dictionary<string, object> Fenye(int pageIndex)
        {
            int rows = 0;
            List<Guanli> list = FenYe<int>(e => e.Id, e => e.Id > 0, ref rows, pageIndex, 3);
            List<GuanliModel> dt = new List<GuanliModel>();
            foreach (Guanli item in list)
            {
                GuanliModel um = new GuanliModel()
                {
                    Id = item.Id,
                    gname=item.gname,
                    Explain=item.Explain,
                    Available=item.Available
                };          
                dt.Add(um);
            }
            //获取总行数
            List<Guanli> list3 = db.Guanlis.OrderBy(e => e.Id).Where(e => e.Id > 0).ToList();
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

    }
}
