
namespace Car_Rental_Application
{
    partial class SearchClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchClient));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_back_client = new System.Windows.Forms.Button();
            this.ClientList = new System.Windows.Forms.ListBox();
            this.txt_s_email = new System.Windows.Forms.TextBox();
            this.txt_s_phone = new System.Windows.Forms.TextBox();
            this.txt_s_address = new System.Windows.Forms.TextBox();
            this.txt_s_age = new System.Windows.Forms.TextBox();
            this.txt_s_cname = new System.Windows.Forms.TextBox();
            this.txt_s_ssn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.panel1.Controls.Add(this.btn_back_client);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1740, 69);
            this.panel1.TabIndex = 2;
            // 
            // btn_back_client
            // 
            this.btn_back_client.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back_client.BackgroundImage")));
            this.btn_back_client.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back_client.FlatAppearance.BorderSize = 0;
            this.btn_back_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back_client.Location = new System.Drawing.Point(12, 3);
            this.btn_back_client.Name = "btn_back_client";
            this.btn_back_client.Size = new System.Drawing.Size(108, 63);
            this.btn_back_client.TabIndex = 3;
            this.btn_back_client.UseVisualStyleBackColor = true;
            this.btn_back_client.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClientList
            // 
            this.ClientList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.ClientList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClientList.FormattingEnabled = true;
            this.ClientList.ItemHeight = 21;
            this.ClientList.Location = new System.Drawing.Point(775, 191);
            this.ClientList.Name = "ClientList";
            this.ClientList.Size = new System.Drawing.Size(879, 567);
            this.ClientList.TabIndex = 3;
            this.ClientList.SelectedIndexChanged += new System.EventHandler(this.ClientList_SelectedIndexChanged);
            // 
            // txt_s_email
            // 
            this.txt_s_email.Location = new System.Drawing.Point(372, 656);
            this.txt_s_email.Name = "txt_s_email";
            this.txt_s_email.Size = new System.Drawing.Size(177, 27);
            this.txt_s_email.TabIndex = 30;
            // 
            // txt_s_phone
            // 
            this.txt_s_phone.Location = new System.Drawing.Point(372, 573);
            this.txt_s_phone.Name = "txt_s_phone";
            this.txt_s_phone.Size = new System.Drawing.Size(177, 27);
            this.txt_s_phone.TabIndex = 29;
            // 
            // txt_s_address
            // 
            this.txt_s_address.Location = new System.Drawing.Point(372, 486);
            this.txt_s_address.Name = "txt_s_address";
            this.txt_s_address.Size = new System.Drawing.Size(177, 27);
            this.txt_s_address.TabIndex = 28;
            // 
            // txt_s_age
            // 
            this.txt_s_age.Location = new System.Drawing.Point(372, 403);
            this.txt_s_age.Name = "txt_s_age";
            this.txt_s_age.Size = new System.Drawing.Size(177, 27);
            this.txt_s_age.TabIndex = 27;
            // 
            // txt_s_cname
            // 
            this.txt_s_cname.Location = new System.Drawing.Point(372, 324);
            this.txt_s_cname.Name = "txt_s_cname";
            this.txt_s_cname.Size = new System.Drawing.Size(177, 27);
            this.txt_s_cname.TabIndex = 26;
            // 
            // txt_s_ssn
            // 
            this.txt_s_ssn.Location = new System.Drawing.Point(372, 237);
            this.txt_s_ssn.Name = "txt_s_ssn";
            this.txt_s_ssn.Size = new System.Drawing.Size(177, 27);
            this.txt_s_ssn.TabIndex = 25;
            this.txt_s_ssn.TextChanged += new System.EventHandler(this.txt_s_ssn_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(254, 652);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 29);
            this.label7.TabIndex = 24;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(254, 569);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 29);
            this.label6.TabIndex = 23;
            this.label6.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(254, 486);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 29);
            this.label5.TabIndex = 22;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(254, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 29);
            this.label4.TabIndex = 21;
            this.label4.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(254, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(254, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "SSN";
            // 
            // SearchClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1740, 870);
            this.Controls.Add(this.txt_s_email);
            this.Controls.Add(this.txt_s_phone);
            this.Controls.Add(this.txt_s_address);
            this.Controls.Add(this.txt_s_age);
            this.Controls.Add(this.txt_s_cname);
            this.Controls.Add(this.txt_s_ssn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClientList);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SearchClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SearchClient_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_back_client;
        private System.Windows.Forms.ListBox ClientList;
        private System.Windows.Forms.TextBox txt_s_email;
        private System.Windows.Forms.TextBox txt_s_phone;
        private System.Windows.Forms.TextBox txt_s_address;
        private System.Windows.Forms.TextBox txt_s_age;
        private System.Windows.Forms.TextBox txt_s_cname;
        private System.Windows.Forms.TextBox txt_s_ssn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}