using System;
using System.Web;
using System.Web.Http;
using System.Web.Security;
 

namespace WebApi
{
    public class LoginController : BaseApiController
    {

        public BaseResult Get()
        { 
            try
            {  
                return new BaseResult() { IsSuccess=true }; 
            }
            catch (Exception ex)
            {
                
                throw ex;
            }

        }

        public BaseResult Post([FromBody]string value)
        {
            BaseResult baseResult = new BaseResult(); 
            try
            {
                HttpContextBase context = (HttpContextBase)Request.Properties["MS_HttpContext"];//获取传统context
                HttpRequestBase request = context.Request;//定义传统request对象 
                string account = request.Form["account"];
                string password = request.Form["password"];

                return baseResult;


            }
            catch (Exception ex)
            {
                 
                throw ex;
            }
        }


        public void Put(int id, [FromBody]string value)
        {
        }

        public void Delete(int id)
        {
        }

    }
}
