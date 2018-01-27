using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumni
{
    static class AlumniChallenge
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            XInputWrapper.XboxController.UpdateFrequency = 60;
            XInputWrapper.XboxController.StartPolling();
            Engine.Game.Initialize(new Level(), "Alumni Challenge", 1280, 720, 60);
        }
    }
}
