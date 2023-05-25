using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Theatre
{
    public partial class Events : Form
    {

        const string FILE_EVENTS = "Events.json";
        const string FILE_ACTORS = "ACTORS.json";
        int number = 0;
        int n_event = 0;//кол-во мер-ий
        public Events()
        {
            Task.Run(() => File.Open(FILE_EVENTS, FileMode.OpenOrCreate).Close());

            Task.Run(() => File.Open(FILE_ACTORS, FileMode.OpenOrCreate).Close());
            InitializeComponent();
        }

        
        async Task WriteToFile<T>(List<T> data, string FILE_NAME)
        {
            using (var streamWriter = new StreamWriter(FILE_NAME, false))
            {
                await streamWriter.WriteAsync(await Task.Run(() => JsonConvert.SerializeObject(data)));
            }
        }
        
        async Task<List<T>> ReadFromFile<T>(string FILE_NAME)
        {
            using (var streamReader = new StreamReader(FILE_NAME))
            {
                return await Task.Run(async () => JsonConvert.DeserializeObject<List<T>>(await streamReader.ReadToEndAsync()) ?? new List<T>());
            }
        }

        
        async void Events_Load(object sender, EventArgs e)
        {
            if (File.Exists(FILE_EVENTS))
            {
                var table_of_events = await ReadFromFile<Ev>(FILE_EVENTS);

                n_event = table_of_events.Count;
                count_of_events.Text = Convert.ToString(n_event);

                if (table_of_events != null)
                    
                    foreach (var events in table_of_events)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[number].Cells[0].Value = events.name;
                        dataGridView1.Rows[number].Cells[1].Value = events.concert_spectacl;
                        dataGridView1.Rows[number].Cells[2].Value = events.n_actors;
                        dataGridView1.Rows[number].Cells[3].Value = events.n_ticks;
                        dataGridView1.Rows[number].Cells[4].Value = events.money;
                        dataGridView1.Rows[number].Cells[5].Value = events.ball;
                        dataGridView1.Rows[number].Cells[6].Value = events.ID;
                        number++;
                    }
            }
        }
        
        async void Add_Click(object sender, EventArgs e)
        {
            
            Ev_add FormAdd = new Ev_add();
            FormAdd.ShowDialog();

            string nameEventForm = Ev_add.NameEventForm;
            string typeEventForm = Ev_add.TypeEventForm;
            uint countActorsForm = Ev_add.CountActorsForm;
            uint countTicketsForm = Ev_add.CountTicketsForm;
            uint priceForm = Ev_add.PriceForm;
            string ratingForm = Ev_add.RatingForm;
            uint id = Ev_add.ID;

            var actors = await ReadFromFile<Ac>(FILE_ACTORS);

            Ev newEvent = new Ev(nameEventForm, typeEventForm, countActorsForm, countTicketsForm, priceForm, ratingForm,id);           
            if (!string.IsNullOrEmpty(nameEventForm) && !string.IsNullOrEmpty(typeEventForm) && (countActorsForm > 0) && (countTicketsForm > 0)
            && (priceForm > 0) && !string.IsNullOrEmpty(ratingForm))
            {

                var events = await ReadFromFile<Ev>(FILE_EVENTS);

                if (countActorsForm > actors.Count)
                {
                    MessageBox.Show($"Мероприятие нельзя добавить, " +
                        $"так как есть только {actors.Count} актёров", "Ошибка", 0, MessageBoxIcon.Information);
                }
                else if (!events.Contains(newEvent))
                {
                    foreach (var eve in events)
                    {
                        if (eve.name == nameEventForm)
                        {
                            MessageBox.Show($"Мероприятие с таким названием уже есть. ", "Ошибка", 0, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    int n_id = 0;
                    bool pr = false;
                    foreach (var act in actors)
                    {
                        if (act.ID == id)
                        {
                            pr = true;
                            n_id++;
                            
                        }
                    }
                    if (!pr)
                    {
                        MessageBox.Show($"Актер с таким ID нет. ", "Ошибка", 0, MessageBoxIcon.Information);
                        return;
                    }
                    if (n_id< countActorsForm)
                    {
                        MessageBox.Show($"Нет нужного кол-ва актеров с таким ID. ", "Ошибка", 0, MessageBoxIcon.Information);
                        return;
                    }
                    events.Add(newEvent);

                    n_event = events.Count;
                    count_of_events.Text = Convert.ToString(n_event);

                    await WriteToFile(events, FILE_EVENTS);

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[number].Cells[0].Value = nameEventForm;
                    dataGridView1.Rows[number].Cells[1].Value = typeEventForm;
                    dataGridView1.Rows[number].Cells[2].Value = countActorsForm;
                    dataGridView1.Rows[number].Cells[3].Value = countTicketsForm;
                    dataGridView1.Rows[number].Cells[4].Value = priceForm;
                    dataGridView1.Rows[number].Cells[5].Value = ratingForm;
                    dataGridView1.Rows[number].Cells[6].Value = id;
                    number++;
                }
                else
                {
                    MessageBox.Show($"Данное мероприятие уже существует", "Ошибка", 0, MessageBoxIcon.Information);
                    return;
                }
            }
        }
        
        private void Back_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        async void Filter_Not_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textFiltr.Text))
            {
                MessageBox.Show($"Поле фильтрации уже пустое", "Ошибка", 0, MessageBoxIcon.Information);
                return;
            }
            textFiltr.Text = "";
            textFiltr.BackColor = Color.PeachPuff;
            dataGridView1.Rows.Clear();
            number = 0;
            label4.Text = " ";
            var events = await ReadFromFile<Ev>(FILE_EVENTS);

            foreach (var eve in events)
            {

                dataGridView1.Rows.Add();
                dataGridView1.Rows[number].Cells[0].Value = eve.name;
                dataGridView1.Rows[number].Cells[1].Value = eve.concert_spectacl;
                dataGridView1.Rows[number].Cells[2].Value = eve.n_actors;
                dataGridView1.Rows[number].Cells[3].Value = eve.n_ticks;
                dataGridView1.Rows[number].Cells[4].Value = eve.money;
                dataGridView1.Rows[number].Cells[5].Value = eve.ball;
                dataGridView1.Rows[number].Cells[6].Value = eve.ID;
                number++;
            }
        }
        
        async void Filter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textFiltr.Text))
            {
                MessageBox.Show("Заполните поле фильтрации!", "Ошибка", 0, MessageBoxIcon.Information);
                textFiltr.BackColor = Color.Red;
            }
            else
            {
                label4.Text = "Фильтр включён";
                textFiltr.BackColor = Color.PeachPuff;
                string filtr = textFiltr.Text;

                dataGridView1.Rows.Clear();
                number = 0;

                bool flag = false;

                var events = await ReadFromFile<Ev>(FILE_EVENTS);

                foreach (var eve in events)
                {
                    if (eve.ball == Convert.ToString(filtr))
                    {
                        flag = true;
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[number].Cells[0].Value = eve.name;
                        dataGridView1.Rows[number].Cells[1].Value = eve.concert_spectacl;
                        dataGridView1.Rows[number].Cells[2].Value = eve.n_actors;
                        dataGridView1.Rows[number].Cells[3].Value = eve.n_ticks;
                        dataGridView1.Rows[number].Cells[4].Value = eve.money;
                        dataGridView1.Rows[number].Cells[5].Value = eve.ball;
                        dataGridView1.Rows[number].Cells[6].Value = eve.ID;
                        number++;
                    }
                }
                if (flag == false)
                {
                    MessageBox.Show($"Мероприятия с таким рейтингом нет!", "Ошибка", 0, MessageBoxIcon.Information);
                }
            }
        }
       
        async void Delete_Click(object sender, EventArgs e)
        {
            Int32 selectCount =
                        dataGridView1.GetCellCount(DataGridViewElementStates.Selected);

            if (selectCount > 0)
            {

                var events = await ReadFromFile<Ev>(FILE_EVENTS);

                string name_event = dataGridView1.SelectedCells[0].Value.ToString();
                string type_event = dataGridView1.SelectedCells[1].Value.ToString();
                uint count_actors = Convert.ToUInt32(dataGridView1.SelectedCells[2].Value.ToString());
                uint count_tickets = Convert.ToUInt32(dataGridView1.SelectedCells[3].Value.ToString());
                uint price = Convert.ToUInt32(dataGridView1.SelectedCells[4].Value.ToString());
                string rating = dataGridView1.SelectedCells[5].Value.ToString();

                foreach (var eve in events)
                {
                    if (name_event == eve.name && type_event == eve.concert_spectacl && count_actors == eve.n_actors
                        && count_tickets == eve.n_ticks && price == eve.money && rating == eve.ball)
                    {
                        events.Remove(eve);
                        n_event = events.Count;
                        count_of_events.Text = Convert.ToString(n_event);
                        dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                        number--;
                        MessageBox.Show($"Мероприятие удалено!", "Удаление", 0, MessageBoxIcon.Information);
                        break;
                    }
                }
                await WriteToFile(events, FILE_EVENTS);
            }
            else
            {
                MessageBox.Show("Мероприятия отсутствуют!", "Ошибка", 0, MessageBoxIcon.Information);
                return;
            }
        }
        
        async void Delete_All_Click(object sender, EventArgs e)
        {
            var events = await ReadFromFile<Ev>(FILE_EVENTS);

            if (dataGridView1.Rows.Count != 0)
            {
                events.Clear();
                n_event = events.Count;
                count_of_events.Text = Convert.ToString(n_event);
                dataGridView1.Rows.Clear();
                number = 0;
                MessageBox.Show("Все мероприятия удалены!", "Ошибка", 0, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Мероприятия отсутствуют!", "Ошибка", 0, MessageBoxIcon.Information);
            }

            await WriteToFile(events, FILE_EVENTS);
        }
        
        async void Find_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Заполните поле поиска!", "Ошибка", 0, MessageBoxIcon.Information);
                textBox1.BackColor = Color.Red;
            }
            else
            {
                textBox1.BackColor = Color.PeachPuff;
                string filtr = textBox1.Text;

                
                number = 0;
                int i=0;

                bool flag = false;

                var events = await ReadFromFile<Ev>(FILE_EVENTS);

                foreach (var eve in events)
                {
                    if (eve.name == Convert.ToString(filtr))
                    {
                        flag = true;
                        dataGridView1.Rows[i].Selected = true;
                        number++;
                    }
                    i++;
                }
                if (flag == false)
                {
                    MessageBox.Show($"Мероприятия с таким названием нет!", "Ошибка", 0, MessageBoxIcon.Information);
                }
            }
        }
        
        async void Find_Not_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show($"Поле  уже пустое", "Ошибка", 0, MessageBoxIcon.Information);
                return;
            }
            textBox1.Text = "";
            textBox1.BackColor = Color.PeachPuff;
            dataGridView1.Rows.Clear();
            number = 0;

            var events = await ReadFromFile<Ev>(FILE_EVENTS);

            foreach (var eve in events)
            {

                dataGridView1.Rows.Add();
                dataGridView1.Rows[number].Cells[0].Value = eve.name;
                dataGridView1.Rows[number].Cells[1].Value = eve.concert_spectacl;
                dataGridView1.Rows[number].Cells[2].Value = eve.n_actors;
                dataGridView1.Rows[number].Cells[3].Value = eve.n_ticks;
                dataGridView1.Rows[number].Cells[4].Value = eve.money;
                dataGridView1.Rows[number].Cells[5].Value = eve.ball;
                dataGridView1.Rows[number].Cells[6].Value = eve.ID;
                number++;
            }
        }
        
        async void Change_Event_Click(object sender, EventArgs e)
        {
            Int32 selectCount =
                        dataGridView1.GetCellCount(DataGridViewElementStates.Selected);

            if (selectCount > 0)
            {
                
                Ev_change FormChng = new Ev_change();
                FormChng.ShowDialog();

                string nameEventForm = Ev_change.NameEventForm;
                string typeEventForm = Ev_change.TypeEventForm;
                uint countActorsForm = Ev_change.CountActorsForm;
                uint countTicketsForm = Ev_change.CountTicketsForm;
                uint priceForm = Ev_change.PriceForm;
                string ratingForm = Ev_change.RatingForm;
                uint id = Ev_change.ID;

                var actors = await ReadFromFile<Ac>(FILE_ACTORS);

                Ev newEvent = new Ev(nameEventForm, typeEventForm, countActorsForm, countTicketsForm, priceForm, ratingForm, id);
                if (!string.IsNullOrEmpty(nameEventForm) && !string.IsNullOrEmpty(typeEventForm) && (countActorsForm > 0) && (countTicketsForm > 0)
                && (priceForm > 0) && !string.IsNullOrEmpty(ratingForm))
                {

                    var events = await ReadFromFile<Ev>(FILE_EVENTS);

                    if (countActorsForm > actors.Count)
                    {
                        MessageBox.Show($"Мероприятие нельзя добавить, " +
                            $"так как есть только {actors.Count} актёров", "Ошибка", 0, MessageBoxIcon.Information);
                    }
                    else if (!events.Contains(newEvent))
                    {
                        foreach (var eve in events)
                        {
                            if (eve.name == nameEventForm)
                            {
                                MessageBox.Show($"Мероприятие с таким названием уже есть. ", "Ошибка", 0, MessageBoxIcon.Information);
                                return;
                            }
                        }
                        int n_id = 0;
                        bool pr = false;
                        foreach (var act in actors)
                        {
                            if (act.ID == id)
                            {
                                pr = true;
                                n_id++;

                            }
                        }
                        if (!pr)
                        {
                            MessageBox.Show($"Актер с таким ID нет. ", "Ошибка", 0, MessageBoxIcon.Information);
                            return;
                        }
                        if (n_id < countActorsForm)
                        {
                            MessageBox.Show($"Нет нужного кол-ва актеров с таким ID. ", "Ошибка", 0, MessageBoxIcon.Information);
                            return;
                        }
                        events.Add(newEvent);

                        n_event = events.Count;
                        count_of_events.Text = Convert.ToString(n_event);
                      
                        string name_event = dataGridView1.SelectedCells[0].Value.ToString();
                        string type_event = dataGridView1.SelectedCells[1].Value.ToString();
                        uint count_actors = Convert.ToUInt32(dataGridView1.SelectedCells[2].Value.ToString());
                        uint count_tickets = Convert.ToUInt32(dataGridView1.SelectedCells[3].Value.ToString());
                        uint price = Convert.ToUInt32(dataGridView1.SelectedCells[4].Value.ToString());
                        string rating = dataGridView1.SelectedCells[5].Value.ToString();

                        foreach (var eve in events)
                        {
                            if (name_event == eve.name && type_event == eve.concert_spectacl && count_actors == eve.n_actors
                                && count_tickets == eve.n_ticks && price == eve.money && rating == eve.ball)
                            {
                                events.Remove(eve);
                                n_event = events.Count;
                                count_of_events.Text = Convert.ToString(n_event);
                                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                                number--;                               
                                break;
                            }
                        }                        

                        await WriteToFile(events, FILE_EVENTS);

                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[number].Cells[0].Value = nameEventForm;
                        dataGridView1.Rows[number].Cells[1].Value = typeEventForm;
                        dataGridView1.Rows[number].Cells[2].Value = countActorsForm;
                        dataGridView1.Rows[number].Cells[3].Value = countTicketsForm;
                        dataGridView1.Rows[number].Cells[4].Value = priceForm;
                        dataGridView1.Rows[number].Cells[5].Value = ratingForm;
                        dataGridView1.Rows[number].Cells[6].Value = id;
                        number++;
                    }
                    else
                    {
                        MessageBox.Show($"Данное мероприятие уже существует", "Ошибка", 0, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Мероприятия отсутствуют!", "Ошибка", 0, MessageBoxIcon.Information);
                return;
            }            
        }
    }


}
