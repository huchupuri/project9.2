using System;
using System.Drawing;
using System.Windows.Forms;

namespace EventManagementApp
{
    partial class EventDetailsForm
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
            txtTitle = new TextBox();
            tableLayoutPanel = new TableLayoutPanel();
            dtpDate = new DateTimePicker();
            txtLocation = new TextBox();
            txtDescription = new TextBox();
            txtParticipants = new TextBox();
            btnSave = new Button();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.FromArgb(216, 199, 184);
            txtTitle.BorderStyle = BorderStyle.None;
            txtTitle.Font = new Font("Segoe UI", 12F);
            txtTitle.ForeColor = Color.White;
            txtTitle.Location = new Point(20, 20);
            txtTitle.Multiline = true;
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(760, 54);
            txtTitle.TabIndex = 0;
            txtTitle.Text = "ЗАГОЛОВОК";
            txtTitle.Enter += txtTitle_Enter;
            txtTitle.Leave += txtTitle_Leave;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Controls.Add(dtpDate, 0, 0);
            tableLayoutPanel.Controls.Add(txtLocation, 1, 0);
            tableLayoutPanel.Location = new Point(20, 80);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Size = new Size(760, 40);
            tableLayoutPanel.TabIndex = 1;
            // 
            // dtpDate
            // 
            dtpDate.BackColor = Color.FromArgb(171, 176, 135);
            dtpDate.CalendarForeColor = Color.White;
            dtpDate.CalendarMonthBackground = Color.FromArgb(171, 176, 135);
            dtpDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDate.ForeColor = Color.White;
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(3, 3);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(374, 34);
            dtpDate.TabIndex = 1;
            dtpDate.Value = new DateTime(2025, 4, 3, 15, 55, 3, 83);
            // 
            // txtLocation
            // 
            txtLocation.BackColor = Color.FromArgb(140, 126, 117);
            txtLocation.BorderStyle = BorderStyle.None;
            txtLocation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLocation.ForeColor = Color.White;
            txtLocation.Location = new Point(383, 3);
            txtLocation.Multiline = true;
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(374, 34);
            txtLocation.TabIndex = 2;
            txtLocation.Text = "МЕСТО";
            txtLocation.Enter += txtLocation_Enter;
            txtLocation.Leave += txtLocation_Leave;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.FromArgb(194, 184, 163);
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.ForeColor = Color.White;
            txtDescription.Location = new Point(20, 130);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(760, 300);
            txtDescription.TabIndex = 3;
            txtDescription.Text = "ОПИСАНИЕ";
            txtDescription.Enter += txtDescription_Enter;
            txtDescription.Leave += txtDescription_Leave;
            // 
            // txtParticipants
            // 
            txtParticipants.BackColor = Color.FromArgb(194, 184, 163);
            txtParticipants.BorderStyle = BorderStyle.None;
            txtParticipants.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtParticipants.ForeColor = Color.White;
            txtParticipants.Location = new Point(20, 440);
            txtParticipants.Multiline = true;
            txtParticipants.Name = "txtParticipants";
            txtParticipants.Size = new Size(640, 40);
            txtParticipants.TabIndex = 4;
            txtParticipants.Text = "участники";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(140, 102, 102);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(670, 440);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 40);
            btnSave.TabIndex = 5;
            btnSave.Text = "сохранить";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // EventDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(800, 500);
            Controls.Add(btnSave);
            Controls.Add(txtParticipants);
            Controls.Add(txtDescription);
            Controls.Add(tableLayoutPanel);
            Controls.Add(txtTitle);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EventDetailsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Event Details";
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private TableLayoutPanel tableLayoutPanel;
        private DateTimePicker dtpDate;
        private TextBox txtLocation;
        private TextBox txtDescription;
        private TextBox txtParticipants;
        private Button btnSave;
    }
}