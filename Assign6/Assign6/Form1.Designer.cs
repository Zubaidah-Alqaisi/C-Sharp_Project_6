namespace Assign6
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ComputeN = new System.Windows.Forms.Button();
            this.ComputeInterest = new System.Windows.Forms.Button();
            this.ComputePresentValue = new System.Windows.Forms.Button();
            this.ComputePayment = new System.Windows.Forms.Button();
            this.ComputeFutureValue = new System.Windows.Forms.Button();
            this.NTextBox = new System.Windows.Forms.TextBox();
            this.IyTextBox = new System.Windows.Forms.TextBox();
            this.PvTextBox = new System.Windows.Forms.TextBox();
            this.PmtTextBox = new System.Windows.Forms.TextBox();
            this.FvTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Periods:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(254, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rate:  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "PV:    $";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "PMT:  $";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "FV:  $";
            // 
            // ComputeN
            // 
            this.ComputeN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputeN.Location = new System.Drawing.Point(437, 452);
            this.ComputeN.Name = "ComputeN";
            this.ComputeN.Size = new System.Drawing.Size(80, 31);
            this.ComputeN.TabIndex = 5;
            this.ComputeN.Text = "Periods";
            this.ComputeN.UseVisualStyleBackColor = true;
            this.ComputeN.Click += new System.EventHandler(this.ComputeN_Click);
            // 
            // ComputeInterest
            // 
            this.ComputeInterest.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputeInterest.Location = new System.Drawing.Point(338, 452);
            this.ComputeInterest.Name = "ComputeInterest";
            this.ComputeInterest.Size = new System.Drawing.Size(80, 31);
            this.ComputeInterest.TabIndex = 6;
            this.ComputeInterest.Text = "Rate";
            this.ComputeInterest.UseVisualStyleBackColor = true;
            this.ComputeInterest.Click += new System.EventHandler(this.ComputeInterest_Click);
            // 
            // ComputePresentValue
            // 
            this.ComputePresentValue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputePresentValue.Location = new System.Drawing.Point(40, 452);
            this.ComputePresentValue.Name = "ComputePresentValue";
            this.ComputePresentValue.Size = new System.Drawing.Size(83, 31);
            this.ComputePresentValue.TabIndex = 7;
            this.ComputePresentValue.Text = "PV";
            this.ComputePresentValue.UseVisualStyleBackColor = true;
            this.ComputePresentValue.Click += new System.EventHandler(this.ComputePresentValue_Click);
            // 
            // ComputePayment
            // 
            this.ComputePayment.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputePayment.Location = new System.Drawing.Point(139, 452);
            this.ComputePayment.Name = "ComputePayment";
            this.ComputePayment.Size = new System.Drawing.Size(81, 31);
            this.ComputePayment.TabIndex = 8;
            this.ComputePayment.Text = "PMT";
            this.ComputePayment.UseVisualStyleBackColor = true;
            this.ComputePayment.Click += new System.EventHandler(this.ComputePayment_Click);
            // 
            // ComputeFutureValue
            // 
            this.ComputeFutureValue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputeFutureValue.Location = new System.Drawing.Point(234, 452);
            this.ComputeFutureValue.Name = "ComputeFutureValue";
            this.ComputeFutureValue.Size = new System.Drawing.Size(78, 31);
            this.ComputeFutureValue.TabIndex = 9;
            this.ComputeFutureValue.Text = "FV";
            this.ComputeFutureValue.UseVisualStyleBackColor = true;
            this.ComputeFutureValue.Click += new System.EventHandler(this.ComputeFutureValue_Click);
            // 
            // NTextBox
            // 
            this.NTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NTextBox.Location = new System.Drawing.Point(318, 306);
            this.NTextBox.Name = "NTextBox";
            this.NTextBox.Size = new System.Drawing.Size(100, 26);
            this.NTextBox.TabIndex = 10;
            // 
            // IyTextBox
            // 
            this.IyTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IyTextBox.Location = new System.Drawing.Point(318, 243);
            this.IyTextBox.Name = "IyTextBox";
            this.IyTextBox.Size = new System.Drawing.Size(100, 26);
            this.IyTextBox.TabIndex = 11;
            // 
            // PvTextBox
            // 
            this.PvTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PvTextBox.Location = new System.Drawing.Point(90, 239);
            this.PvTextBox.Name = "PvTextBox";
            this.PvTextBox.Size = new System.Drawing.Size(100, 26);
            this.PvTextBox.TabIndex = 12;
            // 
            // PmtTextBox
            // 
            this.PmtTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PmtTextBox.Location = new System.Drawing.Point(90, 309);
            this.PmtTextBox.Name = "PmtTextBox";
            this.PmtTextBox.Size = new System.Drawing.Size(100, 26);
            this.PmtTextBox.TabIndex = 13;
            // 
            // FvTextBox
            // 
            this.FvTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FvTextBox.Location = new System.Drawing.Point(90, 376);
            this.FvTextBox.Name = "FvTextBox";
            this.FvTextBox.Size = new System.Drawing.Size(164, 26);
            this.FvTextBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(166, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "Financial Calculator ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(424, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "%";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(428, 517);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 17;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Output
            // 
            this.Output.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.FormattingEnabled = true;
            this.Output.ItemHeight = 19;
            this.Output.Location = new System.Drawing.Point(28, 35);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(478, 175);
            this.Output.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 582);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FvTextBox);
            this.Controls.Add(this.PmtTextBox);
            this.Controls.Add(this.PvTextBox);
            this.Controls.Add(this.IyTextBox);
            this.Controls.Add(this.NTextBox);
            this.Controls.Add(this.ComputeFutureValue);
            this.Controls.Add(this.ComputePayment);
            this.Controls.Add(this.ComputePresentValue);
            this.Controls.Add(this.ComputeInterest);
            this.Controls.Add(this.ComputeN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ComputeN;
        private System.Windows.Forms.Button ComputeInterest;
        private System.Windows.Forms.Button ComputePresentValue;
        private System.Windows.Forms.Button ComputePayment;
        private System.Windows.Forms.Button ComputeFutureValue;
        private System.Windows.Forms.TextBox NTextBox;
        private System.Windows.Forms.TextBox IyTextBox;
        private System.Windows.Forms.TextBox PvTextBox;
        private System.Windows.Forms.TextBox PmtTextBox;
        private System.Windows.Forms.TextBox FvTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox Output;
    }
}

