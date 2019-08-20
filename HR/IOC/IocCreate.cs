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
        public static ISstandard_detailsDAO Createstandard_detailsDAO()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<ISstandard_detailsDAO, standard_detailsDAO>();
            return ioc.Resolve<ISstandard_detailsDAO>();
        }

        public static ISstandard_detailsBLL Createstandard_detailsBLL()
        {
            UnityContainer ioc = GetBLLSeciton();
            return ioc.Resolve<ISstandard_detailsBLL>("standard_detailsBLL");
        }




        public static ISpublic_charDAO Createpublic_charDAO()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<ISpublic_charDAO, public_charDAO>();
            return ioc.Resolve<ISpublic_charDAO>();
        }

        public static ISpublic_charBLL Createpublic_charBLL()
        {
            UnityContainer ioc = GetBLLSeciton();
            return ioc.Resolve<ISpublic_charBLL>("public_charBLL");
        }


        private static UnityContainer GetBLLSeciton()
        {
            UnityContainer ioc = new UnityContainer();
            ExeConfigurationFileMap ecf = new ExeConfigurationFileMap();
            ecf.ExeConfigFilename = @"C:\Users\lenovo\Source\Repos\HR3\HR\UI\Unity.config";
            Configuration cf = ConfigurationManager.OpenMappedExeConfiguration(ecf, ConfigurationUserLevel.None);
            UnityConfigurationSection cfs = cf.GetSection("unity") as UnityConfigurationSection;
            ioc.LoadConfiguration(cfs, "containerTwo");
            return ioc;
        }
    }
}
