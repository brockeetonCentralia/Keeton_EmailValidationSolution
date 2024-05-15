using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailValidatorTest
{
    public class TestBase
    {
        public TestContext TestContext { get; set; }

        public T GetTestSettings<T>(string email, T defaultValue)
        {
            T result = defaultValue;

            try
            {
                var temp = TestContext.Properties[email];

                if (temp != null)
                {
                    result = (T)Convert.ChangeType(temp, typeof(T));
                }
            }

            catch { }

            return result;
        }

    }
}
