using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TicTacToe
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TicTacToe : ContentPage
    {
        private Button[] buttons = new Button[9];

        bool currentPlayer = true;

        public TicTacToe()
        {
            InitializeComponent();
            InitializeButtons();
            ResetButtons();
        }

        private void InitializeButtons()
        {
            buttons[0] = btn10;
            buttons[1] = btn11;
            buttons[2] = btn12;
            buttons[3] = btn20;
            buttons[4] = btn21;
            buttons[5] = btn22;
            buttons[6] = btn30;
            buttons[7] = btn31;
            buttons[8] = btn32;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button myButton = sender as Button;

            myButton.Text = currentPlayer ? "X" : "O";
            currentPlayer = !currentPlayer;
            myButton.IsEnabled = false;

            CheckGame();

            //TODO - Do Automatic Machine Play
            if (!currentPlayer)
            {
                List<Button> list = new List<Button>();

            }
        }

        private void CheckGame()
        {

            if (btn10.Text == btn11.Text && btn11.Text == btn12.Text && btn12.Text != "")       //Row 1
            {
                lblHeader.Text = "Player " + btn10.Text + " Won";
                DisableButtons();
            }
            else if (btn20.Text == btn21.Text && btn21.Text == btn22.Text && btn22.Text != "")  //Row 2
            {
                lblHeader.Text = "Player " + btn20.Text + " Won";
                DisableButtons();
            }
            else if (btn30.Text == btn31.Text && btn31.Text == btn32.Text && btn32.Text != "")  //Row 3
            {
                lblHeader.Text = "Player " + btn30.Text + " Won";
                DisableButtons();
            }
            else if (btn10.Text == btn20.Text && btn20.Text == btn30.Text && btn30.Text != "")  //Column 1
            {
                lblHeader.Text = "Player " + btn10.Text + " Won";
                DisableButtons();
            }
            else if (btn11.Text == btn21.Text && btn21.Text == btn31.Text && btn31.Text != "")  //Column 2
            {
                lblHeader.Text = "Player " + btn11.Text + " Won";
                DisableButtons();
            }
            else if (btn12.Text == btn22.Text && btn22.Text == btn32.Text && btn32.Text != "")  //Column 3
            {
                lblHeader.Text = "Player " + btn12.Text + " Won";
                DisableButtons();
            }
            else if (btn10.Text == btn21.Text && btn21.Text == btn32.Text && btn32.Text != "")  //Diagonal
            {
                lblHeader.Text = "Player " + btn10.Text + " Won";
                DisableButtons();
            }
            else if (btn12.Text == btn21.Text && btn21.Text == btn30.Text && btn30.Text != "")  //Diagonal
            {
                lblHeader.Text = "Player " + btn12.Text + " Won";
                DisableButtons();
            }
        }

        private void ButtonReset_Clicked(object sender, EventArgs e)
        {
            Button myButton = sender as Button;

            currentPlayer = true;
            EnableButtons();
            ResetButtons();
            lblHeader.Text = "TicTacToe";
        }

        private void EnableButtons()
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].IsEnabled = true;
            }
        }

        private void DisableButtons()
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].IsEnabled = false;
            }
        }

        private void ResetButtons()
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Text = "";
            }
        }
    }
}