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
            barcode_tb = new TextBox();
            supplier_tb = new TextBox();
            manufacture_datepicker = new DateTimePicker();
            expiry_datepicker = new DateTimePicker();
            purchase_price_tb = new TextBox();
            selling_price_tb = new TextBox();
            stock_quantity_tb = new TextBox();
            dosage_form_cb = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            brand_name_tb = new TextBox();
            label2 = new Label();
            label1 = new Label();
            generic_name_tb = new TextBox();
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
            panel1.Controls.Add(barcode_tb);
            panel1.Controls.Add(supplier_tb);
            panel1.Controls.Add(manufacture_datepicker);
            panel1.Controls.Add(expiry_datepicker);
            panel1.Controls.Add(purchase_price_tb);
            panel1.Controls.Add(selling_price_tb);
            panel1.Controls.Add(stock_quantity_tb);
            panel1.Controls.Add(dosage_form_cb);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(brand_name_tb);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(generic_name_tb);
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
            // barcode_tb
            // 
            barcode_tb.BorderStyle = BorderStyle.FixedSingle;
            barcode_tb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            barcode_tb.Location = new Point(794, 691);
            barcode_tb.Name = "barcode_tb";
            barcode_tb.Size = new Size(596, 50);
            barcode_tb.TabIndex = 36;
            // 
            // supplier_tb
            // 
            supplier_tb.BorderStyle = BorderStyle.FixedSingle;
            supplier_tb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            supplier_tb.Location = new Point(109, 691);
            supplier_tb.Name = "supplier_tb";
            supplier_tb.Size = new Size(596, 50);
            supplier_tb.TabIndex = 35;
            // 
            // manufacture_datepicker
            // 
            manufacture_datepicker.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            manufacture_datepicker.Location = new Point(794, 580);
            manufacture_datepicker.Name = "manufacture_datepicker";
            manufacture_datepicker.Size = new Size(596, 50);
            manufacture_datepicker.TabIndex = 34;
            // 
            // expiry_datepicker
            // 
            expiry_datepicker.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            expiry_datepicker.Location = new Point(109, 580);
            expiry_datepicker.Name = "expiry_datepicker";
            expiry_datepicker.Size = new Size(596, 50);
            expiry_datepicker.TabIndex = 33;
            expiry_datepicker.ValueChanged += expiry_datepicker_ValueChanged;
            // 
            // purchase_price_tb
            // 
            purchase_price_tb.BorderStyle = BorderStyle.FixedSingle;
            purchase_price_tb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            purchase_price_tb.Location = new Point(794, 470);
            purchase_price_tb.Name = "purchase_price_tb";
            purchase_price_tb.PlaceholderText = " ₱ 00.00";
            purchase_price_tb.Size = new Size(596, 50);
            purchase_price_tb.TabIndex = 32;
            // 
            // selling_price_tb
            // 
            selling_price_tb.BorderStyle = BorderStyle.FixedSingle;
            selling_price_tb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            selling_price_tb.Location = new Point(109, 470);
            selling_price_tb.Name = "selling_price_tb";
            selling_price_tb.PlaceholderText = " ₱ 00.00";
            selling_price_tb.Size = new Size(596, 50);
            selling_price_tb.TabIndex = 31;
            // 
            // stock_quantity_tb
            // 
            stock_quantity_tb.BorderStyle = BorderStyle.FixedSingle;
            stock_quantity_tb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stock_quantity_tb.Location = new Point(794, 361);
            stock_quantity_tb.Name = "stock_quantity_tb";
            stock_quantity_tb.Size = new Size(596, 50);
            stock_quantity_tb.TabIndex = 30;
            stock_quantity_tb.TextChanged += stock_quantity_tb_TextChanged;
            // 
            // dosage_form_cb
            // 
            dosage_form_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            dosage_form_cb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dosage_form_cb.FormattingEnabled = true;
            dosage_form_cb.Location = new Point(109, 358);
            dosage_form_cb.Name = "dosage_form_cb";
            dosage_form_cb.Size = new Size(596, 53);
            dosage_form_cb.TabIndex = 29;
            dosage_form_cb.SelectedIndexChanged += dosage_form_cb_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(794, 643);
            label10.Name = "label10";
            label10.Size = new Size(135, 45);
            label10.TabIndex = 28;
            label10.Text = "Barcode";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(109, 643);
            label9.Name = "label9";
            label9.Size = new Size(137, 45);
            label9.TabIndex = 27;
            label9.Text = "Supplier";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(794, 532);
            label8.Name = "label8";
            label8.Size = new Size(274, 45);
            label8.TabIndex = 24;
            label8.Text = "Manufacture Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(109, 532);
            label7.Name = "label7";
            label7.Size = new Size(179, 45);
            label7.TabIndex = 23;
            label7.Text = "Expiry Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(794, 422);
            label6.Name = "label6";
            label6.Size = new Size(225, 45);
            label6.TabIndex = 20;
            label6.Text = "Purchase Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(109, 422);
            label5.Name = "label5";
            label5.Size = new Size(193, 45);
            label5.TabIndex = 19;
            label5.Text = "Selling Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(794, 310);
            label4.Name = "label4";
            label4.Size = new Size(227, 45);
            label4.TabIndex = 16;
            label4.Text = "Stock Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(109, 310);
            label3.Name = "label3";
            label3.Size = new Size(210, 45);
            label3.TabIndex = 15;
            label3.Text = "Dosage Form";
            // 
            // brand_name_tb
            // 
            brand_name_tb.BorderStyle = BorderStyle.FixedSingle;
            brand_name_tb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            brand_name_tb.Location = new Point(794, 247);
            brand_name_tb.Name = "brand_name_tb";
            brand_name_tb.Size = new Size(596, 50);
            brand_name_tb.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(794, 199);
            label2.Name = "label2";
            label2.Size = new Size(196, 45);
            label2.TabIndex = 13;
            label2.Text = "Brand Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(109, 199);
            label1.Name = "label1";
            label1.Size = new Size(222, 45);
            label1.TabIndex = 12;
            label1.Text = "Generic Name";
            // 
            // generic_name_tb
            // 
            generic_name_tb.BorderStyle = BorderStyle.FixedSingle;
            generic_name_tb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            generic_name_tb.Location = new Point(109, 247);
            generic_name_tb.Name = "generic_name_tb";
            generic_name_tb.Size = new Size(596, 50);
            generic_name_tb.TabIndex = 11;
            generic_name_tb.TextChanged += textBox1_TextChanged;
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
            clear_button.Click += clear_button_Click;
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
        private TextBox generic_name_tb;
        private Label label1;
        private TextBox brand_name_tb;
        private Label label2;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox barcode_tb;
        private TextBox supplier_tb;
        private DateTimePicker manufacture_datepicker;
        private DateTimePicker expiry_datepicker;
        private TextBox purchase_price_tb;
        private TextBox selling_price_tb;
        private TextBox stock_quantity_tb;
        private ComboBox dosage_form_cb;
    }
}