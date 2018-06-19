using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDCreator
{
    public partial class charScreen1 : UserControl
    {
        public string raceChoose, classChoose, backChoose;


        public charScreen1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            //adds properties to list
            Form1.newCharacter.race = raceBox.Text;
            Form1.newCharacter.type = typeBox.Text;
            Form1.newCharacter.background = backBox.Text;

            Form f = this.FindForm();
            f.Controls.Remove(this);
            charScreen2 cs2 = new charScreen2();
            f.Controls.Add(cs2);
        }

    }
}
