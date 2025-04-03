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
            tableLayoutPanel = new TableLayoutPanel();
            txtDate = new TextBox();
            txtLocation = new TextBox();
            txtTitle = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            panelLeftSide.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
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
            splitContainer.Panel2.Controls.Add(btnEdit);
            splitContainer.Panel2.Controls.Add(btnDelete);
            splitContainer.Panel2.Controls.Add(txtParticipants);
            splitContainer.Panel2.Controls.Add(txtDescription);
            splitContainer.Panel2.Controls.Add(tableLayoutPanel);
            splitContainer.Panel2.Controls.Add(txtTitle);
            splitContainer.Panel2.Padding = new Padding(10);
            splitContainer.Size = new Size(983, 586);
            splitContainer.SplitterDistance = 344;
            splitContainer.TabIndex = 0;
            // 
            // panelLeftSide
            // 
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
            txtDescription.Location = new Point(10, 110);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(626, 300);
            txtDescription.TabIndex = 2;
            txtDescription.Text = "ОПИСАНИЕ";
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Controls.Add(txtDate, 0, 0);
            tableLayoutPanel.Controls.Add(txtLocation, 1, 0);
            tableLayoutPanel.Location = new Point(10, 60);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Size = new Size(626, 40);
            tableLayoutPanel.TabIndex = 1;
            // 
            // txtDate
            // 
            txtDate.BackColor = Color.FromArgb(194, 184, 163);
            txtDate.BorderStyle = BorderStyle.None;
            txtDate.Dock = DockStyle.Fill;
            txtDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDate.ForeColor = Color.White;
            txtDate.Location = new Point(3, 3);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(307, 27);
            txtDate.TabIndex = 0;
            txtDate.Text = "ДАТА";
            // 
            // txtLocation
            // 
            txtLocation.BackColor = Color.FromArgb(194, 184, 163);
            txtLocation.BorderStyle = BorderStyle.None;
            txtLocation.Dock = DockStyle.Fill;
            txtLocation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLocation.ForeColor = Color.White;
            txtLocation.Location = new Point(316, 3);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(307, 27);
            txtLocation.TabIndex = 1;
            txtLocation.Text = "МЕСТО";
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
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer;
        private Panel panelLeftSide;
        private Button btnAddEvent;
        private Button btnReports;
        private ListBox listBoxEvents;
        private TextBox txtTitle;
        private TableLayoutPanel tableLayoutPanel;
        private TextBox txtDate;
        private TextBox txtLocation;
        private TextBox txtDescription;
        private TextBox txtParticipants;
        private Button btnDelete;
        private Button btnEdit;
        private DataGridView dataGridView1;
    }
}