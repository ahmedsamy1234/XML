
namespace XMLProject
{
    partial class form
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
            this.name = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.addressText = new System.Windows.Forms.TextBox();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.insert = new System.Windows.Forms.Button();
            this.SearchByname = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.prev = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(177, 47);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(39, 15);
            this.name.TabIndex = 0;
            this.name.Text = "Name";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(177, 115);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(41, 15);
            this.phone.TabIndex = 1;
            this.phone.Text = "phone";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(177, 184);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(47, 15);
            this.address.TabIndex = 2;
            this.address.Text = "address";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(177, 244);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(36, 15);
            this.email.TabIndex = 3;
            this.email.Text = "email";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(396, 47);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(255, 23);
            this.nameText.TabIndex = 4;
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(396, 236);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(255, 23);
            this.emailText.TabIndex = 5;
            // 
            // addressText
            // 
            this.addressText.Location = new System.Drawing.Point(396, 176);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(255, 23);
            this.addressText.TabIndex = 6;
            // 
            // phoneText
            // 
            this.phoneText.Location = new System.Drawing.Point(396, 107);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(255, 23);
            this.phoneText.TabIndex = 7;
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(66, 295);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(75, 23);
            this.insert.TabIndex = 8;
            this.insert.Text = "insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // SearchByname
            // 
            this.SearchByname.Location = new System.Drawing.Point(593, 295);
            this.SearchByname.Name = "SearchByname";
            this.SearchByname.Size = new System.Drawing.Size(75, 23);
            this.SearchByname.TabIndex = 9;
            this.SearchByname.Text = "search by name";
            this.SearchByname.UseVisualStyleBackColor = true;
            this.SearchByname.Click += new System.EventHandler(this.SearchByname_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(419, 295);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 10;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(237, 295);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 11;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(66, 379);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 12;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // prev
            // 
            this.prev.Location = new System.Drawing.Point(237, 379);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(75, 23);
            this.prev.TabIndex = 13;
            this.prev.Text = "Prev";
            this.prev.UseVisualStyleBackColor = true;
            this.prev.Click += new System.EventHandler(this.prev_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(518, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.prev);
            this.Controls.Add(this.next);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.SearchByname);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.addressText);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.email);
            this.Controls.Add(this.address);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.name);
            this.Name = "form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button SearchByname;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button prev;
        private System.Windows.Forms.Button button1;
    }
}

