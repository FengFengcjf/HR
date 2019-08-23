using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class config_file_first_kindModel
    {
        public System.Int16 Id { get; set; }
        [Required(ErrorMessage = "编号不能为空")]
        [StringLength(maximumLength: 2, ErrorMessage = "名称不能超过2位长度")]
        public string first_kind_id { get; set; }
        [Required(ErrorMessage = "名称不能为空")]
        public string first_kind_name { get; set; }
    
        public string first_kind_salary_id { get; set; }

        public string first_kind_sale_id { get; set; }
    }
}
