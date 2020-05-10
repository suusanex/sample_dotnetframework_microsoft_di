using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DITest;
using Microsoft.Extensions.DependencyInjection;

namespace DITest
{
    public static class FactoryMaker
    {
        public static IFactory Create()
        {
            return new FactoryClass();
        }
    }

    class FactoryClass : IFactory
    {
        public FactoryClass()
        {
            m_Collection.AddSingleton<IDITestClass, DITestClass>();
            m_Collection.AddSingleton<IDITestClass2, DITestClass2>();
            m_Provider = m_Collection.BuildServiceProvider();
        }

        private readonly ServiceCollection m_Collection = new ServiceCollection();
        private readonly ServiceProvider m_Provider;

        public void CreateInstance(out IDITestClass diTestClass)
        {
            diTestClass = m_Provider.GetRequiredService<DITest.IDITestClass>();
        }
    }
}
