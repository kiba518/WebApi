using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Configuration;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;


namespace Web
{ 
    /*
     这是一个AOP的过滤器，在执行WebApi之前，会先进入这里进行过滤，过滤通过的API，才允许调用和执行。
    */
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, Inherited = true, AllowMultiple = true)]
    public class WebApiAttribute : ActionFilterAttribute
    { 
        public override void OnActionExecuting(HttpActionContext actionContext)
        { 
            //API执行前触发
            if (true)//当前设置，所有API都可以被调用
            {
                base.OnActionExecuting(actionContext);
            }
            else
            {
                throw new Exception("Error");
            }

        } 
         
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            //API执行后触发 若发生例外则不在这边处理
            if (actionExecutedContext.Exception != null)
                return;

            base.OnActionExecuted(actionExecutedContext);
        }
    }
}