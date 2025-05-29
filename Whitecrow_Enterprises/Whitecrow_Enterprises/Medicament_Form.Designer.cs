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
            button1 = new Button();
            sell_button = new Button();
            dataGridView1 = new DataGridView();
            searchbox_panel = new Panel();
            searchbox_textbox = new TextBox();
            pictureBox1 = new PictureBox();
            datetime_label = new Label();
            header_label = new Label();
            add_button = new Button();
            edit_button = new Button();
            restock_button = new Button();
            delete_button = new Button();
            root_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            searchbox_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // root_panel
            // 
            root_panel.Controls.Add(delete_button);
            root_panel.Controls.Add(restock_button);
            root_panel.Controls.Add(edit_button);
            root_panel.Controls.Add(add_button);
            root_panel.Controls.Add(button1);
            root_panel.Controls.Add(sell_button);
            root_panel.Controls.Add(dataGridView1);
            root_panel.Controls.Add(searchbox_panel);
            root_panel.Controls.Add(pictureBox1);
            root_panel.Controls.Add(datetime_label);
            root_panel.Controls.Add(header_label);
            root_panel.Dock = DockStyle.Fill;
            root_panel.Location = new Point(0, 0);
            root_panel.Name = "root_panel";
            root_panel.Size = new Size(2401, 1567);
            root_panel.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(2216, 151);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 7;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // sell_button
            // 
            sell_button.BackColor = SystemColors.ButtonFace;
            sell_button.FlatStyle = FlatStyle.Flat;
            sell_button.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sell_button.ForeColor = Color.FromArgb(205, 153, 47);
            sell_button.Location = new Point(59, 1449);
            sell_button.Name = "sell_button";
            sell_button.Size = new Size(327, 91);
            sell_button.TabIndex = 6;
            sell_button.Text = "Sell";
            sell_button.UseVisualStyleBackColor = false;
            sell_button.Click += sell_button_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.FromArgb(205, 153, 47);
            dataGridView1.Location = new Point(59, 242);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(2307, 1175);
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
            // add_button
            // 
            add_button.BackColor = SystemColors.ButtonFace;
            add_button.FlatStyle = FlatStyle.Flat;
            add_button.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_button.ForeColor = Color.FromArgb(205, 153, 47);
            add_button.Location = new Point(445, 1449);
            add_button.Name = "add_button";
            add_button.Size = new Size(327, 91);
            add_button.TabIndex = 8;
            add_button.Text = "Add";
            add_button.UseVisualStyleBackColor = false;
            // 
            // edit_button
            // 
            edit_button.BackColor = SystemColors.ButtonFace;
            edit_button.FlatStyle = FlatStyle.Flat;
            edit_button.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            edit_button.ForeColor = Color.FromArgb(205, 153, 47);
            edit_button.Location = new Point(833, 1449);
            edit_button.Name = "edit_button";
            edit_button.Size = new Size(327, 91);
            edit_button.TabIndex = 9;
            edit_button.Text = "Edit";
            edit_button.UseVisualStyleBackColor = false;
            // 
            // restock_button
            // 
            restock_button.BackColor = SystemColors.ButtonFace;
            restock_button.FlatStyle = FlatStyle.Flat;
            restock_button.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            restock_button.ForeColor = Color.FromArgb(205, 153, 47);
            restock_button.Location = new Point(1229, 1449);
            restock_button.Name = "restock_button";
            restock_button.Size = new Size(327, 91);
            restock_button.TabIndex = 10;
            restock_button.Text = "Restock";
            restock_button.UseVisualStyleBackColor = false;
            // 
            // delete_button
            // 
            delete_button.BackColor = SystemColors.ButtonFace;
            delete_button.FlatStyle = FlatStyle.Flat;
            delete_button.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete_button.ForeColor = Color.Red;
            delete_button.Location = new Point(1613, 1449);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(327, 91);
            delete_button.TabIndex = 11;
            delete_button.Text = "Delete";
            delete_button.UseVisualStyleBackColor = false;
            // 
            // Medicament_Form
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2401, 1567);
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
        private Button sell_button;
        private Button button1;
        private Button delete_button;
        private Button restock_button;
        private Button edit_button;
        private Button add_button;
    }
}