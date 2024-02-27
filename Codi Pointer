using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemple_de_pointer_i_printdialog
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            //Bucle per seleccionar tots els botons i fer-los més grands o petits segons si entra o surt el cursor

            foreach (Button btn in Controls.OfType<Button>())
            {
                btn.MouseEnter += new System.EventHandler(button1_MouseEnter);
                btn.MouseLeave += new System.EventHandler(button1_MouseLeave);
            }

        }

        //Variables que fan més gran els botons quan entren o més petits quan surten.

        private void button1_MouseEnter(object sender, EventArgs e)
        {

            var senderButton = (Button)sender;
            senderButton.Width += 30;

        }

    private void button1_MouseLeave(object sender, EventArgs e)
        {

            var senderButton = (Button)sender;
            senderButton.Width -= 30;

        }

        //Canviar el cursor a una mà quan cliques

        private void button1_Click(object sender, EventArgs e)
        {

            button1.Cursor = System.Windows.Forms.Cursors.Hand;

        }

        //Canviar de posició el cursor amb el botó 3
        
        private void button2_Click(object sender, EventArgs e)
        {
            Cursor.Position = PointToScreen(button3.Location);
        }

         //Canviar de posició el cursor amb el botó 3

        private void button3_Click(object sender, EventArgs e)
        {
            Cursor.Position = PointToScreen(button2.Location);

        }

        //Canviar el cursor a una creu quan cliques

        private void button4_Click(object sender, EventArgs e)
        {

            button4.Cursor = System.Windows.Forms.Cursors.Cross;

        }
    }
}
