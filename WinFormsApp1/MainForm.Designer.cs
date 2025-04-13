using System.Drawing;
using System.Windows.Forms;

namespace EventManagementApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            splitContainer = new SplitContainer();
            panelLeftSide = new Panel();
            buttonSort = new Button();
            listBoxEvents = new ListBox();
            btnReports = new Button();
            btnAddEvent = new Button();
            labelTitle = new Label();
            labelDate = new Label();
            labelPlace = new Label();
            labelParticipants = new Label();
            labelDescription = new Label();
            btnEdit = new Button();
            btnDelete = new Button();
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
            splitContainer.Panel2.BackColor = Color.Linen;
            splitContainer.Panel2.BackgroundImage = (Image)resources.GetObject("splitContainer.Panel2.BackgroundImage");
            splitContainer.Panel2.Controls.Add(labelTitle);
            splitContainer.Panel2.Controls.Add(labelDate);
            splitContainer.Panel2.Controls.Add(labelPlace);
            splitContainer.Panel2.Controls.Add(labelParticipants);
            splitContainer.Panel2.Controls.Add(labelDescription);
            splitContainer.Panel2.Controls.Add(btnEdit);
            splitContainer.Panel2.Controls.Add(btnDelete);
            splitContainer.Panel2.Padding = new Padding(10);
            splitContainer.Size = new Size(983, 586);
            splitContainer.SplitterDistance = 344;
            splitContainer.TabIndex = 0;
            // 
            // panelLeftSide
            // 
            panelLeftSide.Controls.Add(buttonSort);
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
            // buttonSort
            // 
            buttonSort.BackColor = Color.FromArgb(140, 126, 117);
            buttonSort.FlatStyle = FlatStyle.Flat;
            buttonSort.ForeColor = SystemColors.ButtonHighlight;
            buttonSort.Location = new Point(166, 55);
            buttonSort.Name = "buttonSort";
            buttonSort.Size = new Size(174, 30);
            buttonSort.TabIndex = 3;
            buttonSort.Text = "СОРТИРОВКА                ";
            buttonSort.UseVisualStyleBackColor = false;
            buttonSort.Click += buttonSort_Click;
            // 
            // listBoxEvents
            // 
            listBoxEvents.BackColor = Color.FromArgb(232, 215, 204);
            listBoxEvents.BorderStyle = BorderStyle.None;
            listBoxEvents.Cursor = Cursors.PanWest;
            listBoxEvents.DisplayMember = "title";
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
            btnAddEvent.Click += btnAddEvent_Click_1;
            // 
            // labelTitle
            // 
            labelTitle.BackColor = Color.FromArgb(194, 184, 163);
            labelTitle.Font = new Font("Segoe UI", 12F);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(9, 10);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(613, 40);
            labelTitle.TabIndex = 15;
            labelTitle.Text = "ЗАГОЛОВОК";
            // 
            // labelDate
            // 
            labelDate.BackColor = Color.FromArgb(140, 126, 117);
            labelDate.Font = new Font("Segoe UI", 12F);
            labelDate.ForeColor = Color.White;
            labelDate.Location = new Point(10, 55);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(210, 30);
            labelDate.TabIndex = 14;
            labelDate.Text = "ДАТА";
            // 
            // labelPlace
            // 
            labelPlace.BackColor = Color.FromArgb(140, 126, 117);
            labelPlace.Font = new Font("Segoe UI", 12F);
            labelPlace.ForeColor = Color.White;
            labelPlace.Location = new Point(226, 55);
            labelPlace.Name = "labelPlace";
            labelPlace.Size = new Size(321, 30);
            labelPlace.TabIndex = 13;
            labelPlace.Text = "МЕСТО";
            // 
            // labelParticipants
            // 
            labelParticipants.BackColor = Color.FromArgb(194, 184, 163);
            labelParticipants.Font = new Font("Segoe UI", 12F);
            labelParticipants.ForeColor = Color.White;
            labelParticipants.Location = new Point(10, 425);
            labelParticipants.Name = "labelParticipants";
            labelParticipants.Size = new Size(613, 39);
            labelParticipants.TabIndex = 12;
            labelParticipants.Text = "УЧАСТНИКИ";
            // 
            // labelDescription
            // 
            labelDescription.BackColor = Color.FromArgb(194, 184, 163);
            labelDescription.Font = new Font("Segoe UI", 12F);
            labelDescription.ForeColor = Color.White;
            labelDescription.Location = new Point(10, 95);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(613, 315);
            labelDescription.TabIndex = 11;
            labelDescription.Text = "ОПИСАНИЕ";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(140, 126, 117);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(397, 499);
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
            btnDelete.Location = new Point(34, 499);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(200, 40);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "УДАЛИТЬ";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(983, 586);
            Controls.Add(splitContainer);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            MaximumSize = new Size(1001, 633);
            MinimumSize = new Size(1001, 633);
            Name = "MainForm";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Event Management";
            Load += MainForm_Load;
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
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
        private Button btnDelete;
        private Button btnEdit;
        private Button buttonSort;
        private Label labelDescription;
        private Label labelParticipants;
        private Label labelPlace;
        private Label labelTitle;
        private Label labelDate;
    }
}