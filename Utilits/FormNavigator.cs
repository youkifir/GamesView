using System;
using System.Windows.Forms;

namespace GamesView.Utilits
{
    public static class FormNavigator
    {
        public static void Switch(Form current, Form next)
        {
            next.StartPosition = FormStartPosition.Manual;
            next.Location = current.Location;
            next.Size = current.Size;
            next.WindowState = current.WindowState;

            next.Show();
            current.Close();
        }

        public static void OpenAsDialog(Form current, Form next)
        {
            next.StartPosition = FormStartPosition.Manual;
            next.Location = current.Location;
            next.Size = current.Size;

            current.Enabled = false;
            next.ShowDialog();
            current.Enabled = true;

            current.Activate();
        }
    }
}