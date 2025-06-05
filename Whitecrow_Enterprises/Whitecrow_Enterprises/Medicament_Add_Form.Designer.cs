namespace Whitecrow_Enterprises
{
    partial class Medicament_Add_Form
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            cancel_button = new Button();
            clear_button = new Button();
            save_button = new Button();
            header_label = new Label();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cancel_button);
            panel1.Controls.Add(clear_button);
            panel1.Controls.Add(save_button);
            panel1.Controls.Add(header_label);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1537, 982);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // cancel_button
            // 
            cancel_button.BackColor = SystemColors.ButtonFace;
            cancel_button.FlatStyle = FlatStyle.Flat;
            cancel_button.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancel_button.ForeColor = Color.Gray;
            cancel_button.Location = new Point(1287, 897);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(234, 69);
            cancel_button.TabIndex = 10;
            cancel_button.Text = "Cancel";
            cancel_button.UseVisualStyleBackColor = false;
            cancel_button.Click += cancel_button_Click;
            // 
            // clear_button
            // 
            clear_button.BackColor = SystemColors.ButtonFace;
            clear_button.FlatStyle = FlatStyle.Flat;
            clear_button.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clear_button.ForeColor = Color.FromArgb(205, 153, 47);
            clear_button.Location = new Point(1047, 897);
            clear_button.Name = "clear_button";
            clear_button.Size = new Size(234, 69);
            clear_button.TabIndex = 9;
            clear_button.Text = "Clear";
            clear_button.UseVisualStyleBackColor = false;
            // 
            // save_button
            // 
            save_button.BackColor = Color.FromArgb(205, 153, 47);
            save_button.FlatStyle = FlatStyle.Flat;
            save_button.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            save_button.ForeColor = Color.White;
            save_button.Location = new Point(807, 897);
            save_button.Name = "save_button";
            save_button.Size = new Size(234, 69);
            save_button.TabIndex = 7;
            save_button.Text = "Save";
            save_button.UseVisualStyleBackColor = false;
            // 
            // header_label
            // 
            header_label.AutoSize = true;
            header_label.Font = new Font("Segoe UI", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            header_label.ForeColor = Color.FromArgb(205, 153, 47);
            header_label.Location = new Point(475, 53);
            header_label.Name = "header_label";
            header_label.Size = new Size(554, 71);
            header_label.TabIndex = 4;
            header_label.Text = "ADD NEW MEDICINE";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(205, 153, 47);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(10, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1517, 50);
            panel5.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(205, 153, 47);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(1527, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 972);
            panel4.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(205, 153, 47);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(10, 972);
            panel3.Name = "panel3";
            panel3.Size = new Size(1527, 10);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(205, 153, 47);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 982);
            panel2.TabIndex = 0;
            // 
            // Medicament_Add_Form
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1537, 982);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Medicament_Add_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Medicament_Add_Form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Label header_label;
        private Button save_button;
        private Button clear_button;
        private Button cancel_button;
        private System.Windows.Forms.Timer timer1;
    }
}