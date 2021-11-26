using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using FlaskWurthzSDK;
using FlaskWurthzBLL;

//TODO: Асинхронный расчет зависимостей
//TODO: 
namespace FlaskWurtzUI
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Потокобезопасный вызов асинхронного метода
        /// </summary>
        private BackgroundWorker _backgroundWorker = new BackgroundWorker();
        
        /// <summary>
        /// Цвет TextBox при некорректном заполнении
        /// </summary>
        private readonly Color _incorrectInputColor = Color.LightSalmon;

        /// <summary>
        /// Цвет TextBox при корректном заполнении
        /// </summary>
        private readonly Color _correctInputColor = Color.White;
       
        /// <summary>
        /// Текущие корректные параметры колбы
        /// </summary>
        private FlaskWurthzParameters _currentParameters = new FlaskWurthzParameters();
        public MainForm()
        {
            InitializeComponent();
            
        }
       /// <summary>
       /// Запускает проверку введенных параметров
       /// </summary>
        private void CheckingTextBoxesAsync()
        {
 
            _backgroundWorker.DoWork += (obj, ea) => ChekcingTextBoxes();
            _backgroundWorker.RunWorkerAsync();
        }
        
        /// <summary>
        /// Метод для парса строки в double
        /// <pama>В случае неудачного парса выбрасывает исключение</pama>
        /// </summary>
        /// <param name="data">Текст, который требуется спарсить</param>
        /// <param name="parameter">Текущий параметр</param>
        /// <returns></returns>
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
        /// <summary>
        /// Метод для обновления зависимостей
        /// </summary>
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
        /// <summary>
        /// Метод для проверки TextBox на корректность введеных значения
        /// </summary>
        private void ChekcingTextBoxes()
        {
            while(true)
            {  
                Thread.Sleep(1000);
                ErrorsLabel.Text = null;
                ErrorsLabel.ForeColor = Color.Red;
                
                //TODO: Куча дублей.
                try
                {
                    _currentParameters.FlaskDiameter = DoubleParse(FlastDiameterTextBox.Text, Parameter.FlaskDiameter);
                    FlastDiameterTextBox.BackColor = Color.White;
                    
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

                BuildButton.Enabled = string.IsNullOrEmpty(ErrorsLabel.Text);
                UpdateDependencies();
            }
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

        private void BuildButton_Click(object sender, EventArgs e)
        {
            try
            {
                var builder = new FlaskWurthzBuilder();
                builder.Assembly(_currentParameters);

            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
