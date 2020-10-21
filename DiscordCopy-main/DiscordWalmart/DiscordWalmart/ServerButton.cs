using System.Drawing;
using System.Windows.Forms;

namespace DiscordWalmart
{
    public class ServerButton : Button
    {
        private int _maxWidth;
        private int _minWidth;



        private Panel designPanel = new Panel();
        private bool _onHover = false;

        private Timer _animationTimer = new Timer();
       
        public ServerButton (Control control)
        {
            _maxWidth = control.Width / 10;
            _minWidth = 0;

            this.Width = control.Width;
            this.Height = control.Height / 10;
            this.BackColor = Color.White;
            this.FlatAppearance.BorderSize = 0;
            this.FlatStyle = FlatStyle.Flat;

            _animationTimer.Interval = 1;
            _animationTimer.Tick += _animationTimer_Tick;

            designPanel.BackColor = Color.FromArgb(88, 135, 255);
            designPanel.Width = _minWidth;
            designPanel.Height = control.Height;
            this.Controls.Add(designPanel);

            this.MouseEnter += ServerButton_MouseEnter;
            this.MouseLeave += ServerButton_MouseLeave;

            control.Controls.Add(this);
        }

        private void _animationTimer_Tick(object sender, System.EventArgs e)
        {
            if (_onHover == true)
                if (designPanel.Width < _maxWidth)
                    ++designPanel.Width;
                else _animationTimer.Stop();
            else
                if (designPanel.Width > _minWidth)
                    --designPanel.Width;
            else _animationTimer.Stop();
        }

        private void ServerButton_MouseLeave(object sender, System.EventArgs e)
        {
            _onHover = false;
            _animationTimer.Start();
        }

        private void ServerButton_MouseEnter(object sender, System.EventArgs e)
        {
            _onHover = true;
            _animationTimer.Start();
        }
    }
}
