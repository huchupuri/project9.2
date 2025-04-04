using System.Drawing;
using System.Windows.Forms;

namespace EventManagementApp
{
    partial class MainForm
    {
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
            splitContainer = new SplitContainer();
            panelLeftSide = new Panel();
            listBoxEvents = new ListBox();
            btnReports = new Button();
            btnAddEvent = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            txtParticipants = new TextBox();
            txtDescription = new TextBox();
            txtTitle = new TextBox();
            btnSort = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            panelLeftSide.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(0, 0);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.BackColor = Color.FromArgb(216, 199, 184);
            splitContainer.Panel1.Controls.Add(panelLeftSide);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.BackColor = Color.FromArgb(168, 208, 211);
            splitContainer.Panel2.Controls.Add(textBox2);
            splitContainer.Panel2.Controls.Add(textBox1);
            splitContainer.Panel2.Controls.Add(btnEdit);
            splitContainer.Panel2.Controls.Add(btnDelete);
            splitContainer.Panel2.Controls.Add(txtParticipants);
            splitContainer.Panel2.Controls.Add(txtDescription);
            splitContainer.Panel2.Controls.Add(txtTitle);
            splitContainer.Panel2.Padding = new Padding(10);
            splitContainer.Size = new Size(983, 586);
            splitContainer.SplitterDistance = 344;
            splitContainer.TabIndex = 0;
            // 
            // panelLeftSide
            // 
            panelLeftSide.Controls.Add(btnSort);
            panelLeftSide.Controls.Add(listBoxEvents);
            panelLeftSide.Controls.Add(btnReports);
            panelLeftSide.Controls.Add(btnAddEvent);
            panelLeftSide.Dock = DockStyle.Fill;
            panelLeftSide.Location = new Point(0, 0);
            panelLeftSide.Name = "panelLeftSide";
            panelLeftSide.Padding = new Padding(10);
            panelLeftSide.Size = new Size(344, 586);
            panelLeftSide.TabIndex = 0;
            // 
            // listBoxEvents
            // 
            listBoxEvents.BackColor = Color.FromArgb(232, 215, 204);
            listBoxEvents.BorderStyle = BorderStyle.None;
            listBoxEvents.DisplayMember = "Title";
            listBoxEvents.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxEvents.ForeColor = Color.FromArgb(140, 126, 117);
            listBoxEvents.FormattingEnabled = true;
            listBoxEvents.ItemHeight = 28;
            listBoxEvents.Location = new Point(10, 95);
            listBoxEvents.Name = "listBoxEvents";
            listBoxEvents.Size = new Size(330, 476);
            listBoxEvents.TabIndex = 2;
            listBoxEvents.SelectedIndexChanged += listBoxEvents_SelectedIndexChanged;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.FromArgb(140, 126, 117);
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.ForeColor = Color.White;
            btnReports.Location = new Point(10, 55);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(150, 30);
            btnReports.TabIndex = 1;
            btnReports.Text = "ОТЧЕТНОСТЬ";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // btnAddEvent
            // 
            btnAddEvent.BackColor = Color.FromArgb(194, 184, 163);
            btnAddEvent.FlatStyle = FlatStyle.Flat;
            btnAddEvent.ForeColor = Color.White;
            btnAddEvent.Location = new Point(10, 10);
            btnAddEvent.Name = "btnAddEvent";
            btnAddEvent.Size = new Size(330, 40);
            btnAddEvent.TabIndex = 0;
            btnAddEvent.Text = "ДОБАВИТЬ СОБЫТИЕ";
            btnAddEvent.TextAlign = ContentAlignment.MiddleLeft;
            btnAddEvent.UseVisualStyleBackColor = false;
            btnAddEvent.Click += btnAddEvent_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(140, 126, 117);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(436, 530);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(200, 40);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "РЕДАКТИРОВАТЬ";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(140, 102, 102);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(10, 530);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(200, 40);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "УДАЛИТЬ";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtParticipants
            // 
            txtParticipants.BackColor = Color.FromArgb(194, 184, 163);
            txtParticipants.BorderStyle = BorderStyle.None;
            txtParticipants.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtParticipants.ForeColor = Color.White;
            txtParticipants.Location = new Point(10, 420);
            txtParticipants.Multiline = true;
            txtParticipants.Name = "txtParticipants";
            txtParticipants.Size = new Size(626, 100);
            txtParticipants.TabIndex = 3;
            txtParticipants.Text = "участники";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.FromArgb(194, 184, 163);
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.ForeColor = Color.White;
            txtDescription.Location = new Point(10, 95);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(626, 315);
            txtDescription.TabIndex = 2;
            txtDescription.Text = "ОПИСАНИЕ";
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.FromArgb(194, 184, 163);
            txtTitle.BorderStyle = BorderStyle.None;
            txtTitle.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitle.ForeColor = Color.White;
            txtTitle.Location = new Point(10, 10);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(626, 32);
            txtTitle.TabIndex = 0;
            txtTitle.Text = "ЗАГОЛОВОК";
            // 
            // btnSort
            // 
            btnSort.BackColor = Color.FromArgb(140, 126, 117);
            btnSort.FlatStyle = FlatStyle.Flat;
            btnSort.ForeColor = Color.White;
            btnSort.Location = new Point(166, 55);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(174, 30);
            btnSort.TabIndex = 3;
            btnSort.Text = "СОРТИРОВКА";
            btnSort.TextAlign = ContentAlignment.MiddleLeft;
            btnSort.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(444, 538);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(140, 126, 117);
            textBox2.Location = new Point(10, 55);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(240, 30);
            textBox2.TabIndex = 7;
            textBox2.Text = " ";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 586);
            Controls.Add(splitContainer);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Event Management";
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            panelLeftSide.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer;
        private Panel panelLeftSide;
        private Button btnAddEvent;
        private Button btnReports;
        private ListBox listBoxEvents;
        private TextBox txtTitle;
        private TextBox txtDescription;
        private TextBox txtParticipants;
        private Button btnDelete;
        private Button btnEdit;
        private DataGridView dataGridView1;
        private Button btnSort;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}