namespace WinFormsApp5
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.label_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(51, 145);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(257, 35);
            this.txt_id.TabIndex = 0;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(51, 187);
            this.txt_name.Name = "txt_name";
            this.txt_name.ReadOnly = true;
            this.txt_name.Size = new System.Drawing.Size(257, 35);
            this.txt_name.TabIndex = 0;
            // 
            // txt_discount
            // 
            this.txt_discount.Location = new System.Drawing.Point(51, 271);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.ReadOnly = true;
            this.txt_discount.Size = new System.Drawing.Size(257, 35);
            this.txt_discount.TabIndex = 1;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(51, 229);
            this.txt_price.Name = "txt_price";
            this.txt_price.ReadOnly = true;
            this.txt_price.Size = new System.Drawing.Size(257, 35);
            this.txt_price.TabIndex = 2;
            // 
            // btn_load
            // 
            this.btn_load.AutoSize = true;
            this.btn_load.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_load.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_load.Location = new System.Drawing.Point(51, 362);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(122, 47);
            this.btn_load.TabIndex = 3;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.AutoSize = true;
            this.btn_edit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_edit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_edit.Location = new System.Drawing.Point(186, 362);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(122, 47);
            this.btn_edit.TabIndex = 3;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_title.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_title.Location = new System.Drawing.Point(86, 39);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(186, 65);
            this.label_title.TabIndex = 4;
            this.label_title.Text = "E-Bazar";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 459);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.txt_discount);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_id);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_id;
        private TextBox txt_name;
        private TextBox txt_discount;
        private TextBox txt_price;
        private Button btn_load;
        private Button btn_edit;
        private Label label_title;
    }
}