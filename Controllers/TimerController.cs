using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class TimerController : Controller
    {
        #region 调度方法
        public IActionResult Timer1()
        {
            Timer timer = new Timer(new TimerCallback(TestTimer));
            DateTime dateTime = DateTime.Now.AddSeconds(10); 
            System.Diagnostics.Debug.WriteLine(DateTime.Now.ToString());
            bool v = timer.Change((int)10*1000, Timeout.Infinite);
            //bool v1 = timer.Change(dateTime.Subtract(DateTime.Now), Timeout.InfiniteTimeSpan);
            bool v2 = timer.Change(TimeSpan.FromSeconds(10), Timeout.InfiniteTimeSpan);

            return Content("完成");
        }
        #endregion

        #region 需要被定时调用的方法
        public void TestTimer(Object state)
        {

            System.Diagnostics.Debug.WriteLine("just do it"+DateTime.Now.ToString());
            
        }
        #endregion
    }
}
