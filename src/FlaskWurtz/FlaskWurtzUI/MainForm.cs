using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using FlaskWurthzSDK;

//TODO: Асинхронный расчет зависимостей
//TODO: 
namespace FlaskWurtzUI
{
    public partial class MainForm : Form
    {
        private delegate void SafeCallDelegate(string text);

        private readonly Color _incorrectInputColor = Color.LightSalmon;

        private readonly Color _correctInputColor = Color.White;

        private FlaskWurthzParameters _currentParameters = new FlaskWurthzParameters();
        public MainForm()
        {
            InitializeComponent();
        }
       
        private async void CheckingTextBoxesAsync()
        {
            await Task.Run(() => ChekcingTextBoxes());
        }
        private void WriteTextSafe(string text)
        {
            if (ErrorsLabel.InvokeRequired)
            {
                var d = new SafeCallDelegate(WriteTextSafe);
                ErrorsLabel.Invoke(d, new object[] { text });
            }
            else
            {
                ErrorsLabel.Text = text;
            }
        }

        private double DoubleParse(string data, Parameter parameter)
        {
            try
            {
                double tmp = Double.Parse(data);
                return tmp;
            }
            catch
            {
                throw new ArgumentException($"Parameter {parameter}  must contain only numbers\n");
            }
        }

        private void UpdateDependencies()
        {
            try
            {
                DependenciesLabel.Text = $"A ≥ { _currentParameters.NeckDiameter * 2} \n" +
                    $"D ≤ {_currentParameters.FlaskDiameter + _currentParameters.NeckLenght}\n" +
                    $"E  ≥ {_currentParameters.BendDiameter + 5}";
            }
            catch
            {
                DependenciesLabel.Text = null;
            }
        }

        private void ChekcingTextBoxes()
        {
            while (true)
            {
                
                Thread.Sleep(1000);
                ErrorsLabel.Text = null;
                ErrorsLabel.ForeColor = Color.Red;
                try
                {
                    _currentParameters.FlaskDiameter = DoubleParse(FlastDiameterTextBox.Text, Parameter.FlaskDiameter);
                    FlastDiameterTextBox.BackColor = _correctInputColor;
                    
                }
                catch (ArgumentException exception)
                {
                    FlastDiameterTextBox.BackColor = _incorrectInputColor;
                    ErrorsLabel.Text += exception.Message.ToString();
                }
               
                try
                {
                    _currentParameters.NeckLenght = DoubleParse(NeckLenghtTextBox.Text, Parameter.NeckLenght);
                    NeckLenghtTextBox.BackColor = _correctInputColor;
                }
                catch (ArgumentException exception)
                {
                    NeckLenghtTextBox.BackColor = _incorrectInputColor;
                    ErrorsLabel.Text += exception.Message.ToString();
                }

                try
                {
                    _currentParameters.BendDiameter = DoubleParse(BendDiameterTextBox.Text, Parameter.BendDiameter);
                    BendDiameterTextBox.BackColor = _correctInputColor;
                }
                catch (ArgumentException exception)
                {
                    BendDiameterTextBox.BackColor = _incorrectInputColor;
                    ErrorsLabel.Text += exception.Message;
                }

                try
                {
                    _currentParameters.BendLenght = DoubleParse(BendLenghtTextBox.Text, Parameter.BendLenght);
                    BendLenghtTextBox.BackColor = _correctInputColor;
                }
                catch (ArgumentException exception)
                {
                    BendLenghtTextBox.BackColor = _incorrectInputColor;
                    ErrorsLabel.Text += exception.Message;
                }
                
                try
                {
                    _currentParameters.NeckDiameter = DoubleParse(NeckDiameterTextBox.Text, Parameter.NeckDiameter);
                    NeckDiameterTextBox.BackColor = _correctInputColor;
                }
                catch (ArgumentException exception)
                {
                    NeckDiameterTextBox.BackColor = _incorrectInputColor;
                    ErrorsLabel.Text += exception.Message;
                }

                if (string.IsNullOrEmpty(ErrorsLabel.Text))
                {
                    BuildButton.Enabled = true;
                }
                else
                {
                    BuildButton.Enabled = false;
                }
                UpdateDependencies();
            }
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

       
        private void MainForm_Load(object sender, EventArgs e)
        {
            CheckingTextBoxesAsync();
            DependenciesToolTip.SetToolTip(DependenciesButton, "A ≥ 2*E\nE ≥ C + 5\nD ≤ A+B");
        }

        private void PromtButton_Click(object sender, EventArgs e)
        {
            var promptForm = new PromptForm();
            promptForm.Show();
        }

        private void FlastDiameterTextBox_Enter(object sender, EventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
