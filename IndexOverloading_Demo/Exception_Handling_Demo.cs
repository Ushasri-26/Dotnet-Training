using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOverloading_Demo
{
    internal class Exception_Handling_Demo
    {
        public static void MethodDivide()
        {
            try
            {
                int x, y, z;
                Console.WriteLine("enter 2 numbers");
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
                z = x / y;
                Console.WriteLine($"Result: {z}");
            }
            catch (DivideByZeroException ex1)
            {
                throw new System.Exception($"Exception caught in Method divide by 0{ex1.Message} \n source :{ex1.Source}");
                throw ex1;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Console.WriteLine("End of the program");
            }
            Console.ReadLine();
        }
    }
}
