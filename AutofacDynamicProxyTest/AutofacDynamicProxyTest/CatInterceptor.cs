using System;
using Castle.DynamicProxy;

namespace AutofacDynamicProxyTest
{
    public class CatInterceptor:IInterceptor
    {
        private readonly ICat _cat;

        /// <summary>
        /// 通过依赖注入 注入ICat的具体实现
        /// </summary>
        /// <param name="cat"></param>
        public CatInterceptor(ICat cat)
        {
            _cat = cat;
        }
        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine("喂猫吃东西");

            invocation.Method.Invoke(_cat, invocation.Arguments);//调用Cat的指定方法
        }
    }
}