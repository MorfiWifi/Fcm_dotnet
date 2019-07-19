namespace FCM_notifyer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_SimpleNotif = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbox_body = new System.Windows.Forms.TextBox();
            this.txbox_to = new System.Windows.Forms.TextBox();
            this.txbox_title = new System.Windows.Forms.TextBox();
            this.tab_Data = new System.Windows.Forms.TabPage();
            this.richbox_data = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richbox_res = new System.Windows.Forms.RichTextBox();
            this.txbox_key = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tab_SimpleNotif.SuspendLayout();
            this.tab_Data.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(723, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_SimpleNotif);
            this.tabControl1.Controls.Add(this.tab_Data);
            this.tabControl1.Location = new System.Drawing.Point(1, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 333);
            this.tabControl1.TabIndex = 1;
            // 
            // tab_SimpleNotif
            // 
            this.tab_SimpleNotif.Controls.Add(this.label4);
            this.tab_SimpleNotif.Controls.Add(this.label5);
            this.tab_SimpleNotif.Controls.Add(this.label3);
            this.tab_SimpleNotif.Controls.Add(this.txbox_body);
            this.tab_SimpleNotif.Controls.Add(this.txbox_to);
            this.tab_SimpleNotif.Controls.Add(this.txbox_title);
            this.tab_SimpleNotif.Location = new System.Drawing.Point(4, 22);
            this.tab_SimpleNotif.Name = "tab_SimpleNotif";
            this.tab_SimpleNotif.Padding = new System.Windows.Forms.Padding(3);
            this.tab_SimpleNotif.Size = new System.Drawing.Size(793, 307);
            this.tab_SimpleNotif.TabIndex = 0;
            this.tab_SimpleNotif.Text = "SimpleNotif";
            this.tab_SimpleNotif.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Body";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "to";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Title";
            // 
            // txbox_body
            // 
            this.txbox_body.Location = new System.Drawing.Point(72, 65);
            this.txbox_body.Multiline = true;
            this.txbox_body.Name = "txbox_body";
            this.txbox_body.Size = new System.Drawing.Size(715, 236);
            this.txbox_body.TabIndex = 0;
            // 
            // txbox_to
            // 
            this.txbox_to.Location = new System.Drawing.Point(72, 39);
            this.txbox_to.Name = "txbox_to";
            this.txbox_to.Size = new System.Drawing.Size(715, 20);
            this.txbox_to.TabIndex = 0;
            this.txbox_to.Text = "/topics/global";
            // 
            // txbox_title
            // 
            this.txbox_title.Location = new System.Drawing.Point(72, 13);
            this.txbox_title.Name = "txbox_title";
            this.txbox_title.Size = new System.Drawing.Size(715, 20);
            this.txbox_title.TabIndex = 0;
            // 
            // tab_Data
            // 
            this.tab_Data.Controls.Add(this.richbox_data);
            this.tab_Data.Controls.Add(this.label7);
            this.tab_Data.Location = new System.Drawing.Point(4, 22);
            this.tab_Data.Name = "tab_Data";
            this.tab_Data.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Data.Size = new System.Drawing.Size(793, 307);
            this.tab_Data.TabIndex = 1;
            this.tab_Data.Text = "Data";
            this.tab_Data.UseVisualStyleBackColor = true;
            // 
            // richbox_data
            // 
            this.richbox_data.Location = new System.Drawing.Point(6, 45);
            this.richbox_data.Name = "richbox_data";
            this.richbox_data.Size = new System.Drawing.Size(781, 256);
            this.richbox_data.TabIndex = 0;
            this.richbox_data.Text = resources.GetString("richbox_data.Text");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Choose fields as provided exam";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "detaile";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(723, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richbox_res);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(808, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 368);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // richbox_res
            // 
            this.richbox_res.Location = new System.Drawing.Point(9, 32);
            this.richbox_res.Name = "richbox_res";
            this.richbox_res.Size = new System.Drawing.Size(462, 307);
            this.richbox_res.TabIndex = 4;
            this.richbox_res.Text = "";
            // 
            // txbox_key
            // 
            this.txbox_key.Location = new System.Drawing.Point(77, 348);
            this.txbox_key.Name = "txbox_key";
            this.txbox_key.Size = new System.Drawing.Size(640, 20);
            this.txbox_key.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "FCM KEY=";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(5, 408);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(797, 290);
            this.listBox1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "History";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 716);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbox_key);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tab_SimpleNotif.ResumeLayout(false);
            this.tab_SimpleNotif.PerformLayout();
            this.tab_Data.ResumeLayout(false);
            this.tab_Data.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_SimpleNotif;
        private System.Windows.Forms.TabPage tab_Data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richbox_res;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbox_body;
        private System.Windows.Forms.TextBox txbox_to;
        private System.Windows.Forms.TextBox txbox_title;
        private System.Windows.Forms.TextBox txbox_key;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox richbox_data;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

