namespace Theatre
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.Events = new System.Windows.Forms.Button();
            this.Actors = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PeachPuff;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(306, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 56);
            this.label1.TabIndex = 17;
            this.label1.Text = "Меню ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Events
            // 
            this.Events.BackColor = System.Drawing.Color.PeachPuff;
            this.Events.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Events.Location = new System.Drawing.Point(46, 242);
            this.Events.Name = "Events";
            this.Events.Size = new System.Drawing.Size(242, 49);
            this.Events.TabIndex = 20;
            this.Events.Text = "Мероприятия";
            this.Events.UseVisualStyleBackColor = false;
            this.Events.Click += new System.EventHandler(this.Events_Click);
            // 
            // Actors
            // 
            this.Actors.BackColor = System.Drawing.Color.PeachPuff;
            this.Actors.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Actors.Location = new System.Drawing.Point(465, 242);
            this.Actors.Name = "Actors";
            this.Actors.Size = new System.Drawing.Size(242, 49);
            this.Actors.TabIndex = 21;
            this.Actors.Text = "Актёры";
            this.Actors.UseVisualStyleBackColor = false;
            this.Actors.Click += new System.EventHandler(this.Actors_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(746, 450);
            this.Controls.Add(this.Actors);
            this.Controls.Add(this.Events);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Events;
        private System.Windows.Forms.Button Actors;
    }
}

