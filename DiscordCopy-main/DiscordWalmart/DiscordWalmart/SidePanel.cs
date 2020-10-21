using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace DiscordWalmart
{
    public class SidePanel: Panel
    {
        private List<ServerButton> serverButtons = new List<ServerButton>();
        public SidePanel(Control control)
        {
            this.Location = new Point(0, HeaderPanel.HeaderHeight);
            this.Width = control.Width / 15;
            this.Height = control.Height;
            this.BackColor = Color.FromArgb(45, 48, 71);//Space Cadet

            for(int i = 0; i < 3; ++i)
            {
                ServerButton serverButton = new ServerButton(this);
                serverButton.Location = new Point(0, i * serverButton.Height);
                this.serverButtons.Add(serverButton);
            }
            
            control.Controls.Add(this);
        }
    }
}
