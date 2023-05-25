namespace Theatre
{
    partial class Actors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Actors));
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Delete_All = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.count_of_actors = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.Find = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Find_Not = new System.Windows.Forms.Button();
            this.textFiltr = new System.Windows.Forms.TextBox();
            this.Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Raiting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PeachPuff;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(675, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Количество актёров:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Names,
            this.Year,
            this.WorkYear,
            this.Raiting,
            this.ID});
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.Location = new System.Drawing.Point(87, 40);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(897, 259);
            this.dataGridView2.TabIndex = 23;
            // 
            // Delete_All
            // 
            this.Delete_All.BackColor = System.Drawing.Color.PeachPuff;
            this.Delete_All.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete_All.Location = new System.Drawing.Point(542, 317);
            this.Delete_All.Name = "Delete_All";
            this.Delete_All.Size = new System.Drawing.Size(140, 56);
            this.Delete_All.TabIndex = 28;
            this.Delete_All.Text = "Удалить всех";
            this.Delete_All.UseVisualStyleBackColor = false;
            this.Delete_All.Click += new System.EventHandler(this.Delete_All_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.PeachPuff;
            this.Delete.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete.Location = new System.Drawing.Point(334, 317);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(140, 56);
            this.Delete.TabIndex = 27;
            this.Delete.Text = "Удалить ";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.PeachPuff;
            this.Add.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.Location = new System.Drawing.Point(119, 317);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(140, 56);
            this.Add.TabIndex = 26;
            this.Add.Text = "Добавить актёра";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PeachPuff;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(312, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 24);
            this.label3.TabIndex = 28;
            // 
            // count_of_actors
            // 
            this.count_of_actors.AutoSize = true;
            this.count_of_actors.BackColor = System.Drawing.Color.PeachPuff;
            this.count_of_actors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.count_of_actors.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count_of_actors.Location = new System.Drawing.Point(859, 9);
            this.count_of_actors.Name = "count_of_actors";
            this.count_of_actors.Size = new System.Drawing.Size(17, 20);
            this.count_of_actors.TabIndex = 29;
            this.count_of_actors.Text = "0";
            this.count_of_actors.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.PeachPuff;
            this.Back.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(736, 317);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(140, 56);
            this.Back.TabIndex = 30;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Find
            // 
            this.Find.BackColor = System.Drawing.Color.PeachPuff;
            this.Find.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Find.Location = new System.Drawing.Point(334, 397);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(140, 56);
            this.Find.TabIndex = 31;
            this.Find.Text = "Найти актёра";
            this.Find.UseVisualStyleBackColor = false;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Введите ФИО";
            // 
            // Find_Not
            // 
            this.Find_Not.BackColor = System.Drawing.Color.PeachPuff;
            this.Find_Not.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Find_Not.Location = new System.Drawing.Point(542, 397);
            this.Find_Not.Name = "Find_Not";
            this.Find_Not.Size = new System.Drawing.Size(140, 56);
            this.Find_Not.TabIndex = 34;
            this.Find_Not.Text = "Сбросить поле";
            this.Find_Not.UseVisualStyleBackColor = false;
            this.Find_Not.Click += new System.EventHandler(this.Find_Not_Click);
            // 
            // textFiltr
            // 
            this.textFiltr.BackColor = System.Drawing.Color.PeachPuff;
            this.textFiltr.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textFiltr.ForeColor = System.Drawing.Color.Black;
            this.textFiltr.Location = new System.Drawing.Point(119, 408);
            this.textFiltr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textFiltr.Name = "textFiltr";
            this.textFiltr.Size = new System.Drawing.Size(187, 27);
            this.textFiltr.TabIndex = 35;
            this.textFiltr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Names
            // 
            this.Names.HeaderText = "ФИО";
            this.Names.MinimumWidth = 8;
            this.Names.Name = "Names";
            this.Names.ReadOnly = true;
            this.Names.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Names.Width = 175;
            // 
            // Year
            // 
            this.Year.HeaderText = "Возраст";
            this.Year.MinimumWidth = 8;
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            this.Year.Width = 110;
            // 
            // WorkYear
            // 
            this.WorkYear.HeaderText = "Стаж";
            this.WorkYear.MinimumWidth = 8;
            this.WorkYear.Name = "WorkYear";
            this.WorkYear.ReadOnly = true;
            this.WorkYear.Width = 110;
            // 
            // Raiting
            // 
            this.Raiting.HeaderText = "Рейтинг";
            this.Raiting.MinimumWidth = 8;
            this.Raiting.Name = "Raiting";
            this.Raiting.ReadOnly = true;
            this.Raiting.Width = 110;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // Actors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(996, 497);
            this.Controls.Add(this.textFiltr);
            this.Controls.Add(this.Find_Not);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.Delete_All);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.count_of_actors);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Actors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Актёры";
            this.Load += new System.EventHandler(this.Actors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label count_of_actors;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Delete_All;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Find_Not;
        private System.Windows.Forms.TextBox textFiltr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Raiting;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}