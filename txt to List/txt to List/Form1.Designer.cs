namespace txt_to_List
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
            this.B_Copy = new System.Windows.Forms.Button();
            this.B_ListConv = new System.Windows.Forms.Button();
            this.TB_results = new System.Windows.Forms.TextBox();
            this.L_Drop = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.n_value = new System.Windows.Forms.NumericUpDown();
            this.L_WordCount = new System.Windows.Forms.Label();
            this.L_warning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.n_value)).BeginInit();
            this.SuspendLayout();
            // 
            // B_Copy
            // 
            this.B_Copy.Enabled = false;
            this.B_Copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Copy.Location = new System.Drawing.Point(12, 175);
            this.B_Copy.Name = "B_Copy";
            this.B_Copy.Size = new System.Drawing.Size(237, 56);
            this.B_Copy.TabIndex = 1;
            this.B_Copy.Text = "Copy";
            this.B_Copy.UseVisualStyleBackColor = true;
            // 
            // B_ListConv
            // 
            this.B_ListConv.Enabled = false;
            this.B_ListConv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_ListConv.Location = new System.Drawing.Point(18, 398);
            this.B_ListConv.Name = "B_ListConv";
            this.B_ListConv.Size = new System.Drawing.Size(237, 56);
            this.B_ListConv.TabIndex = 2;
            this.B_ListConv.Text = "To C# List ";
            this.B_ListConv.UseVisualStyleBackColor = true;
            // 
            // TB_results
            // 
            this.TB_results.Location = new System.Drawing.Point(12, 237);
            this.TB_results.Multiline = true;
            this.TB_results.Name = "TB_results";
            this.TB_results.ReadOnly = true;
            this.TB_results.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TB_results.Size = new System.Drawing.Size(237, 142);
            this.TB_results.TabIndex = 3;
            // 
            // L_Drop
            // 
            this.L_Drop.AllowDrop = true;
            this.L_Drop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.L_Drop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Drop.Location = new System.Drawing.Point(12, 9);
            this.L_Drop.Name = "L_Drop";
            this.L_Drop.Size = new System.Drawing.Size(237, 135);
            this.L_Drop.TabIndex = 4;
            this.L_Drop.Text = "Drag and Drop Here!  One Only!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "How many chars in word?";
            // 
            // n_value
            // 
            this.n_value.Location = new System.Drawing.Point(174, 147);
            this.n_value.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n_value.Name = "n_value";
            this.n_value.Size = new System.Drawing.Size(75, 22);
            this.n_value.TabIndex = 7;
            this.n_value.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // L_WordCount
            // 
            this.L_WordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_WordCount.Location = new System.Drawing.Point(15, 382);
            this.L_WordCount.Name = "L_WordCount";
            this.L_WordCount.Size = new System.Drawing.Size(234, 22);
            this.L_WordCount.TabIndex = 8;
            this.L_WordCount.Text = "Word count is : 0";
            // 
            // L_warning
            // 
            this.L_warning.AutoSize = true;
            this.L_warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_warning.ForeColor = System.Drawing.Color.Red;
            this.L_warning.Location = new System.Drawing.Point(12, 457);
            this.L_warning.Name = "L_warning";
            this.L_warning.Size = new System.Drawing.Size(238, 18);
            this.L_warning.TabIndex = 9;
            this.L_warning.Text = "File is not a txt file! Please try again!";
            this.L_warning.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 484);
            this.Controls.Add(this.L_warning);
            this.Controls.Add(this.L_WordCount);
            this.Controls.Add(this.n_value);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.L_Drop);
            this.Controls.Add(this.TB_results);
            this.Controls.Add(this.B_ListConv);
            this.Controls.Add(this.B_Copy);
            this.Name = "Form1";
            this.Text = "Txt to list";
            ((System.ComponentModel.ISupportInitialize)(this.n_value)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button B_Copy;
        private System.Windows.Forms.Button B_ListConv;
        private System.Windows.Forms.TextBox TB_results;
        private System.Windows.Forms.Label L_Drop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown n_value;
        private System.Windows.Forms.Label L_WordCount;
        private System.Windows.Forms.Label L_warning;
    }
}

