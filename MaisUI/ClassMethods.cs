using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaisUI
{
    internal class ClassMethods
    {
        private static bool isMinimized = false;

        internal static void LogOutFunction()
        {
            DialogResult result = MessageBox.Show("Do you really want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("You have successfully logged out.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        internal static void ExitApp()
        {
            DialogResult result = MessageBox.Show("Do you really want to exit the application?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("You have successfully terminated the application", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        internal static void ToggleMinimize(Form form)
        {
            if (isMinimized)
            {
                form.WindowState = FormWindowState.Normal;
                isMinimized = false;
            }
            else
            {
                form.WindowState = FormWindowState.Maximized;
                form.WindowState = FormWindowState.Minimized;
                isMinimized = true;
            }
        }
    }
}
