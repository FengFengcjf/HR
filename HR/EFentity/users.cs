using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFentity
{
    public class users
    {  

        public System.Int32 Id
        {
          get;set;
        }
        [Required(ErrorMessage = "���Ʋ���Ϊ��!")]

        public System.String u_name
        {
          get;set;
        }

        [Required(ErrorMessage = "��ʵ��������Ϊ��!")]
        
        public System.String u_true_name
        {
          get;set;
        }

        [Required(ErrorMessage = "���벻��Ϊ��!")]
        [StringLength(maximumLength: 20, ErrorMessage = "���벻�ܳ���20λ����")]//�涨����
        public System.String u_password
        {
          get;set;
        }

        public System.Int32 Gid
        {
            get; set;
        }     
    }
}
