using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Theatre
{
    public partial class Actors : Form
    {
        const string FILE_EVENTS = "Events.json";
        const string FILE_ACTORS = "ACTORS.json";

        int n = 0;
        int numbers = 0;

        public Actors()
        {
            Task.Run(() => File.Open(FILE_ACTORS, FileMode.OpenOrCreate).Close());

            Task.Run(() => File.Open(FILE_EVENTS, FileMode.OpenOrCreate).Close());
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
       
        async void Actors_Load(object sender, EventArgs e)
        {
            if (File.Exists(FILE_ACTORS))
            {
                var table_of_actors = await ReadFromFile<Ac>(FILE_ACTORS);
                n = table_of_actors.Count;
                count_of_actors.Text = Convert.ToString(n);
                if (table_of_actors != null)
                    foreach (var actor in table_of_actors)
                    {
                        dataGridView2.Rows.Add();
                        dataGridView2.Rows[numbers].Cells[0].Value = actor.name;
                        dataGridView2.Rows[numbers].Cells[1].Value = actor.years;
                        dataGridView2.Rows[numbers].Cells[2].Value = actor.years_work;
                        dataGridView2.Rows[numbers].Cells[3].Value = actor.ball;
                        dataGridView2.Rows[numbers].Cells[4].Value = actor.ID;
                        numbers++;
                    }
            }
        }
        
        async void Add_Click(object sender, EventArgs e)
        {
            Ac_add FormAddActor = new Ac_add();
            FormAddActor.ShowDialog();

            string actorForm = Ac_add.ActorForm;
            uint ageForm = Ac_add.AgeForm;
            uint workForm = Ac_add.WorkForm;
            string ratingForm = Ac_add.RatingForm;
            uint id = Ac_add.ID;

            Ac newActor = new Ac(actorForm, ageForm, workForm, ratingForm,id);

            if (!string.IsNullOrEmpty(actorForm) && (workForm > 0) && (ageForm > 0) && !string.IsNullOrEmpty(ratingForm))
            {
                var actors = await ReadFromFile<Ac>(FILE_ACTORS);

                if (!actors.Contains(newActor))
                {
                    foreach (var act in actors)
                    {
                        if (act.name == actorForm)
                        {
                            MessageBox.Show($"Актёр уже есть.", "Ошибка", 0, MessageBoxIcon.Information);
                            return;
                        }
                    }

                    actors.Add(newActor);                    
                    n = actors.Count;
                    count_of_actors.Text = Convert.ToString(n);

                    await WriteToFile(actors, FILE_ACTORS);

                    dataGridView2.Rows.Add();
                    dataGridView2.Rows[numbers].Cells[0].Value = actorForm;
                    dataGridView2.Rows[numbers].Cells[1].Value = ageForm;
                    dataGridView2.Rows[numbers].Cells[2].Value = workForm;
                    dataGridView2.Rows[numbers].Cells[3].Value = ratingForm;
                    dataGridView2.Rows[numbers].Cells[4].Value = id;
                    numbers++;
                }
                else
                {
                    MessageBox.Show($"Этот актёр уже существует", "Ошибка", 0, MessageBoxIcon.Information);
                    return;
                }
            }
        }
        
        private void Back_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        async void Delete_Click(object sender, EventArgs e)
        {
            Int32 selectCount =
                        dataGridView2.GetCellCount(DataGridViewElementStates.Selected);

            if (selectCount > 0)
            {
                var actors = await ReadFromFile<Ac>(FILE_ACTORS);
                var count = actors.Count;
                var events = await ReadFromFile<Ev>(FILE_EVENTS);
                var flag = true;
                string actor = dataGridView2.SelectedCells[0].Value.ToString();
                uint age = Convert.ToUInt32(dataGridView2.SelectedCells[1].Value.ToString());
                uint work = Convert.ToUInt32(dataGridView2.SelectedCells[2].Value.ToString());
                string rating = dataGridView2.SelectedCells[3].Value.ToString();
                foreach (var act in actors)
                {
                    foreach (var eve in events)
                    {
                        if (actor == act.name && age == act.years && work == act.years_work && rating == act.ball && eve.ID == act.ID)
                        {
                            flag = false;
                            MessageBox.Show($"Нельзя удалить актёра, он участвует в мероприятие ", "Ошибка", 0, MessageBoxIcon.Information);
                            break;
                        }
                    }
                }

                

                if (flag)
                {
                    foreach (var act in actors)
                    {
                        if (actor == act.name && age == act.years && work == act.years_work && rating == act.ball)
                        {
                            actors.Remove(act);
                            n = actors.Count;
                            count_of_actors.Text = Convert.ToString(n);
                            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
                            numbers--;
                            MessageBox.Show($"Актёр удалён!", "Ошибка", 0, MessageBoxIcon.Information);
                            break;
                        }
                    }

                    await WriteToFile(actors, FILE_ACTORS);
                }
            }
            else
            {
                MessageBox.Show("Актёров нет!", "Ошибка", 0, MessageBoxIcon.Information);
                return;
            }
        }
        
        async void Delete_All_Click(object sender, EventArgs e)
        {
            var actors = await ReadFromFile<Ac>(FILE_ACTORS);

            var events = await ReadFromFile<Ev>(FILE_EVENTS);
            

            if (dataGridView2.Rows.Count == 0)
            {
                MessageBox.Show("Актёров нет!", "Ошибка", 0, MessageBoxIcon.Information);
            }
            else if (events.Count > 0)
            {
                MessageBox.Show("Нельзя удалить всех, так как есть мероприятия!",
                    "Ошибка", 0, MessageBoxIcon.Information);
            }
            else
            {
                actors.Clear();
                n = actors.Count;
                count_of_actors.Text = Convert.ToString(n);
                dataGridView2.Rows.Clear();
                numbers = 0;
                MessageBox.Show("Актёры удалены!", "Ошибка", 0, MessageBoxIcon.Information);

            }

            await WriteToFile(actors, FILE_ACTORS);
        }
        
        async void Find_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textFiltr.Text))
            {
                MessageBox.Show("Заполните поле поиска!", "Ошибка", 0, MessageBoxIcon.Information);
                textFiltr.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                textFiltr.BackColor = System.Drawing.Color.PeachPuff;
                string filtr = textFiltr.Text;


                numbers = 0;
                int i = 0;

                bool flag = false;

                var actors = await ReadFromFile<Ac>(FILE_ACTORS);

                foreach (var act in actors)
                {
                    if (act.name == Convert.ToString(filtr))
                    {
                        flag = true;
                        dataGridView2.Rows[i].Selected = true;
                        numbers++;
                    }
                    i++;
                }
                if (flag == false)
                {
                    MessageBox.Show($"Актёров с таким ФИО нет!", "Ошибка", 0, MessageBoxIcon.Information);
                }
            }
        }
        
        async void Find_Not_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textFiltr.Text))
            {
                MessageBox.Show($"Поле  уже пустое", "Ошибка", 0, MessageBoxIcon.Information);
                return;
            }
            textFiltr.Text = "";
            textFiltr.BackColor = System.Drawing.Color.PeachPuff;
            dataGridView2.Rows.Clear();
            numbers = 0;

            var actors = await ReadFromFile<Ac>(FILE_ACTORS);

            foreach (var actor in actors)
            {

                dataGridView2.Rows.Add();
                dataGridView2.Rows[numbers].Cells[0].Value = actor.name;
                dataGridView2.Rows[numbers].Cells[1].Value = actor.years;
                dataGridView2.Rows[numbers].Cells[2].Value = actor.years_work;
                dataGridView2.Rows[numbers].Cells[3].Value = actor.ball;
                dataGridView2.Rows[numbers].Cells[4].Value = actor.ID;
                numbers++;
            }
        }
    }    
}
