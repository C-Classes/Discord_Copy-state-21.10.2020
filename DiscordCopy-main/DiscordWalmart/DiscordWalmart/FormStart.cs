using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordWalmart
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;

            HeaderPanel header = new HeaderPanel(this);
            SidePanel sidepanel = new SidePanel(this);

            Label label1 = new Label();
            Label label2 = new Label();
        }
    }
}
