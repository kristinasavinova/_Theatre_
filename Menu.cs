using System;
using System.Windows.Forms;

namespace Theatre
{
    public partial class Menu : Form
    {
        public Menu()
        {            
            InitializeComponent();
        }      
        
        private void Events_Click(object sender, EventArgs e)
        {
            Events Event = new Events();
            Event.ShowDialog();
        }
        
        private void Actors_Click(object sender, EventArgs e)
        {
            Actors Actor = new Actors();
            Actor.ShowDialog();
        }
    }
}
