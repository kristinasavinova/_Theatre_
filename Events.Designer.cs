namespace Theatre
{
    partial class Events
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Events));
            this.count_of_events = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountActors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountTickets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Raiting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Back = new System.Windows.Forms.Button();
            this.Delete_All = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Filter = new System.Windows.Forms.Button();
            this.Filter_Not = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.textFiltr = new System.Windows.Forms.TextBox();
            this.Find = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Find_Not = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Change_Event = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // count_of_events
            // 
            this.count_of_events.AutoSize = true;
            this.count_of_events.BackColor = System.Drawing.Color.PeachPuff;
            this.count_of_events.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.count_of_events.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count_of_events.Location = new System.Drawing.Point(1004, 18);
            this.count_of_events.Name = "count_of_events";
            this.count_of_events.Size = new System.Drawing.Size(17, 20);
            this.count_of_events.TabIndex = 25;
            this.count_of_events.Text = "0";
            this.count_of_events.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PeachPuff;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(822, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Количество событий:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameEvent,
            this.TypeEvent,
            this.CountActors,
            this.CountTickets,
            this.Price,
            this.Raiting,
            this.i});
            this.dataGridView1.GridColor = System.Drawing.Color.Snow;
            this.dataGridView1.Location = new System.Drawing.Point(12, 54);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1193, 206);
            this.dataGridView1.TabIndex = 22;
            // 
            // NameEvent
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.NameEvent.DefaultCellStyle = dataGridViewCellStyle2;
            this.NameEvent.HeaderText = "Название";
            this.NameEvent.MinimumWidth = 8;
            this.NameEvent.Name = "NameEvent";
            this.NameEvent.ReadOnly = true;
            this.NameEvent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NameEvent.Width = 148;
            // 
            // TypeEvent
            // 
            this.TypeEvent.HeaderText = "Концерт/спектакль";
            this.TypeEvent.MinimumWidth = 8;
            this.TypeEvent.Name = "TypeEvent";
            this.TypeEvent.ReadOnly = true;
            this.TypeEvent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TypeEvent.Width = 150;
            // 
            // CountActors
            // 
            this.CountActors.HeaderText = "Количество актёров";
            this.CountActors.MinimumWidth = 8;
            this.CountActors.Name = "CountActors";
            this.CountActors.ReadOnly = true;
            this.CountActors.Width = 140;
            // 
            // CountTickets
            // 
            this.CountTickets.HeaderText = "Количество мест";
            this.CountTickets.MinimumWidth = 8;
            this.CountTickets.Name = "CountTickets";
            this.CountTickets.ReadOnly = true;
            this.CountTickets.Width = 120;
            // 
            // Price
            // 
            this.Price.HeaderText = "Цена ";
            this.Price.MinimumWidth = 8;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 101;
            // 
            // Raiting
            // 
            this.Raiting.HeaderText = "Рейтинг";
            this.Raiting.MinimumWidth = 8;
            this.Raiting.Name = "Raiting";
            this.Raiting.ReadOnly = true;
            this.Raiting.Width = 90;
            // 
            // i
            // 
            this.i.HeaderText = "ID";
            this.i.MinimumWidth = 6;
            this.i.Name = "i";
            this.i.Width = 125;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.PeachPuff;
            this.Back.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(921, 452);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(157, 57);
            this.Back.TabIndex = 27;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Delete_All
            // 
            this.Delete_All.BackColor = System.Drawing.Color.PeachPuff;
            this.Delete_All.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete_All.Location = new System.Drawing.Point(168, 451);
            this.Delete_All.Name = "Delete_All";
            this.Delete_All.Size = new System.Drawing.Size(157, 58);
            this.Delete_All.TabIndex = 19;
            this.Delete_All.Text = "Удалить все мероприятия";
            this.Delete_All.UseVisualStyleBackColor = false;
            this.Delete_All.Click += new System.EventHandler(this.Delete_All_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.PeachPuff;
            this.Delete.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete.Location = new System.Drawing.Point(168, 382);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(157, 63);
            this.Delete.TabIndex = 18;
            this.Delete.Text = "Удалить ";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Filter
            // 
            this.Filter.BackColor = System.Drawing.Color.PeachPuff;
            this.Filter.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Filter.Location = new System.Drawing.Point(712, 313);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(157, 61);
            this.Filter.TabIndex = 17;
            this.Filter.Text = "Фильтровать по рейтингу";
            this.Filter.UseVisualStyleBackColor = false;
            this.Filter.Click += new System.EventHandler(this.Filter_Click);
            // 
            // Filter_Not
            // 
            this.Filter_Not.BackColor = System.Drawing.Color.PeachPuff;
            this.Filter_Not.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Filter_Not.Location = new System.Drawing.Point(921, 313);
            this.Filter_Not.Name = "Filter_Not";
            this.Filter_Not.Size = new System.Drawing.Size(157, 61);
            this.Filter_Not.TabIndex = 16;
            this.Filter_Not.Text = "Сбросить фильтр";
            this.Filter_Not.UseVisualStyleBackColor = false;
            this.Filter_Not.Click += new System.EventHandler(this.Filter_Not_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.PeachPuff;
            this.Add.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.Location = new System.Drawing.Point(168, 316);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(157, 60);
            this.Add.TabIndex = 15;
            this.Add.Text = "Добавить мероприятие";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // textFiltr
            // 
            this.textFiltr.BackColor = System.Drawing.Color.PeachPuff;
            this.textFiltr.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textFiltr.ForeColor = System.Drawing.Color.Black;
            this.textFiltr.Location = new System.Drawing.Point(386, 323);
            this.textFiltr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textFiltr.Name = "textFiltr";
            this.textFiltr.Size = new System.Drawing.Size(267, 27);
            this.textFiltr.TabIndex = 13;
            this.textFiltr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Find
            // 
            this.Find.BackColor = System.Drawing.Color.PeachPuff;
            this.Find.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Find.Location = new System.Drawing.Point(712, 380);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(157, 63);
            this.Find.TabIndex = 28;
            this.Find.Text = "Найти мероприятие";
            this.Find.UseVisualStyleBackColor = false;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.textBox1.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(386, 393);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(267, 27);
            this.textBox1.TabIndex = 29;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(442, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Введите название";
            // 
            // Find_Not
            // 
            this.Find_Not.BackColor = System.Drawing.Color.PeachPuff;
            this.Find_Not.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Find_Not.Location = new System.Drawing.Point(921, 380);
            this.Find_Not.Name = "Find_Not";
            this.Find_Not.Size = new System.Drawing.Size(157, 63);
            this.Find_Not.TabIndex = 35;
            this.Find_Not.Text = "Сбросить поле";
            this.Find_Not.UseVisualStyleBackColor = false;
            this.Find_Not.Click += new System.EventHandler(this.Find_Not_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(442, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "Введите рейтинг";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(709, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 37;
            // 
            // Change_Event
            // 
            this.Change_Event.BackColor = System.Drawing.Color.PeachPuff;
            this.Change_Event.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Change_Event.Location = new System.Drawing.Point(712, 451);
            this.Change_Event.Name = "Change_Event";
            this.Change_Event.Size = new System.Drawing.Size(157, 63);
            this.Change_Event.TabIndex = 38;
            this.Change_Event.Text = "Редактировать";
            this.Change_Event.UseVisualStyleBackColor = false;
            this.Change_Event.Click += new System.EventHandler(this.Change_Event_Click);
            // 
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1299, 550);
            this.Controls.Add(this.Change_Event);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Find_Not);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Filter_Not);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Delete_All);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.textFiltr);
            this.Controls.Add(this.count_of_events);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Delete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Events";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мероприятия";
            this.Load += new System.EventHandler(this.Events_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label count_of_events;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textFiltr;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Delete_All;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Filter;
        private System.Windows.Forms.Button Filter_Not;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Find_Not;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountActors;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountTickets;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Raiting;
        private System.Windows.Forms.DataGridViewTextBoxColumn i;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Change_Event;
    }
}