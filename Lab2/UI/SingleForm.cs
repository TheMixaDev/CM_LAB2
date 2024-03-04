using Lab2.Calculation;
using Lab2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2.UI
{
    public partial class SingleForm : Form
    {
        public Equation[] equations = new Equation[]{
            new Equation((x) => x, "Не выбрано", ""),
            new Equation((x) => x*x*x - x + 4, "x³ - x + 4 = 0", "x^3 - x + 4"),
            new Equation((x) => x*x*x - 1.89d*x*x - 2*x + 1.76, "x³ - 1,89x² -2x + 1,76 = 0", "x^3 - 1.89x^2 - 2x + 1.76"),
            new Equation((x) => Math.Sin(x) + Math.Pow(Math.E, x), "sin(x) + exp(x) + π/4 = 0", "\\\\sin(x) + e^{x} + \\\\pi/4"),
        };
        public SingleForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            BackColor = Color.White;
            MinimumSize = Size;
            MaximumSize = Size;
            MaximizeBox = false;
            string indexPath = System.IO.Path.Combine(Application.StartupPath, "UI", "Desmos", "index.html");
            graph.Source = new Uri(indexPath);

            equationBox.DataSource = equations;
            methodBox.SelectedIndex = 0;
            boundBox.TextChanged += ValidateDouble;
            secondBoundBox.TextChanged += ValidateDouble;
            epsilonBox.TextChanged += ValidatePositiveDouble;
        }

        private void equationBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RerenderButton();
            if (graph.CoreWebView2 == null) return;
            graph.CoreWebView2.ExecuteScriptAsync($"clear()");
            if (equationBox.SelectedIndex == 0)
                return;
            graph.CoreWebView2.ExecuteScriptAsync($"expression('{((Equation)equationBox.SelectedItem).Latex}')");
        }

        private double ParseDouble(string text)
        {
            return double.Parse(text.Replace(".", ","));
        }

        private void UpdateGraphBounds()
        {
            if (graph.CoreWebView2 == null) return;
            if (selectStarerBox.Checked)
            {
                if (!EquationUtils.IsDoubleValid(boundBox.Text))
                    graph.CoreWebView2.ExecuteScriptAsync($"setBounds(0, 0)");
                else
                    graph.CoreWebView2.ExecuteScriptAsync($"setBounds(-999999, 999999)");
                return;
            }
            if (!EquationUtils.IsDoubleValid(boundBox.Text) || !EquationUtils.IsDoubleValid(secondBoundBox.Text)) return;
            graph.CoreWebView2.ExecuteScriptAsync($"setBounds({boundBox.Text.Replace(",",".")}, {secondBoundBox.Text.Replace(",", ".")})");
        }
        private void RerenderButton()
        {
            calculateButton.Enabled = CheckCalculability();
        }
        private bool CheckCalculability()
        {
            if (equationBox.SelectedIndex == 0) return false;
            if (!EquationUtils.IsDoubleValid(boundBox.Text)) return false;
            if (!EquationUtils.IsDoublePositive(epsilonBox.Text)) return false;
            if (!selectStarerBox.Checked)
            {
                if(!EquationUtils.IsDoubleValid(secondBoundBox.Text)) return false;
                if (ParseDouble(secondBoundBox.Text) <= ParseDouble(boundBox.Text)) return false;
            }
            return true;
        }

        private void selectStarerBox_CheckedChanged(object sender, EventArgs e)
        {
            if(selectStarerBox.Checked == true)
            {
                intervalLabel.Text = "Начальное приближение:";
                toLabel.Visible = false;
                secondBoundBox.Visible = false;
            } else
            {
                intervalLabel.Text = "Границы интервала: От";
                toLabel.Visible = true;
                secondBoundBox.Visible = true;
            }
            UpdateGraphBounds();
        }
        private void calculateButton_Click(object sender, EventArgs e)
        {
            int method = methodBox.SelectedIndex;
            Result result = null;

            double leftBound = ParseDouble(boundBox.Text);
            double rightBound;
            double.TryParse(secondBoundBox.Text.Replace(".", ","), out rightBound);
            if(selectStarerBox.Checked)
                rightBound = leftBound;
            Tuple<double, double> limit = new Tuple<double, double>(leftBound, rightBound);
            double epsilon = ParseDouble(epsilonBox.Text);
            Equation equation = (Equation)equationBox.SelectedItem;
            try
            {
                if (method == 0) result = HalfDivision.Calculate(equation, limit, epsilon, 0);
                else if (method == 1) result = Newton.Calculate(equation, limit, epsilon);
                else if (method == 2) result = SimpleIteration.Calculate(equation, limit, epsilon);
                resultLabel.Text = $"Результат:\nx = {EquationUtils.FormatNumber(result.Data)}\ny = {EquationUtils.FormatNumber(equation.Function(result.Data))}\nРезультат получен за {result.Iterations} итераций";
            } catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка вычислений", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch(StackOverflowException)
            {
                MessageBox.Show("Превышен лимит итераций", "Ошибка вычислений", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void methodBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (methodBox.SelectedIndex == 0)
            {
                selectStarerBox.Visible = false;
                selectStarerBox.Checked = false;
            }
            else selectStarerBox.Visible = true;
            UpdateGraphBounds();
        }

        private void changeFormButton_Click(object sender, EventArgs e)
        {
            MultipleForm form = new MultipleForm();
            Hide();
            form.ShowDialog();
            Close();
        }

        public void ValidateDouble(object sender, EventArgs e)
        {
            string text = ((TextBox)sender).Text;
            EquationUtils.SetTextColor((TextBox)sender, EquationUtils.IsDoubleValid(text));
            Rerender();
        }
        public void ValidatePositiveDouble(object sender, EventArgs e)
        {
            string text = ((TextBox)sender).Text;
            EquationUtils.SetTextColor((TextBox)sender, EquationUtils.IsDoublePositive(text));
            Rerender();
        }

        public void Rerender()
        {
            UpdateGraphBounds();
            RerenderButton();
        }
    }
}
