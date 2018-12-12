﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulationRestaurant
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        [STAThread]
        public static void Launch()
        {
            using (var game = new Game1())
                game.Run();
        }

        public static void Stop()
        {
            using (var game = new Game1())
                game.Exit();
        }
    }
}
