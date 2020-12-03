using System;

namespace SystemsUnderTest
{
    public class DateHelper
    {
        public string ConvertDateToString(DateTime datetime)
        {
            return datetime.Date.ToString();
        }
    }
}
