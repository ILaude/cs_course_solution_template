using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace NLog
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();


        static void Main(string[] args)
        {
            logger.Trace("Enter");
            logger.Debug("Kald til test1");
            test1(5, 5);
            logger.Debug("Tilbage fra test1");
            logger.Debug("Kald til test2");
            test2();
            logger.Debug("Tilbage fra test2");
            logger.Trace("Exit");
        }
        static void test1(int i, int x)
        {
            logger.Trace("Enter x, i :{0}, {1}", i, x);
            Console.WriteLine("Test1");
            System.Threading.Thread.Sleep(1000);
            logger.Trace("Exit");
        }
        static void test2()
        {
            logger.Trace("Enter");
            try
            {
                Console.WriteLine("Test2");
                throw new ApplicationException("Fejl");
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
            logger.Trace("Exit");
        }
    }
}
