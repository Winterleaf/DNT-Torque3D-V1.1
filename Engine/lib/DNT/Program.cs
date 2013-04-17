using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WinterLeaf;
using System.Runtime.InteropServices;
namespace WinterLeaf.DotNetTorque
    {
    static class Program
        {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
            {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            dnTorque d = new dnTorque();
            //GCHandle f = GCHandle.Alloc(d, GCHandleType.Pinned);

            d.InitializeTorque(
    new string[] { "-dedicated", "-mission", "levels/elf_isle.mis" },
    "GameScripts.Main",
    @"C:\Torque\DotNetConnect\GameScripts\GameScripts\bin\Release\",
    @"GameScripts.dll");
            }
        }
    }
