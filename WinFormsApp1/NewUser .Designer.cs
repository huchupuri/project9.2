namespace EventManagementApp
{
    partial class NewUser
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
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
            btnAddParticipant = new Button();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 42);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Имя";
            textBoxName.Size = new Size(323, 27);
            textBoxName.TabIndex = 0;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(12, 97);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.PlaceholderText = "Фамилия";
            textBoxSurname.Size = new Size(323, 27);
            textBoxSurname.TabIndex = 1;
            // 
            // btnAddParticipant
            // 
            btnAddParticipant.Location = new Point(123, 156);
            btnAddParticipant.Name = "btnAddParticipant";
            btnAddParticipant.Size = new Size(94, 29);
            btnAddParticipant.TabIndex = 2;
            btnAddParticipant.Text = "ДОБАВИТЬ";
            btnAddParticipant.UseVisualStyleBackColor = true;
            btnAddParticipant.Click += btnAddParticipant_Click;
            // 
            // NewUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(355, 215);
            Controls.Add(btnAddParticipant);
            Controls.Add(textBoxSurname);
            Controls.Add(textBoxName);
            Name = "NewUser";
            Text = "NewUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private Button button1;
        private Button btnAddParticipant;
    }
}