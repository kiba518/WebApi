using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi
{   
    public class BaseResult
    {
        public string Title { get; set; } 
        public string Message { get; set; } 
        public bool IsSuccess { get; set; } 
    }
}
