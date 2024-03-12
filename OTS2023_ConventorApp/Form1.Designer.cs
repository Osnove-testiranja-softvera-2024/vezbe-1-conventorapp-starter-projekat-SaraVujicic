namespace OTS2023_ConventorApp
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
            this.radioMass = new System.Windows.Forms.RadioButton();
            this.radiolength = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioMoney = new System.Windows.Forms.RadioButton();
            this.radioTime = new System.Windows.Forms.RadioButton();
            this.radioCustom = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioHours = new System.Windows.Forms.RadioButton();
            this.radioMinutes = new System.Windows.Forms.RadioButton();
            this.radioSeconds = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioSingle = new System.Windows.Forms.RadioButton();
            this.radioArray = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioMass
            // 
            this.radioMass.AutoSize = true;
            this.radioMass.Location = new System.Drawing.Point(9, 33);
            this.radioMass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioMass.Name = "radioMass";
            this.radioMass.Size = new System.Drawing.Size(61, 20);
            this.radioMass.TabIndex = 0;
            this.radioMass.TabStop = true;
            this.radioMass.Text = "Mass";
            this.radioMass.UseVisualStyleBackColor = true;
            this.radioMass.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // radiolength
            // 
            this.radiolength.AutoSize = true;
            this.radiolength.Location = new System.Drawing.Point(9, 72);
            this.radiolength.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radiolength.Name = "radiolength";
            this.radiolength.Size = new System.Drawing.Size(68, 20);
            this.radiolength.TabIndex = 1;
            this.radiolength.TabStop = true;
            this.radiolength.Text = "Length";
            this.radiolength.UseVisualStyleBackColor = true;
            this.radiolength.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 226);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 226);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 267);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(129, 267);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 5;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(129, 354);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(100, 28);
            this.btnConvert.TabIndex = 6;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioCustom);
            this.groupBox1.Controls.Add(this.radioTime);
            this.groupBox1.Controls.Add(this.radioMoney);
            this.groupBox1.Controls.Add(this.radioMass);
            this.groupBox1.Controls.Add(this.radiolength);
            this.groupBox1.Location = new System.Drawing.Point(29, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 140);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conventer Type";
            //this.groupBox1.Enter += new System.EventHandler(this.groupBox1);
            // 
            // radioMoney
            // 
            this.radioMoney.AutoSize = true;
            this.radioMoney.Location = new System.Drawing.Point(104, 33);
            this.radioMoney.Name = "radioMoney";
            this.radioMoney.Size = new System.Drawing.Size(69, 20);
            this.radioMoney.TabIndex = 2;
            this.radioMoney.TabStop = true;
            this.radioMoney.Text = "Money";
            this.radioMoney.UseVisualStyleBackColor = true;
            // 
            // radioTime
            // 
            this.radioTime.AutoSize = true;
            this.radioTime.Location = new System.Drawing.Point(104, 71);
            this.radioTime.Name = "radioTime";
            this.radioTime.Size = new System.Drawing.Size(59, 20);
            this.radioTime.TabIndex = 3;
            this.radioTime.TabStop = true;
            this.radioTime.Text = "Time";
            this.radioTime.UseVisualStyleBackColor = true;
            // 
            // radioCustom
            // 
            this.radioCustom.AutoSize = true;
            this.radioCustom.Location = new System.Drawing.Point(46, 114);
            this.radioCustom.Name = "radioCustom";
            this.radioCustom.Size = new System.Drawing.Size(117, 20);
            this.radioCustom.TabIndex = 4;
            this.radioCustom.TabStop = true;
            this.radioCustom.Text = "Custom money";
            this.radioCustom.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioSeconds);
            this.groupBox2.Controls.Add(this.radioMinutes);
            this.groupBox2.Controls.Add(this.radioHours);
            this.groupBox2.Location = new System.Drawing.Point(265, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 125);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Time output";
            // 
            // radioHours
            // 
            this.radioHours.AutoSize = true;
            this.radioHours.Location = new System.Drawing.Point(7, 24);
            this.radioHours.Name = "radioHours";
            this.radioHours.Size = new System.Drawing.Size(64, 20);
            this.radioHours.TabIndex = 0;
            this.radioHours.TabStop = true;
            this.radioHours.Text = "Hours";
            this.radioHours.UseVisualStyleBackColor = true;
            // 
            // radioMinutes
            // 
            this.radioMinutes.AutoSize = true;
            this.radioMinutes.Location = new System.Drawing.Point(7, 63);
            this.radioMinutes.Name = "radioMinutes";
            this.radioMinutes.Size = new System.Drawing.Size(74, 20);
            this.radioMinutes.TabIndex = 1;
            this.radioMinutes.TabStop = true;
            this.radioMinutes.Text = "Minutes";
            this.radioMinutes.UseVisualStyleBackColor = true;
           // this.radioMinutes.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioSeconds
            // 
            this.radioSeconds.AutoSize = true;
            this.radioSeconds.Location = new System.Drawing.Point(7, 99);
            this.radioSeconds.Name = "radioSeconds";
            this.radioSeconds.Size = new System.Drawing.Size(82, 20);
            this.radioSeconds.TabIndex = 2;
            this.radioSeconds.TabStop = true;
            this.radioSeconds.Text = "Seconds";
            this.radioSeconds.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioArray);
            this.groupBox3.Controls.Add(this.radioSingle);
            this.groupBox3.Location = new System.Drawing.Point(465, 51);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(119, 125);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Segment type";
            // 
            // radioSingle
            // 
            this.radioSingle.AutoSize = true;
            this.radioSingle.Location = new System.Drawing.Point(6, 33);
            this.radioSingle.Name = "radioSingle";
            this.radioSingle.Size = new System.Drawing.Size(102, 20);
            this.radioSingle.TabIndex = 0;
            this.radioSingle.TabStop = true;
            this.radioSingle.Text = "Single value";
            this.radioSingle.UseVisualStyleBackColor = true;
            // 
            // radioArray
            // 
            this.radioArray.AutoSize = true;
            this.radioArray.Location = new System.Drawing.Point(6, 74);
            this.radioArray.Name = "radioArray";
            this.radioArray.Size = new System.Drawing.Size(117, 20);
            this.radioArray.TabIndex = 1;
            this.radioArray.TabStop = true;
            this.radioArray.Text = "Array of values";
            this.radioArray.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 554);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
           // this.Load += new System.EventHandler(this.Form1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioMass;
        private System.Windows.Forms.RadioButton radiolength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioCustom;
        private System.Windows.Forms.RadioButton radioTime;
        private System.Windows.Forms.RadioButton radioMoney;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioSeconds;
        private System.Windows.Forms.RadioButton radioMinutes;
        private System.Windows.Forms.RadioButton radioHours;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioArray;
        private System.Windows.Forms.RadioButton radioSingle;
    }
}

