using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            current.Hide();
        }
    }
}
