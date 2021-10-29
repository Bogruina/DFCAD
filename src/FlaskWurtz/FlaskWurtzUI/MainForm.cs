using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FlaskWurtzUI
{
    public partial class MainForm : Form
    {
        private readonly Color _incorrectInputColor = Color.LightSalmon;

        private readonly Color _correctInputColor = Color.White;
        public MainForm()
        {
            InitializeComponent();
            PromtButton.FlatAppearance.BorderSize = 0;
            PromtButton.FlatStyle = FlatStyle.Flat;


        }
        
        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

       
        private void MainForm_Load(object sender, EventArgs e)
        {
            PromtButton.FlatAppearance.BorderSize = 0;
        }

        private void toolTip1_Draw(object sender, DrawToolTipEventArgs e)
        {

        }

        private void PromtButton_Click(object sender, EventArgs e)
        {
            var promptForm = new PromptForm();
            promptForm.Show();
        }

        private void FlastDiameterTextBox_Enter(object sender, EventArgs e)
        {
            DependenciesLabel.Text = "A ≥ 2 * E \nD ≤ A + B";
        }

        private void NeckLenghtTextBox_Enter(object sender, EventArgs e)
        {
            DependenciesLabel.Text = "D ≤ A + B";
        }

        private void BendDiameterTextBox_Enter(object sender, EventArgs e)
        {
            DependenciesLabel.Text = "E ≥ C + 5";
        }

        private void BendLenghtTextBox_Enter(object sender, EventArgs e)
        {
            DependenciesLabel.Text = "D ≤ A + B";
        }

        private void NeckDiameterTextBox_Enter(object sender, EventArgs e)
        {
            DependenciesLabel.Text = "E ≥ C + 5 \nA ≥ 2 * E  ";
        }

        private void FlastDiameterTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Double.Parse(FlastDiameterTextBox.Text);
                FlastDiameterTextBox.BackColor = _correctInputColor;
            }
            catch
            {
                FlastDiameterTextBox.BackColor = _incorrectInputColor;
            }
        }

        private void NeckLenghtTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Double.Parse(NeckLenghtTextBox.Text);
                NeckLenghtTextBox.BackColor = _correctInputColor;
            }
            catch
            {
                NeckLenghtTextBox.BackColor = _incorrectInputColor;
            }
        }

        private void BuildButton_Click(object sender, EventArgs e)
        {
           
        }

        private void BendDiameterTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Double.Parse(BendDiameterTextBox.Text);
                BendDiameterTextBox.BackColor = _correctInputColor;
            }
            catch
            {
                BendDiameterTextBox.BackColor = _incorrectInputColor;
            }
        }

        private void BendLenghtTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Double.Parse(BendLenghtTextBox.Text);
                BendLenghtTextBox.BackColor = _correctInputColor;
            }
            catch
            {
                BendLenghtTextBox.BackColor = _incorrectInputColor;
            }
        }

        private void NeckDiameterTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Double.Parse(NeckDiameterTextBox.Text);
                NeckDiameterTextBox.BackColor = _correctInputColor;
            }
            catch
            {
                NeckDiameterTextBox.BackColor = _incorrectInputColor;
            }
        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            if (FlastDiameterTextBox.BackColor == _incorrectInputColor ||
               NeckDiameterTextBox.BackColor == _incorrectInputColor ||
               BendLenghtTextBox.BackColor == _incorrectInputColor ||
               BendDiameterTextBox.BackColor == _incorrectInputColor ||
               NeckLenghtTextBox.BackColor == _incorrectInputColor)
            {
                BuildButton.Enabled = false;
            }
            else
            {
                BuildButton.Enabled = true;
            }
        }
    }
}
