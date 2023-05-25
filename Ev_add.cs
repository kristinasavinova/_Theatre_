using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Theatre
{
	public partial class Ev_add : Form
	{

		public static string NameEventForm = "";
		public static string TypeEventForm = "";
		public static uint CountActorsForm = 0;
		public static uint CountTicketsForm = 0;
		public static uint PriceForm = 0;
		public static string RatingForm = "";
		public static uint ID = 0;

		public Ev_add()
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
		
        private void Add_Click(object sender, EventArgs e)
        {
			if (FlagCorrect)
			{
				NameEventForm = nameEvent.Text;
				TypeEventForm = typeEvent.SelectedItem as string;
				CountActorsForm = Convert.ToUInt32(actorEvent.Text);
				CountTicketsForm = Convert.ToUInt32(numberPlaces.Text);
				PriceForm = Convert.ToUInt32(ticket.Text);
				RatingForm = raiting.SelectedItem as string;
				ID= Convert.ToUInt32(textBox1.Text);
				Close();
			}
			else
				MessageBox.Show($"Введите корректные данные", "Ошибка", 0, MessageBoxIcon.Information);
		}
		
        private void Back_Click(object sender, EventArgs e)
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
