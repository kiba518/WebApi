
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Security;
 
namespace WebApi
{
    public class AuthenticationApiController : BaseApiController
    {

        public BaseResult Get()
        { 
            try
            {
                HttpContextBase context = (HttpContextBase)Request.Properties["MS_HttpContext"];//获取传统context
                HttpRequestBase request = context.Request;//定义传统request对象  
                var dpaCookie = request.Cookies["webapi_authentication"];
                //var webapi_authentication = request["webapi_authentication"];
                var ticket = FormsAuthentication.Decrypt(dpaCookie.Value);
                var name = ticket.Name;
                if (!string.IsNullOrWhiteSpace(name))
                {
                    return new BaseResult() { IsSuccess = true }; 
                }
                else
                {
                    return new BaseResult() { IsSuccess = false }; 
                }
              
            }
            catch (Exception ex)
            {
                
                throw ex;
            } 
        }

        public BaseResult Post([FromBody]string value)
        {
            throw new Exception("请求异常");
        }


        public void Put(int id, [FromBody]string value)
        {
            throw new Exception("请求异常");
        }

        public void Delete(int id)
        {
            throw new Exception("请求异常");
        }

    }
}
