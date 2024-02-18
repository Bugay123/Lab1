using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Перевірка полів на порожність
            if (string.IsNullOrEmpty(textName.Text) || string.IsNullOrEmpty(textSurname.Text) ||
                string.IsNullOrEmpty(textBirth.Text) || string.IsNullOrEmpty(textGroup.Text) ||
                string.IsNullOrEmpty(textCourse.Text))
            {
                labelError.Text = "Будь-ласка, заповніть обов'язкові поля: ім'я, прізвище, рік народження, група, курс";
                labelError.Visible = true;
                return;
            } else if (!IsNumeric(textGroup.Text))
            {
                labelError.Text = "Курс має містити тільки цифри";
                labelError.Visible = true;
                return;
            }
            else
            {
                labelError.Visible = false;
            }

            textOutput.Text =
                textName.Text + Environment.NewLine +
                textSurname.Text + Environment.NewLine +
                textBirth.Text + Environment.NewLine +
                textGroup.Text + Environment.NewLine +
                textCourse.Text;
        }
        private bool IsNumeric(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }
    }
}
 