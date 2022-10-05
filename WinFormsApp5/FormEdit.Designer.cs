namespace WinFormsApp5
{
    partial class FormEdit
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
            this.label_title = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_title.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_title.Location = new System.Drawing.Point(70, 16);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(223, 65);
            this.label_title.TabIndex = 11;
            this.label_title.Text = "Edit Page";
            // 
            // btn_save
            // 
            this.btn_save.AutoSize = true;
            this.btn_save.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_save.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_save.Location = new System.Drawing.Point(190, 312);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(122, 47);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_discount
            // 
            this.txt_discount.Location = new System.Drawing.Point(53, 231);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(257, 35);
            this.txt_discount.TabIndex = 7;
            this.txt_discount.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(53, 178);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(257, 35);
            this.txt_price.TabIndex = 8;
            this.txt_price.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(53, 125);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(257, 35);
            this.txt_name.TabIndex = 5;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSize = true;
            this.btn_cancel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_cancel.Location = new System.Drawing.Point(55, 312);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(122, 47);
            this.btn_cancel.TabIndex = 12;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 390);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_discount);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_name);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormEdit";
            this.Load += new System.EventHandler(this.FormEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_title;
        private Button btn_save;
        private Button btn_cancel;
        public TextBox txt_discount;
        public TextBox txt_price;
        public TextBox txt_name;
    }
}