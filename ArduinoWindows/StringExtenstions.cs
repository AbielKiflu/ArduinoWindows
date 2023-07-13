 

namespace ArduinoWindows
{
    public static class StringExtenstions
    {

        public static int GetDeviceValue(this string value)
        {
            int val = -1;
            //Todo
            // -100 = format exception
            // -101 = undefined

            string[] valueSplited=value.Split(',');
            if (valueSplited.Length == 2)
            {
                try
                {
                    val = int.Parse(valueSplited[1]);
                    return val;
                }
                finally
                {
                    val= -100;
                     
                }
            }
            return -1;
        }



 

    }

}
