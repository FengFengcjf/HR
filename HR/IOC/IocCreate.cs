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
            ecf.ExeConfigFilename = @"C:\Users\童帝豪\source\repos\HR2\HR\UI\Unity.config";
            Configuration cf = ConfigurationManager.OpenMappedExeConfiguration(ecf, ConfigurationUserLevel.None);
            UnityConfigurationSection cfs = cf.GetSection("unity") as UnityConfigurationSection;
            ioc.LoadConfiguration(cfs, "containerTwo");
            return ioc;
        }

        public static Iconfig_file_first_kindDAO Createconfig_file_first_kindDAO()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<Iconfig_file_first_kindDAO, config_file_first_kindDAO>();
            return ioc.Resolve<Iconfig_file_first_kindDAO>();
        }

        public static Iconfig_file_first_kindBLL Createconfig_file_first_kindBLL()
        {
            UnityContainer ioc = GetBLLSeciton();
            return ioc.Resolve<Iconfig_file_first_kindBLL>("config_file_first_kindBLL");
        }

        public static Iconfig_file_second_kindDAO Createconfig_file_second_kindDAO()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<Iconfig_file_second_kindDAO, config_file_second_kindDAO>();
            return ioc.Resolve<Iconfig_file_second_kindDAO>();
        }

        public static Iconfig_file_second_kindBLL Createconfig_file_second_kindBLL()
        {
            UnityContainer ioc = GetBLLSeciton();
            return ioc.Resolve<Iconfig_file_second_kindBLL>("config_file_second_kindBLL");
        }

        public static Iconfig_file_third_kindDAO Createconfig_file_third_kindDAO()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<Iconfig_file_third_kindDAO, config_file_third_kindDAO>();
            return ioc.Resolve<Iconfig_file_third_kindDAO>();
        }

        public static Iconfig_file_third_kindBLL Createconfig_file_third_kindBLL()
        {
            UnityContainer ioc = GetBLLSeciton();
            return ioc.Resolve<Iconfig_file_third_kindBLL>("config_file_third_kindBLL");
        }
    }
}
