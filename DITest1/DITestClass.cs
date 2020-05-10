using System;
using System.Collections.Generic;
using System.Text;
using NLog;

namespace DITest
{
    public class DITestClass : IDITestClass
    {
        private IDITestClass2 _diTestClass2;

        //複数の該当コンストラクタがある場合、引数が多い方が呼ばれる
        public DITestClass()
        {
            Logger.Info($"{nameof(DITestClass)} Construct");
        }

        public DITestClass(IDITestClass2 diTestClass2)
        {
            Logger.Info($"{nameof(DITestClass)} Construct Param");
            _diTestClass2 = diTestClass2;
        }

        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public void TestCall()
        {
            Logger.Info($"{nameof(DITestClass)} TestCall");
            _diTestClass2?.TestCall();
        }
    }
}
