using System;

namespace Algorithms.Helper
{
    // 计时器
    public class StopWatch
    {
        private DateTime start;

        
        // 初始化一个计时器
        public StopWatch()
        {
            start = DateTime.Now;
             
        }

        // 返回一个运行时间，从计时器创建开始的运行时间
        public double elapsedTime()
        {
            DateTime end = DateTime.Now;
            TimeSpan elapsedTime = end - start;
            return elapsedTime.TotalSeconds;
        }
    }
}
