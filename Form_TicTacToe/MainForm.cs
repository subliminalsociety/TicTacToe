using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_TicTacToe {
    public partial class MainForm : Form {
        private bool _turn = true;
        private int _turnCount = 0;
        public MainForm() {
            InitializeComponent();
        }

        private void OnButtonClick(object sender, EventArgs e) {
            try {
                Button button = (Button)sender;
                button.Text = _turn == true ? "X" : "O";
                _turn = !_turn;
                _turnCount++;
                button.Enabled = false;
                Check();
            }
            catch {
                MessageBox.Show(@"ERROR!", @"Error", MessageBoxButtons.AbortRetryIgnore);
            }
        }

        private void Restart() {
            foreach (Button button in Controls.OfType<Button>()) {
                button.Enabled = true;
                button.Text = "";
            }

            _turnCount = 0;
            _turn = true;
        }
        
        private void Check() {
            bool thereIsAWinner = false;
            
            if (button_topLeft.Text == button_topMiddle.Text && button_topMiddle.Text == button_topRight.Text &&
                button_topLeft.Text != "") {
                thereIsAWinner = true;
            } else if (button_centerLeft.Text == button_centerMiddle.Text &&
                       button_centerMiddle.Text == button_centerRight.Text && button_centerLeft.Text != "") {
                thereIsAWinner = true;
            } else if (button_bottomLeft.Text == button_bottomMiddle.Text &&
                       button_bottomMiddle.Text == button_bottomRight.Text && button_bottomLeft.Text != "") {
                thereIsAWinner = true;
            }

            if (button_topLeft.Text == button_centerLeft.Text && button_centerLeft.Text == button_bottomLeft.Text && button_topLeft.Text != "") {
                thereIsAWinner = true;
            } else if (button_topMiddle.Text == button_centerMiddle.Text && button_centerMiddle.Text == button_bottomMiddle.Text && button_topMiddle.Text != "") {
                thereIsAWinner = true;
            } else if (button_topRight.Text == button_centerRight.Text && button_centerRight.Text == button_bottomRight.Text && button_topRight.Text != "") {
                thereIsAWinner = true;
            }

            if (button_topLeft.Text == button_centerMiddle.Text && button_centerMiddle.Text == button_bottomRight.Text && button_topLeft.Text != "") {
                thereIsAWinner = true;
            } else if (button_topRight.Text == button_centerMiddle.Text && button_centerMiddle.Text == button_bottomLeft.Text && button_topRight.Text != "") {
                thereIsAWinner = true;
            }

            if (thereIsAWinner) {
                string winner = "";
                if (_turn) {
                    winner = "O";
                }
                else {
                    winner = "X";
                }

                MessageBox.Show($@"The winner is {winner}! Click OK to restart the game.");
                Restart();
            }

            
            
        }

        #region Empty Button Click Event Methods
        private void button_topLeft_Click(object sender, EventArgs e) {
            OnButtonClick(sender, e);
        }
        private void button_topMiddle_Click(object sender, EventArgs e) {
            OnButtonClick(sender, e);
        }
        private void button_topRight_Click(object sender, EventArgs e) {
            OnButtonClick(sender, e);
        }
        private void button_centerLeft_Click(object sender, EventArgs e) {
            OnButtonClick(sender, e);
        }
        private void button_centerMiddle_Click(object sender, EventArgs e) {
            OnButtonClick(sender, e);
        }
        private void button_centerRight_Click(object sender, EventArgs e) {
            OnButtonClick(sender, e);
        }
        private void button_bottomLeft_Click(object sender, EventArgs e) {
            OnButtonClick(sender, e);
        }
        private void button_bottomMiddle_Click(object sender, EventArgs e) {
            OnButtonClick(sender, e);
        }
        private void button_bottomRight_Click(object sender, EventArgs e) {
            OnButtonClick(sender, e);
        }
        #endregion
    }
    
}