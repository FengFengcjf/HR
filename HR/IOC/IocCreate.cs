using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using lntBLL;
using IntDAO;
using DAO;
using System.Configuration;
using Microsoft.Practices.Unity.Configuration;
namespace IOC
{
    public class IocCreate
    {
        public static IStudentDAO CreateStudenDAO()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<IStudentDAO, StudentDAO>();
            return ioc.Resolve<IStudentDAO>();
        }

        public static IStudentBLL CreateStudentBLL()
        {
            UnityContainer ioc = GetBLLSeciton();
            return ioc.Resolve<IStudentBLL>("StudentBLL");
        }

        private static UnityContainer GetBLLSeciton()
        {
            UnityContainer ioc = new UnityContainer();
            ExeConfigurationFileMap ecf = new ExeConfigurationFileMap();
            ecf.ExeConfigFilename = @"D:\VS\阶段四\HR\UI\Unity.config";
            Configuration cf = ConfigurationManager.OpenMappedExeConfiguration(ecf, ConfigurationUserLevel.None);
            UnityConfigurationSection cfs = cf.GetSection("unity") as UnityConfigurationSection;
            ioc.LoadConfiguration(cfs, "containerTwo");
            return ioc;
        }
    }
}
