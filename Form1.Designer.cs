namespace task3_b
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
            this.txt_Stud_id = new System.Windows.Forms.TextBox();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.txt_stud_name = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_status = new System.Windows.Forms.Button();
            this.btn_stud_display = new System.Windows.Forms.Button();
            this.btn_status_update = new System.Windows.Forms.Button();
            this.btn_show_all = new System.Windows.Forms.Button();
            this.showBox = new System.Windows.Forms.ListBox();
            this.btn_by_status = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Stud_id
            // 
            this.txt_Stud_id.Location = new System.Drawing.Point(30, 82);
            this.txt_Stud_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Stud_id.Name = "txt_Stud_id";
            this.txt_Stud_id.Size = new System.Drawing.Size(153, 28);
            this.txt_Stud_id.TabIndex = 0;
            // 
            // txt_status
            // 
            this.txt_status.Location = new System.Drawing.Point(448, 82);
            this.txt_status.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(153, 28);
            this.txt_status.TabIndex = 1;
            // 
            // txt_stud_name
            // 
            this.txt_stud_name.Location = new System.Drawing.Point(241, 82);
            this.txt_stud_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_stud_name.Name = "txt_stud_name";
            this.txt_stud_name.Size = new System.Drawing.Size(153, 28);
            this.txt_stud_name.TabIndex = 2;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_add.Location = new System.Drawing.Point(671, 63);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(123, 65);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_remove.Location = new System.Drawing.Point(821, 63);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(123, 65);
            this.btn_remove.TabIndex = 4;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Student Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(237, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter Student Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(444, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter Enrolment Status";
            // 
            // btn_status
            // 
            this.btn_status.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_status.Location = new System.Drawing.Point(60, 211);
            this.btn_status.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_status.Name = "btn_status";
            this.btn_status.Size = new System.Drawing.Size(123, 65);
            this.btn_status.TabIndex = 8;
            this.btn_status.Text = "View Status";
            this.btn_status.UseVisualStyleBackColor = false;
            this.btn_status.Click += new System.EventHandler(this.btn_status_Click);
            // 
            // btn_stud_display
            // 
            this.btn_stud_display.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_stud_display.Location = new System.Drawing.Point(241, 211);
            this.btn_stud_display.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_stud_display.Name = "btn_stud_display";
            this.btn_stud_display.Size = new System.Drawing.Size(123, 65);
            this.btn_stud_display.TabIndex = 9;
            this.btn_stud_display.Text = "Display Student";
            this.btn_stud_display.UseVisualStyleBackColor = false;
            this.btn_stud_display.Click += new System.EventHandler(this.btn_stud_display_Click);
            // 
            // btn_status_update
            // 
            this.btn_status_update.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_status_update.Location = new System.Drawing.Point(431, 211);
            this.btn_status_update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_status_update.Name = "btn_status_update";
            this.btn_status_update.Size = new System.Drawing.Size(123, 65);
            this.btn_status_update.TabIndex = 10;
            this.btn_status_update.Text = "Update Status";
            this.btn_status_update.UseVisualStyleBackColor = false;
            this.btn_status_update.Click += new System.EventHandler(this.btn_status_update_Click);
            // 
            // btn_show_all
            // 
            this.btn_show_all.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_show_all.Location = new System.Drawing.Point(800, 211);
            this.btn_show_all.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_show_all.Name = "btn_show_all";
            this.btn_show_all.Size = new System.Drawing.Size(123, 65);
            this.btn_show_all.TabIndex = 11;
            this.btn_show_all.Text = "Show All";
            this.btn_show_all.UseVisualStyleBackColor = false;
            this.btn_show_all.Click += new System.EventHandler(this.btn_show_all_Click);
            // 
            // showBox
            // 
            this.showBox.FormattingEnabled = true;
            this.showBox.ItemHeight = 21;
            this.showBox.Location = new System.Drawing.Point(128, 317);
            this.showBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.showBox.Name = "showBox";
            this.showBox.Size = new System.Drawing.Size(702, 256);
            this.showBox.TabIndex = 12;
            // 
            // btn_by_status
            // 
            this.btn_by_status.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_by_status.Location = new System.Drawing.Point(619, 211);
            this.btn_by_status.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_by_status.Name = "btn_by_status";
            this.btn_by_status.Size = new System.Drawing.Size(123, 65);
            this.btn_by_status.TabIndex = 13;
            this.btn_by_status.Text = "Show By Status";
            this.btn_by_status.UseVisualStyleBackColor = false;
            this.btn_by_status.Click += new System.EventHandler(this.btn_by_status_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1000, 590);
            this.Controls.Add(this.btn_by_status);
            this.Controls.Add(this.showBox);
            this.Controls.Add(this.btn_show_all);
            this.Controls.Add(this.btn_status_update);
            this.Controls.Add(this.btn_stud_display);
            this.Controls.Add(this.btn_status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_stud_name);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.txt_Stud_id);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Stud_id;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.TextBox txt_stud_name;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_status;
        private System.Windows.Forms.Button btn_stud_display;
        private System.Windows.Forms.Button btn_status_update;
        private System.Windows.Forms.Button btn_show_all;
        private System.Windows.Forms.ListBox showBox;
        private System.Windows.Forms.Button btn_by_status;
    }
}

