using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Test
{
    public class ParamsTest
    {
        //public static void Main(string[] args)
        //{

        //    int[] a = paramDemo(1, 2, 3, 4);
        //    Console.WriteLine(a.Length);
        //    int[] arr = { 1, 2, 3, 4, 5, 6 };
        //    int[] b = paramDemo(arr);
        //    Console.WriteLine(b.Length);
        //    Console.ReadLine();
        //}
        /// <summary>
        /// 可变参数，在参数前面添加params关键字，比如
        /// 下面方法是要传入一个int数组类型。那么，加入params后
        /// 调用的时候直接传入一个 例如pparamDemo(1,2,3)这样一个 数组也是不会报错的
        /// 但是注意参数列表必须是参数的最后一个参数才可以
        /// </summary>
        /// <param name="arr"></param>
        public static int[] paramDemo(params int[] arr)
        {
            return arr;
        }

    }
}
