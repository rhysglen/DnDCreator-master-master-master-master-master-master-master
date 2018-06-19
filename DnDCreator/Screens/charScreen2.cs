using System;
using System.Windows.Forms;

namespace DnDCreator
{
    public partial class charScreen2 : UserControl
    {
        //random roll maker for ability scores

        Random rollGen = new Random();

        int dice1,dice2,dice3,dice4;

        int scoreNum = 1;

        int strSum, dexSum, constSum, intSum, wisSum, chaSum;

        private void char2BackButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            charScreen1 cs1 = new charScreen1();
            f.Controls.Add(cs1);
        }

        private void char2NextButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            charScreen3 cs3 = new charScreen3();
            f.Controls.Add(cs3);
        }

        int click = 5;

        public charScreen2()
        {
            InitializeComponent();

            strSum = Form1.newCharacter.strength;
            dexSum = Form1.newCharacter.dexterity;
            constSum = Form1.newCharacter.constitution;
            intSum = Form1.newCharacter.inteligence;
            wisSum = Form1.newCharacter.wisdom;
            chaSum = Form1.newCharacter.charisma;
           
        }
       
        private void rollButton_Click(object sender, EventArgs e)
        {
            click--;

            for (int i = 0; i < 6; i++)
            {
                switch (scoreNum)
                {
                    case 1:

                        dice1 = rollGen.Next(1, 7);
                        dice2 = rollGen.Next(1, 7);
                        dice3 = rollGen.Next(1, 7);
                        dice4 = rollGen.Next(1, 7);

                        strSum = dice1 + dice2 + dice3 + dice4;

                        strLabel.Text = Convert.ToString(strSum);

                        break;
                    case 2:

                        dice1 = rollGen.Next(1, 7);
                        dice2 = rollGen.Next(1, 7);
                        dice3 = rollGen.Next(1, 7);
                        dice4 = rollGen.Next(1, 7);

                        dexSum = dice1 + dice2 + dice3 + dice4;

                        dexLabel.Text = Convert.ToString(dexSum);

                        break;
                    case 3:

                        dice1 = rollGen.Next(1, 7);
                        dice2 = rollGen.Next(1, 7);
                        dice3 = rollGen.Next(1, 7);
                        dice4 = rollGen.Next(1, 7);

                        constSum = dice1 + dice2 + dice3 + dice4;

                        conLabel.Text = Convert.ToString(constSum);

                        break;
                    case 4:

                        dice1 = rollGen.Next(1, 7);
                        dice2 = rollGen.Next(1, 7);
                        dice3 = rollGen.Next(1, 7);
                        dice4 = rollGen.Next(1, 7);

                        intSum = dice1 + dice2 + dice3 + dice4;

                        intLabel.Text = Convert.ToString(intSum);

                        break;
                    case 5:

                        dice1 = rollGen.Next(1, 7);
                        dice2 = rollGen.Next(1, 7);
                        dice3 = rollGen.Next(1, 7);
                        dice4 = rollGen.Next(1, 7);

                        wisSum = dice1 + dice2 + dice3 + dice4;

                        wisLabel.Text = Convert.ToString(wisSum);

                        break;
                    case 6:

                        dice1 = rollGen.Next(1, 7);
                        dice2 = rollGen.Next(1, 7);
                        dice3 = rollGen.Next(1, 7);
                        dice4 = rollGen.Next(1, 7);

                        chaSum = dice1 + dice2 + dice3 + dice4;

                        chaLabel.Text = Convert.ToString(chaSum);
                        break;
                }
                scoreNum++;
                
            }
            scoreNum = 1;
           
            // number of rerolls
            if (click == 0)

            {
                rollButton.Enabled = false;
            }

            rollNumber.Text = Convert.ToString(click);





        }
    }
}
