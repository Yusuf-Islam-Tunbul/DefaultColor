using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20211213_DefaultColor
{
    public partial class Form1 : Form
    {
        Color[] button_colors=new Color[2];
        bool color_switch;

        public Form1()
        {
            InitializeComponent();
            button_colors[0] = change_color_button.BackColor;
            button_colors[1] = Color.Green;
        }

        private void change_color_button_Click(object sender, EventArgs e)
        {
            ChangeColorButtonMethod();
        }

        void ChangeColorButtonMethod()
        {
            if (color_switch)
            {
                ChangeButtonColor(button_colors[0]);
            }

            else
            {
                ChangeButtonColor(button_colors[1]);
            }

            color_switch = !color_switch;
        }

        void ChangeButtonColor(Color color)
        {
            change_color_button.BackColor = color;
        }
    }
}
