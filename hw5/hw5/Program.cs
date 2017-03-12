﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using hw5.Controllers;

namespace hw5
{
    static class Program
    {
       
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var view = new ExamForm();
            var controller = new ExamController(view);
            Application.Run(view);
        }
    }
}
