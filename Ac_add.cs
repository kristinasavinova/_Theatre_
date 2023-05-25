using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Theatre
{
    public partial class Ac_add : Form
    {

        public static string ActorForm = "";
        public static uint AgeForm = 0;
        public static uint WorkForm = 0;
        public static string RatingForm = "";
        public static uint ID = 0;

        public Ac_add()
        {
            InitializeComponent();
        }
        
        bool CheckOnCorrectTextBox(TextBox tb) => !Regex.IsMatch(tb.Text, @"^\s*$") &&
            Regex.IsMatch(tb.Text, @"^[А-ЯЁ]+[а-яё]+ ([А-ЯЁ]+[а-яё]* [А-ЯЁ]+[а-яё]*$|[А-ЯЁ][.] [А-ЯЁ][.]$)") || (tb.BackColor = Color.MistyRose) != Color.MistyRose
            || (label5.Text = "Примеры ввода: Иванов И И, Иванов И.И.") != "Примеры ввода: Иванов И И, Иванов И.И.";

        bool CheckOnCorrectComboBox(ComboBox cb) => !(cb.SelectedItem is null) || (cb.BackColor = Color.Red) != Color.Red;

        bool CheckOnCorrectNumberBox(TextBox nb) => uint.TryParse(nb.Text, out _) || (nb.BackColor = Color.Red) != Color.Red;

        bool CheckOnCorrectNumberBox2(TextBox nb) => uint.TryParse(nb.Text, out _) || (nb.BackColor = Color.Red) != Color.Red;

        bool FlagCorrect =>
            CheckOnCorrectTextBox(actor) &
            CheckOnCorrectNumberBox(age) &
            CheckOnCorrectNumberBox2(work) &
            CheckOnCorrectComboBox(raiting);

        //добавить
        private void Add_Click(object sender, EventArgs e)
        {
            if (FlagCorrect)
            {
                ActorForm = actor.Text;
                AgeForm = Convert.ToUInt32(age.Text);
                WorkForm = Convert.ToUInt32(work.Text);
                RatingForm = raiting.SelectedItem as string;
                ID= Convert.ToUInt32(textBox1.Text);
                Close();

            }
            else
                MessageBox.Show($"Введите данные правильно", "Ошибка", 0, MessageBoxIcon.Information);
        }
        //выйти
        private void Back_Click(object sender, EventArgs e)
        {
            ActorForm = "";
            AgeForm = 0;
            WorkForm = 0;
            RatingForm = "";
            ID = 0;
            Close();
        }
    }
}
