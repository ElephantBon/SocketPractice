using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp
{
    // ref:https://stackoverflow.com/questions/3167617/determine-if-code-is-running-as-part-of-a-unit-test
    internal class UnitTestDetector    {

        private static bool _runningFromNUnit = false;

        static UnitTestDetector()
        {
            foreach(Assembly assem in AppDomain.CurrentDomain.GetAssemblies()) {
                // Can't do something like this as it will load the nUnit assembly
                // if (assem == typeof(NUnit.Framework.Assert))

                if(assem.FullName.ToLowerInvariant().StartsWith("xunit")) {
                    _runningFromNUnit = true;
                    break;
                }
            }
        }

        public static bool IsRunningFromNUnit {
            get { return _runningFromNUnit; }
        }
    }
}
