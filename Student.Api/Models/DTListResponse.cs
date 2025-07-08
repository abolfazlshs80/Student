
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Api.Models
{

    public class DTListResponse<T>
    {
        public int TotalRecords { get; set; }
        public T Data { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
    }
}
