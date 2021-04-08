
namespace Car_Rental_Application
{
    partial class SearchCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchCar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_back_car = new System.Windows.Forms.Button();
            this.CarList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_search_brand = new System.Windows.Forms.TextBox();
            this.txt_search_color = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.panel1.Controls.Add(this.btn_back_car);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1740, 69);
            this.panel1.TabIndex = 2;
            // 
            // btn_back_car
            // 
            this.btn_back_car.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back_car.BackgroundImage")));
            this.btn_back_car.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back_car.FlatAppearance.BorderSize = 0;
            this.btn_back_car.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back_car.ForeColor = System.Drawing.Color.Transparent;
            this.btn_back_car.Location = new System.Drawing.Point(12, 3);
            this.btn_back_car.Name = "btn_back_car";
            this.btn_back_car.Size = new System.Drawing.Size(110, 63);
            this.btn_back_car.TabIndex = 31;
            this.btn_back_car.UseVisualStyleBackColor = true;
            this.btn_back_car.Click += new System.EventHandler(this.btn_back_car_Click);
            // 
            // CarList
            // 
            this.CarList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.CarList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CarList.FormattingEnabled = true;
            this.CarList.ItemHeight = 21;
            this.CarList.Location = new System.Drawing.Point(775, 191);
            this.CarList.Name = "CarList";
            this.CarList.Size = new System.Drawing.Size(879, 567);
            this.CarList.TabIndex = 3;
            this.CarList.SelectedIndexChanged += new System.EventHandler(this.EmployeeList_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(254, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(254, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "Brand";
            // 
            // txt_search_brand
            // 
            this.txt_search_brand.Location = new System.Drawing.Point(415, 237);
            this.txt_search_brand.Name = "txt_search_brand";
            this.txt_search_brand.Size = new System.Drawing.Size(147, 27);
            this.txt_search_brand.TabIndex = 21;
            this.txt_search_brand.TextChanged += new System.EventHandler(this.txt_search_brand_TextChanged);
            // 
            // txt_search_color
            // 
            this.txt_search_color.Location = new System.Drawing.Point(415, 320);
            this.txt_search_color.Name = "txt_search_color";
            this.txt_search_color.Size = new System.Drawing.Size(147, 27);
            this.txt_search_color.TabIndex = 22;
            // 
            // SearchCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1740, 870);
            this.Controls.Add(this.txt_search_color);
            this.Controls.Add(this.txt_search_brand);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CarList);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SearchCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SearchClient_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox CarList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_back_car;
        private System.Windows.Forms.TextBox txt_search_brand;
        private System.Windows.Forms.TextBox txt_search_color;
    }
}