using System;
using System.Collections.Generic;
using System.Text;
using NLog;

namespace DITest
{
    public class DITestClass2 : IDITestClass2
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public DITestClass2()
        {
            Logger.Info($"{nameof(DITestClass2)} Construct");
        }

        public void TestCall()
        {
            Logger.Info($"{nameof(DITestClass2)} TestCall");
        }
    }
}
