using System;

namespace AutofacDynamicProxyTest
{
    public class CatProxy:ICat
    {
        private readonly ICat _cat;
        public CatProxy(ICat cat)
        {
            _cat = cat;
        }
        public void Eat()
        {
            Console.WriteLine("猫吃东西之前");
            _cat.Eat();
            Console.WriteLine("猫吃东西之后");
        }
    }
}