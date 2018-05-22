using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace DotnetCmd
{
    class Program
    {
        static void Main()
        {
            string fileName="shell/";

            //根据系统使用不同的shell文件
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                fileName += "win.bat";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                fileName += "linux.sh";
            }
            else
            {
                fileName += "OSX.sh";
            }
            //创建一个ProcessStartInfo对象 使用系统shell 指定命令和参数 设置标准输出
            var psi = new ProcessStartInfo(fileName) { RedirectStandardOutput = true };
            //启动
            var proc = Process.Start(psi);
            if (proc == null)
            {
                Console.WriteLine("Can not exec.");
            }
            else
            {
                Console.WriteLine("-------------Start read standard output--------------");
                //开始读取
                using (var sr = proc.StandardOutput)
                {
                    while (!sr.EndOfStream)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }

                    if (!proc.HasExited)
                    {
                        proc.Kill();
                    }
                }
                Console.WriteLine("---------------Read end------------------");
                Console.WriteLine($"Exited Code ： {proc.ExitCode}");
            }
        }
        static void Main2()
        {
            //创建一个ProcessStartInfo对象 使用系统shell 指定命令和参数 设置标准输出
            var psi = new ProcessStartInfo("dotnet", "--info") {RedirectStandardOutput = true};
            //启动
            var proc=Process.Start(psi);
            if (proc == null)
            {
                Console.WriteLine("Can not exec.");
            }
            else
            {
                Console.WriteLine("-------------Start read standard output--------------");
                //开始读取
                using (var sr = proc.StandardOutput)
                {
                    while (!sr.EndOfStream)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }

                    if (!proc.HasExited)
                    {
                        proc.Kill();
                    }
                }
                Console.WriteLine("---------------Read end------------------");
//                Console.WriteLine($"Total execute time :{(proc.ExitTime-proc.StartTime).TotalMilliseconds} ms");
                Console.WriteLine($"Exited Code ： {proc.ExitCode}");
            }
        }
    }
}
