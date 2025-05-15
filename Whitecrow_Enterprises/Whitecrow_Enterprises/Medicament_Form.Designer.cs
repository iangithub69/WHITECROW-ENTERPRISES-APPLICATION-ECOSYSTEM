namespace Whitecrow_Enterprises
{
    partial class Medicament_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medicament_Form));
            root_panel = new Panel();
            dataGridView1 = new DataGridView();
            searchbox_panel = new Panel();
            searchbox_textbox = new TextBox();
            pictureBox1 = new PictureBox();
            datetime_label = new Label();
            header_label = new Label();
            root_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            searchbox_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // root_panel
            // 
            root_panel.Controls.Add(dataGridView1);
            root_panel.Controls.Add(searchbox_panel);
            root_panel.Controls.Add(pictureBox1);
            root_panel.Controls.Add(datetime_label);
            root_panel.Controls.Add(header_label);
            root_panel.Dock = DockStyle.Fill;
            root_panel.Location = new Point(0, 0);
            root_panel.Name = "root_panel";
            root_panel.Size = new Size(2302, 1204);
            root_panel.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.FromArgb(205, 153, 47);
            dataGridView1.Location = new Point(59, 242);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(2180, 707);
            dataGridView1.TabIndex = 5;
            // 
            // searchbox_panel
            // 
            searchbox_panel.Controls.Add(searchbox_textbox);
            searchbox_panel.Location = new Point(59, 140);
            searchbox_panel.Name = "searchbox_panel";
            searchbox_panel.Size = new Size(1164, 57);
            searchbox_panel.TabIndex = 4;
            // 
            // searchbox_textbox
            // 
            searchbox_textbox.BorderStyle = BorderStyle.None;
            searchbox_textbox.CharacterCasing = CharacterCasing.Upper;
            searchbox_textbox.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchbox_textbox.Location = new Point(3, 3);
            searchbox_textbox.Name = "searchbox_textbox";
            searchbox_textbox.Size = new Size(1158, 50);
            searchbox_textbox.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(1229, 140);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 57);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // datetime_label
            // 
            datetime_label.AutoSize = true;
            datetime_label.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datetime_label.ForeColor = Color.FromArgb(205, 153, 47);
            datetime_label.Location = new Point(1706, 35);
            datetime_label.Name = "datetime_label";
            datetime_label.Size = new Size(270, 50);
            datetime_label.TabIndex = 1;
            datetime_label.Text = "Date and Time ";
            // 
            // header_label
            // 
            header_label.AutoSize = true;
            header_label.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            header_label.ForeColor = Color.FromArgb(205, 153, 47);
            header_label.Location = new Point(34, 0);
            header_label.Name = "header_label";
            header_label.Size = new Size(1484, 106);
            header_label.TabIndex = 0;
            header_label.Text = "MEDICAMENT INVENTORY MANAGER";
            // 
            // Medicament_Form
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2302, 1204);
            Controls.Add(root_panel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Medicament_Form";
            Text = "Medicament_Form";
            Load += Medicament_Form_Load;
            root_panel.ResumeLayout(false);
            root_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            searchbox_panel.ResumeLayout(false);
            searchbox_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel root_panel;
        private Label header_label;
        private Label datetime_label;
        private TextBox searchbox_textbox;
        private PictureBox pictureBox1;
        private Panel searchbox_panel;
        private DataGridView dataGridView1;
    }
}