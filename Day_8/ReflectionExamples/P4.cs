using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExamples
{

    public class TestNew
    {
        [DllImport("user32.dll", EntryPoint = "MessageBox")]
        public static extern int ShowMessageBox(int hWnd, string text, string caption, uint type);

    }
    internal class P4
    {
        static void Main()
        {
            string caption = "Hello World...!";
            string msg = "This is Sample Dialog Box Created by Console App";
            TestNew.ShowMessageBox(0, caption, msg, 2);
        }
    }
}
