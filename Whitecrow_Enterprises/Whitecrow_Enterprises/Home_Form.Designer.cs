namespace Whitecrow_Enterprises
{
    partial class Home_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home_Form));
            root_panel = new Panel();
            formloader_panel = new Panel();
            sidebar_panel = new Panel();
            construction_button = new Button();
            pictureBox1 = new PictureBox();
            agriculture_button = new Button();
            medicament_button = new Button();
            header_panel = new Panel();
            close_button = new Button();
            root_panel.SuspendLayout();
            sidebar_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            header_panel.SuspendLayout();
            SuspendLayout();
            // 
            // root_panel
            // 
            root_panel.Controls.Add(formloader_panel);
            root_panel.Controls.Add(sidebar_panel);
            root_panel.Controls.Add(header_panel);
            root_panel.Dock = DockStyle.Fill;
            root_panel.Location = new Point(0, 0);
            root_panel.Name = "root_panel";
            root_panel.Size = new Size(1894, 1129);
            root_panel.TabIndex = 0;
            // 
            // formloader_panel
            // 
            formloader_panel.Dock = DockStyle.Fill;
            formloader_panel.Location = new Point(331, 76);
            formloader_panel.Name = "formloader_panel";
            formloader_panel.Size = new Size(1563, 1053);
            formloader_panel.TabIndex = 2;
            formloader_panel.Paint += formloader_panel_Paint;
            // 
            // sidebar_panel
            // 
            sidebar_panel.BackColor = Color.FromArgb(205, 153, 47);
            sidebar_panel.Controls.Add(construction_button);
            sidebar_panel.Controls.Add(pictureBox1);
            sidebar_panel.Controls.Add(agriculture_button);
            sidebar_panel.Controls.Add(medicament_button);
            sidebar_panel.Dock = DockStyle.Left;
            sidebar_panel.Location = new Point(0, 76);
            sidebar_panel.Name = "sidebar_panel";
            sidebar_panel.Size = new Size(331, 1053);
            sidebar_panel.TabIndex = 1;
            // 
            // construction_button
            // 
            construction_button.FlatStyle = FlatStyle.Flat;
            construction_button.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            construction_button.ForeColor = SystemColors.Control;
            construction_button.Image = (Image)resources.GetObject("construction_button.Image");
            construction_button.Location = new Point(0, 146);
            construction_button.Name = "construction_button";
            construction_button.Size = new Size(331, 67);
            construction_button.TabIndex = 4;
            construction_button.Text = "Construction";
            construction_button.TextImageRelation = TextImageRelation.ImageBeforeText;
            construction_button.UseVisualStyleBackColor = true;
            construction_button.Click += construction_button_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Bottom;
            pictureBox1.Location = new Point(0, 749);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(331, 304);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // agriculture_button
            // 
            agriculture_button.FlatStyle = FlatStyle.Flat;
            agriculture_button.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            agriculture_button.ForeColor = SystemColors.Control;
            agriculture_button.Image = (Image)resources.GetObject("agriculture_button.Image");
            agriculture_button.Location = new Point(0, 73);
            agriculture_button.Name = "agriculture_button";
            agriculture_button.Size = new Size(331, 67);
            agriculture_button.TabIndex = 3;
            agriculture_button.Text = "Agriculture";
            agriculture_button.TextImageRelation = TextImageRelation.ImageBeforeText;
            agriculture_button.UseVisualStyleBackColor = true;
            agriculture_button.Click += agriculture_button_Click;
            // 
            // medicament_button
            // 
            medicament_button.FlatStyle = FlatStyle.Flat;
            medicament_button.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            medicament_button.ForeColor = SystemColors.Control;
            medicament_button.Image = (Image)resources.GetObject("medicament_button.Image");
            medicament_button.Location = new Point(0, 0);
            medicament_button.Name = "medicament_button";
            medicament_button.Size = new Size(331, 67);
            medicament_button.TabIndex = 2;
            medicament_button.Text = "Medicaments";
            medicament_button.TextImageRelation = TextImageRelation.ImageBeforeText;
            medicament_button.UseVisualStyleBackColor = true;
            medicament_button.Click += medicament_button_Click;
            // 
            // header_panel
            // 
            header_panel.BackColor = Color.FromArgb(205, 153, 47);
            header_panel.Controls.Add(close_button);
            header_panel.Dock = DockStyle.Top;
            header_panel.Location = new Point(0, 0);
            header_panel.Name = "header_panel";
            header_panel.Size = new Size(1894, 76);
            header_panel.TabIndex = 0;
            header_panel.Paint += header_panel_Paint;
            // 
            // close_button
            // 
            close_button.Dock = DockStyle.Right;
            close_button.FlatStyle = FlatStyle.Flat;
            close_button.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            close_button.Image = (Image)resources.GetObject("close_button.Image");
            close_button.Location = new Point(1809, 0);
            close_button.Name = "close_button";
            close_button.Size = new Size(85, 76);
            close_button.TabIndex = 1;
            close_button.UseVisualStyleBackColor = true;
            close_button.Click += close_button_Click;
            // 
            // Home_Form
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1894, 1129);
            Controls.Add(root_panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WHITECROW ENTERPRISES";
            WindowState = FormWindowState.Maximized;
            root_panel.ResumeLayout(false);
            sidebar_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            header_panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel root_panel;
        private Panel header_panel;
        private Button close_button;
        private Panel sidebar_panel;
        private Button medicament_button;
        private Button agriculture_button;
        private PictureBox pictureBox1;
        private Panel formloader_panel;
        private Button construction_button;
    }
}