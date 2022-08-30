using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myparameter
{
    class Program
    {
        static int call_by_value(int parameter)
        {
            parameter++;

            return parameter;
        }

        static int call_by_reference(ref int parameter)
        {
            parameter = parameter + 5;

            return parameter;
        }

        static int call_by_output(out int parameter)
        {
            parameter = 10;   // output傳入後，需給予初始值才可運算
            parameter = parameter*5;

            return parameter;
        }

        static int call_by_array(int[] parameter)
        {
            parameter[0] = 9;

            parameter[1] = 8;

            return parameter[0];
        }

        static void Main(string[] args)
        {
            int target = 10; 
            int out_target;  // out 參數傳遞之前不需要初始值
            int[] array_item = new int[] { 1,2 };

            // call by value
            call_by_value(target);
            Console.WriteLine("after by value：" + target.ToString());

            // call by reference
            call_by_reference(ref target);
            Console.WriteLine("after by reference：" + target.ToString());

            // call by output
            call_by_output(out out_target);
            Console.WriteLine("after by output：" + out_target.ToString());

            // call by array
            call_by_array(array_item);
            Console.WriteLine("after by array：" + array_item[0].ToString() +","+ array_item[1].ToString());

            Console.WriteLine("按任意鍵離開");
            Console.ReadKey();
        }
    }
}
