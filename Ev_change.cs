using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Theatre
{
    public partial class Ev_change : Form
    {
        public static string NameEventForm = "";
        public static string TypeEventForm = "";
        public static uint CountActorsForm = 0;
        public static uint CountTicketsForm = 0;
        public static uint PriceForm = 0;
        public static string RatingForm = "";
        public static uint ID = 0;
        public Ev_change()
        {
            InitializeComponent();
        }
        bool CheckOnCorrectTextBox(TextBox tb) => !Regex.IsMatch(tb.Text, @"^\s*$") && Regex.IsMatch(tb.Text, @"^[а-яА-Яa-zA-Z ]+$") || (tb.BackColor = Color.Red) != Color.Red;

        bool CheckOnCorrectComboBox(ComboBox cb) => !(cb.SelectedItem is null) || (cb.BackColor = Color.Red) != Color.Red;

        bool CheckOnCorrectNumberBox(TextBox nb) => uint.TryParse(nb.Text, out _) || (nb.BackColor = Color.Red) != Color.Red;

        bool FlagCorrect =>
            CheckOnCorrectTextBox(nameEvent) &
            CheckOnCorrectComboBox(typeEvent) &
            CheckOnCorrectNumberBox(actorEvent) &
            CheckOnCorrectNumberBox(numberPlaces) &
            CheckOnCorrectNumberBox(ticket) &
            CheckOnCorrectComboBox(raiting);
        private void Change_form_Click(object sender, EventArgs e)
        {
            if (FlagCorrect)
            {
                NameEventForm = nameEvent.Text;
                TypeEventForm = typeEvent.SelectedItem as string;
                CountActorsForm = Convert.ToUInt32(actorEvent.Text);
                CountTicketsForm = Convert.ToUInt32(numberPlaces.Text);
                PriceForm = Convert.ToUInt32(ticket.Text);
                RatingForm = raiting.SelectedItem as string;
                ID = Convert.ToUInt32(textBox1.Text);
                Close();
            }
            else
                MessageBox.Show($"Введите корректные данные", "Ошибка", 0, MessageBoxIcon.Information);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            NameEventForm = "";
            TypeEventForm = "";
            CountActorsForm = 0;
            CountTicketsForm = 0;
            PriceForm = 0;
            RatingForm = "";
            ID = 0;
            Close();
        }
    }
}
