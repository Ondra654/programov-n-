using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AZ_Quiz
{
    public partial class GameMenu : Form
    {
        public GameMenu()
        {
            InitializeComponent();
        }
        private void GameMenu_Load(object sender, EventArgs e)
        {
            BackColor = Color.Orange;
            Size= new Size(650, 550);
        }

        private void PVP_Click(object sender, EventArgs e)
        {
            Application.Run(new AZ_Quiz());
        }

        private void Solo_Click(object sender, EventArgs e)
        {

        }

        private void SMT_Click(object sender, EventArgs e)
        {

        }
    }
}
