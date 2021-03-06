﻿namespace Digital_Storehouse.Views
{
    partial class NewOrder
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
            this.customerId_F_combobox = new System.Windows.Forms.ComboBox();
            this.customerId_F_label = new System.Windows.Forms.Label();
            this.deliveryLocation_label = new System.Windows.Forms.Label();
            this.orderDate_label = new System.Windows.Forms.Label();
            this.paymentMethod_label = new System.Windows.Forms.Label();
            this.addOrder_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.deliveryLocation_textbox = new Digital_Storehouse.Models.MyTextBox();
            this.orderDate_picker = new System.Windows.Forms.DateTimePicker();
            this.paymentMethodCombobox = new System.Windows.Forms.ComboBox();
            this.are_required_label = new System.Windows.Forms.Label();
            this.asterix_warning = new System.Windows.Forms.Label();
            this.all_fields_marked_with_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customerId_F_combobox
            // 
            this.customerId_F_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerId_F_combobox.FormattingEnabled = true;
            this.customerId_F_combobox.Location = new System.Drawing.Point(174, 131);
            this.customerId_F_combobox.Name = "customerId_F_combobox";
            this.customerId_F_combobox.Size = new System.Drawing.Size(38, 21);
            this.customerId_F_combobox.TabIndex = 101;
            // 
            // customerId_F_label
            // 
            this.customerId_F_label.AutoSize = true;
            this.customerId_F_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.customerId_F_label.Location = new System.Drawing.Point(62, 134);
            this.customerId_F_label.Name = "customerId_F_label";
            this.customerId_F_label.Size = new System.Drawing.Size(100, 13);
            this.customerId_F_label.TabIndex = 96;
            this.customerId_F_label.Text = "CUSTOMER_ID:";
            // 
            // deliveryLocation_label
            // 
            this.deliveryLocation_label.AutoSize = true;
            this.deliveryLocation_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.deliveryLocation_label.Location = new System.Drawing.Point(386, 137);
            this.deliveryLocation_label.Name = "deliveryLocation_label";
            this.deliveryLocation_label.Size = new System.Drawing.Size(141, 13);
            this.deliveryLocation_label.TabIndex = 95;
            this.deliveryLocation_label.Text = "DELIVERY_LOCATION:";
            // 
            // orderDate_label
            // 
            this.orderDate_label.AutoSize = true;
            this.orderDate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.orderDate_label.Location = new System.Drawing.Point(62, 81);
            this.orderDate_label.Name = "orderDate_label";
            this.orderDate_label.Size = new System.Drawing.Size(95, 13);
            this.orderDate_label.TabIndex = 94;
            this.orderDate_label.Text = "ORDER_DATE:";
            // 
            // paymentMethod_label
            // 
            this.paymentMethod_label.AutoSize = true;
            this.paymentMethod_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.paymentMethod_label.Location = new System.Drawing.Point(386, 81);
            this.paymentMethod_label.Name = "paymentMethod_label";
            this.paymentMethod_label.Size = new System.Drawing.Size(130, 13);
            this.paymentMethod_label.TabIndex = 93;
            this.paymentMethod_label.Text = "PAYMENT_METHOD:";
            // 
            // addOrder_button
            // 
            this.addOrder_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addOrder_button.ForeColor = System.Drawing.Color.Green;
            this.addOrder_button.Location = new System.Drawing.Point(350, 215);
            this.addOrder_button.Name = "addOrder_button";
            this.addOrder_button.Size = new System.Drawing.Size(83, 23);
            this.addOrder_button.TabIndex = 102;
            this.addOrder_button.Text = "Add Order";
            this.addOrder_button.UseVisualStyleBackColor = true;
            this.addOrder_button.Click += new System.EventHandler(this.addOrder_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancel_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cancel_button.Location = new System.Drawing.Point(210, 215);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(83, 23);
            this.cancel_button.TabIndex = 103;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // deliveryLocation_textbox
            // 
            this.deliveryLocation_textbox.Location = new System.Drawing.Point(547, 134);
            this.deliveryLocation_textbox.MaxLength = 50;
            this.deliveryLocation_textbox.Name = "deliveryLocation_textbox";
            this.deliveryLocation_textbox.Size = new System.Drawing.Size(100, 20);
            this.deliveryLocation_textbox.TabIndex = 107;
            // 
            // orderDate_picker
            // 
            this.orderDate_picker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.orderDate_picker.Location = new System.Drawing.Point(174, 78);
            this.orderDate_picker.Name = "orderDate_picker";
            this.orderDate_picker.Size = new System.Drawing.Size(100, 20);
            this.orderDate_picker.TabIndex = 108;
            // 
            // paymentMethodCombobox
            // 
            this.paymentMethodCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentMethodCombobox.FormattingEnabled = true;
            this.paymentMethodCombobox.Items.AddRange(new object[] {
            "Cash",
            "Credit Card",
            "Check",
            "Coupon"});
            this.paymentMethodCombobox.Location = new System.Drawing.Point(547, 78);
            this.paymentMethodCombobox.Name = "paymentMethodCombobox";
            this.paymentMethodCombobox.Size = new System.Drawing.Size(72, 21);
            this.paymentMethodCombobox.TabIndex = 109;
            // 
            // are_required_label
            // 
            this.are_required_label.AutoSize = true;
            this.are_required_label.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.are_required_label.Location = new System.Drawing.Point(140, 9);
            this.are_required_label.Name = "are_required_label";
            this.are_required_label.Size = new System.Drawing.Size(73, 13);
            this.are_required_label.TabIndex = 122;
            this.are_required_label.Text = "are required.";
            // 
            // asterix_warning
            // 
            this.asterix_warning.AutoSize = true;
            this.asterix_warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.asterix_warning.ForeColor = System.Drawing.Color.Red;
            this.asterix_warning.Location = new System.Drawing.Point(127, 9);
            this.asterix_warning.Name = "asterix_warning";
            this.asterix_warning.Size = new System.Drawing.Size(18, 24);
            this.asterix_warning.TabIndex = 121;
            this.asterix_warning.Text = "*";
            // 
            // all_fields_marked_with_label
            // 
            this.all_fields_marked_with_label.AutoSize = true;
            this.all_fields_marked_with_label.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.all_fields_marked_with_label.Location = new System.Drawing.Point(12, 9);
            this.all_fields_marked_with_label.Name = "all_fields_marked_with_label";
            this.all_fields_marked_with_label.Size = new System.Drawing.Size(118, 13);
            this.all_fields_marked_with_label.TabIndex = 120;
            this.all_fields_marked_with_label.Text = "All fields marked with";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(38, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 24);
            this.label1.TabIndex = 123;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(38, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 24);
            this.label2.TabIndex = 124;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(362, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 24);
            this.label3.TabIndex = 125;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(362, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 24);
            this.label4.TabIndex = 126;
            this.label4.Text = "*";
            // 
            // NewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 272);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.are_required_label);
            this.Controls.Add(this.asterix_warning);
            this.Controls.Add(this.all_fields_marked_with_label);
            this.Controls.Add(this.paymentMethodCombobox);
            this.Controls.Add(this.orderDate_picker);
            this.Controls.Add(this.deliveryLocation_textbox);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.addOrder_button);
            this.Controls.Add(this.customerId_F_combobox);
            this.Controls.Add(this.customerId_F_label);
            this.Controls.Add(this.deliveryLocation_label);
            this.Controls.Add(this.orderDate_label);
            this.Controls.Add(this.paymentMethod_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NewOrder";
            this.Text = "NewOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox customerId_F_combobox;
        private System.Windows.Forms.Label customerId_F_label;
        private System.Windows.Forms.Label deliveryLocation_label;
        private System.Windows.Forms.Label orderDate_label;
        private System.Windows.Forms.Label paymentMethod_label;
        private System.Windows.Forms.Button addOrder_button;
        private System.Windows.Forms.Button cancel_button;
        private Models.MyTextBox deliveryLocation_textbox;
        private System.Windows.Forms.DateTimePicker orderDate_picker;
        private System.Windows.Forms.ComboBox paymentMethodCombobox;
        private System.Windows.Forms.Label are_required_label;
        private System.Windows.Forms.Label asterix_warning;
        private System.Windows.Forms.Label all_fields_marked_with_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}