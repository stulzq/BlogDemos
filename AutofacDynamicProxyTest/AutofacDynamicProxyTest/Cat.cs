using System;
using Autofac.Extras.DynamicProxy;

namespace AutofacDynamicProxyTest
{
    public class Cat:ICat
    {
        public void Eat()
        {
            Console.WriteLine("猫在吃东西");
        }
    }
}