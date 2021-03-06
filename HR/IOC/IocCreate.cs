﻿using System;
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
            ecf.ExeConfigFilename = @"C:\Users\童帝豪\source\repos\HR3\HR\UI\Unity.config";
            Configuration cf = ConfigurationManager.OpenMappedExeConfiguration(ecf, ConfigurationUserLevel.None);
            UnityConfigurationSection cfs = cf.GetSection("unity") as UnityConfigurationSection;
            ioc.LoadConfiguration(cfs, "containerTwo");
            return ioc;
        }

        #region 用户表ioc
        public static IusersDAO CreateusersDAO()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<IusersDAO, usersDAO>();
            return ioc.Resolve<IusersDAO>();
        }

        public static IusersBLL CreateusersBLL()
        {
            UnityContainer ioc = GetBLLSeciton();
            return ioc.Resolve<IusersBLL>("usersBLL");
        }
        #endregion
        #region 职位设置
        public static Iconfig_majorDAO Createconfig_majorDAO()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<Iconfig_majorDAO, config_majorDAO>();
            return ioc.Resolve<Iconfig_majorDAO>();
        }

        public static Iconfig_majorBLL Createconfig_majorBLL()
        {
            UnityContainer ioc = GetBLLSeciton();
            return ioc.Resolve<Iconfig_majorBLL>("config_majorBLL");
        }
        #endregion
        #region 职位分类设置
        public static Iconfig_major_kindDAO Createconfig_major_kindDAO()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<Iconfig_major_kindDAO, config_major_kindDAO>();
            return ioc.Resolve<Iconfig_major_kindDAO>();
        }

        public static Iconfig_major_kindBLL Createconfig_major_kindBLL()
        {
            UnityContainer ioc = GetBLLSeciton();
            return ioc.Resolve<Iconfig_major_kindBLL>("config_major_kindBLL");
        }
        #endregion
        #region 职称设置(只查职称)
        public static Iconfig_public_charDAO Createconfig_public_charDAO()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<Iconfig_public_charDAO, config_public_charDAO>();
            return ioc.Resolve<Iconfig_public_charDAO>();
        }

        public static Iconfig_public_charBLL Createconfig_public_charBLL()
        {
            UnityContainer ioc = GetBLLSeciton();
            return ioc.Resolve<Iconfig_public_charBLL>("config_public_charBLL");
        }  
        #endregion

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
        #region 一级
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
        #endregion

        #region 二级
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
        #endregion

        #region 三级
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
        #endregion

        public static Iengage_major_releaseDAO Createengage_major_releaseDAO()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<Iengage_major_releaseDAO, engage_major_releaseDAO>();
            return ioc.Resolve<Iengage_major_releaseDAO>();
        }

        public static Iengage_major_releaseBLL Createengage_major_releaseBLL()
        {
            UnityContainer ioc = GetBLLSeciton();
            return ioc.Resolve<Iengage_major_releaseBLL>("engage_major_releaseBLL");
        }

        public static Iengage_resumeDAO Createengage_resumeDAO()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<Iengage_resumeDAO, engage_resumeDAO>();
            return ioc.Resolve<Iengage_resumeDAO>();
        }

        public static Iengage_resumeBLL Createengage_resumeBLL()
        {
            UnityContainer ioc = GetBLLSeciton();
            return ioc.Resolve<Iengage_resumeBLL>("engage_resumeBLL");
        }

        public static Ihuman_fileDAO Createhuman_fileDAO()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<Ihuman_fileDAO, human_fileDAO>();
            return ioc.Resolve<Ihuman_fileDAO>();
        }

        public static Ihuman_fileBLL Createhuman_fileBLL()
        {
            UnityContainer ioc = GetBLLSeciton();
            return ioc.Resolve<Ihuman_fileBLL>("human_fileBLL");
        }

        public static Iengage_interviewDAO Createengage_interviewDAO()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<Iengage_interviewDAO, engage_interviewDAO>();
            return ioc.Resolve<Iengage_interviewDAO>();
        }

        public static Iengage_interviewBLL Createengage_interviewBLL()
        {
            UnityContainer ioc = GetBLLSeciton();
            return ioc.Resolve<Iengage_interviewBLL>("engage_interviewBLL");
        }

        public static Isalary_standardDAO Createsalary_standardDAO()
        {
            UnityContainer ioc = new UnityContainer();
            ioc.RegisterType<Isalary_standardDAO, salary_standardDAO>();
            return ioc.Resolve<Isalary_standardDAO>();
        }

        public static Isalary_standardBLL Createsalary_standardBLL()
        {
            UnityContainer ioc = GetBLLSeciton();
            return ioc.Resolve<Isalary_standardBLL>("salary_standardBLL");
        }

    }
}
