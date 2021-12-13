using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using FlaskWurthzSDK;
using FlaskWurthzKompasBuilder;

namespace FlaskWurtzUI
{
    /// <summary>
    /// Класс, хранищий и  обрабатывающий
    /// пользовательский интерфейс плагина
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Потокобезопасный вызов асинхронного метода
        /// </summary>
        private BackgroundWorker _backgroundWorker =
            new BackgroundWorker();

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
        private FlaskWurthzParameters _currentParameters =
            new FlaskWurthzParameters();
        public MainForm()
        {
            InitializeComponent();

        }
        /// <summary>
        /// Запускает проверку введенных параметров
        /// </summary>
        private void CheckingTextBoxesAsync()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            _backgroundWorker.DoWork += (obj, ea) => CheckingFormData();
            _backgroundWorker.RunWorkerAsync();
        }

        /// <summary>
        /// Метод для парса строки в double
        /// <pama>В случае неудачного парса выбрасывает исключение</pama>
        /// </summary>
        /// <param name="data">Текст, который требуется спарсить</param>
        /// <param name="parameterName">Текущий параметр</param>
        /// <returns></returns>
        private double DoubleParse(string data, ParameterName parameterName)
        {
            try
            {
                double tmp = Double.Parse(data);
                return tmp;
            }
            catch
            {
                throw new ArgumentException($"ParameterName {parameterName}" +
                    $"  must contain only numbers\n");
            }
        }
        /// <summary>
        /// Метод для обновления зависимостей
        /// </summary>
        private void UpdateDependencies()
        {
            try
            {
                var flaskDiameter = _currentParameters.FlaskDiameter;
                var neckLenght = _currentParameters.NeckLength;
                var neckDiameter = _currentParameters.NeckDiameter;
                var bendDiameter = _currentParameters.BendDiameter;
                DependenciesLabel.Text =
                    $"A ≥ {neckDiameter * 2} \n" +
                    $"D ≤ {flaskDiameter + neckLenght}\n" +
                    $"E  ≥ {bendDiameter + 5}";
            }
            catch
            {
                DependenciesLabel.Text = null;
            }
        }

        /// <summary>
        /// Метод проверяет TextBox на корректность введенного значения
        /// </summary>
        /// <param name="textBox">TextBox, который трубется проверить</param>
        /// <param name="parameterName">Название параметра, который
        /// записывается в проверяемый TextBox</param>
        private void CheckTexBox(TextBox textBox,
            ParameterName parameterName)
        {
            try
            {
                var value = DoubleParse(textBox.Text, parameterName);
                var propertyInfo = typeof(FlaskWurthzParameters).
                    GetProperty(parameterName.ToString());
                propertyInfo.SetValue(_currentParameters, value);
                textBox.BackColor = Color.White;
            }
            catch (Exception exception)
            {
                if (exception.InnerException == null)
                {
                    textBox.BackColor = _incorrectInputColor;
                    ErrorsLabel.Text += exception.Message.ToString();
                }
                else
                {
                    textBox.BackColor = _incorrectInputColor;
                    ErrorsLabel.Text += exception.InnerException.Message.
                        ToString();
                }
            }
        }
        /// <summary>
        /// Метод выполняется ассинхронно, сначала вызывает проверку все TextBox,
        /// затем проверяет доступность кнопки "Построить" и обновляет зависимости
        /// </summary>
        private void CheckingFormData()
        {
            while (true)
            {
                Thread.Sleep(1000);
                ErrorsLabel.Text = null;
                ErrorsLabel.ForeColor = Color.Red;
                CheckTexBox(FlastDiameterTextBox, ParameterName.FlaskDiameter);
                CheckTexBox(BendDiameterTextBox, ParameterName.BendDiameter);
                CheckTexBox(BendLenghtTextBox, ParameterName.BendLength);
                CheckTexBox(NeckDiameterTextBox, ParameterName.NeckDiameter);
                CheckTexBox(NeckLenghtTextBox, ParameterName.NeckLength);
                BuildButton.Enabled = string.IsNullOrEmpty(ErrorsLabel.Text);
                UpdateDependencies();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CheckingTextBoxesAsync();
            DependenciesToolTip.SetToolTip(DependenciesButton,
                "A ≥ 2*E\nE ≥ C + 5\nD ≤ A+B");
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
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
