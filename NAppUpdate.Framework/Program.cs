﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAppUpdate.Framework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            var titleAttribute = assembly.GetCustomAttributes(typeof(System.Reflection.AssemblyTitleAttribute), false).FirstOrDefault() as System.Reflection.AssemblyTitleAttribute;
            string title = titleAttribute?.Title;
            string version = assembly.GetName().Version.ToString();
            Console.WriteLine(string.Format($"Assembly Title: {title}"));
            Console.WriteLine(string.Format($"Assembly Version: {version}"));
            Console.ReadLine();
        }
    }
}
