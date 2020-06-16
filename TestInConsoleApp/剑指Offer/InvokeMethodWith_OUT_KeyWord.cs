using System;
using System.Reflection;

namespace 剑指Offer
{
   
        public class InvokeMethodWith_OUT_KeyWord
        {
            public InvokeMethodWith_OUT_KeyWord()
            {
                String str = "aa";
                object[] parmsObj = new object[] { str };

                var testObj = new TestClass();
                Type actionType = testObj.GetType();
                MethodInfo method = actionType.GetMethod("test", new Type[] { Type.GetType("System.String&") });
                method.Invoke(testObj, parmsObj);
                Console.WriteLine(parmsObj[0]);

                object[] numberParmsObj = new object[] { 0 };
                MethodInfo numberMethod= actionType.GetMethod("TestNumber", new Type[] { Type.GetType("System.Int32&") });
                var result = numberMethod.Invoke(testObj, numberParmsObj);

                Console.WriteLine("number "+numberParmsObj[0]+"  return value "+result);
        }
        }


        public class TestClass
        {

            public int TestNumber(out int resultNumber)
            {
                resultNumber = 99;
                return 33;
            }
        public void test(out string str)
            {
                str = "test1";
            }

            public void test(string str)
            {
                str = "test2";
            }

        }
}