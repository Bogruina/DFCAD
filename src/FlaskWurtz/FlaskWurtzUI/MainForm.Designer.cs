
namespace FlaskWurtzUI
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BuildButton = new System.Windows.Forms.Button();
            this.PromtButton = new System.Windows.Forms.Button();
            this.FlastDiameterTextBox = new System.Windows.Forms.TextBox();
            this.NeckLenghtTextBox = new System.Windows.Forms.TextBox();
            this.BendDiameterTextBox = new System.Windows.Forms.TextBox();
            this.BendLenghtTextBox = new System.Windows.Forms.TextBox();
            this.NeckDiameterTextBox = new System.Windows.Forms.TextBox();
            this.DependenciesLabel = new System.Windows.Forms.Label();
            this.ErrorsLabel = new System.Windows.Forms.Label();
            this.ParametersGroupbox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DependenciesButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DependenciesToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ParametersGroupbox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flask diameter (A)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "20 - 100 mm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "40 - 200 mm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Neck lenght (B)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "5 - 30 mm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Bend diameter (C)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(161, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "30 - 300 mm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Bend lenght (D)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(161, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "10 - 85 mm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "Neck diameter (E)";
            // 
            // BuildButton
            // 
            this.BuildButton.Enabled = false;
            this.BuildButton.FlatAppearance.BorderSize = 0;
            this.BuildButton.Location = new System.Drawing.Point(281, 290);
            this.BuildButton.Name = "BuildButton";
            this.BuildButton.Size = new System.Drawing.Size(75, 23);
            this.BuildButton.TabIndex = 15;
            this.BuildButton.Text = "Build";
            this.BuildButton.UseVisualStyleBackColor = true;
            this.BuildButton.Click += new System.EventHandler(this.BuildButton_Click);
            // 
            // PromtButton
            // 
            this.PromtButton.BackColor = System.Drawing.SystemColors.Control;
            this.PromtButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PromtButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.PromtButton.FlatAppearance.BorderSize = 0;
            this.PromtButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PromtButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PromtButton.Image = ((System.Drawing.Image)(resources.GetObject("PromtButton.Image")));
            this.PromtButton.Location = new System.Drawing.Point(12, 290);
            this.PromtButton.Name = "PromtButton";
            this.PromtButton.Size = new System.Drawing.Size(25, 25);
            this.PromtButton.TabIndex = 17;
            this.PromtButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.PromtButton.UseVisualStyleBackColor = false;
            this.PromtButton.Click += new System.EventHandler(this.PromtButton_Click);
            // 
            // FlastDiameterTextBox
            // 
            this.FlastDiameterTextBox.Location = new System.Drawing.Point(114, 16);
            this.FlastDiameterTextBox.Name = "FlastDiameterTextBox";
            this.FlastDiameterTextBox.Size = new System.Drawing.Size(41, 23);
            this.FlastDiameterTextBox.TabIndex = 18;
            this.FlastDiameterTextBox.Text = "45";
            this.FlastDiameterTextBox.Enter += new System.EventHandler(this.FlastDiameterTextBox_Enter);
            // 
            // NeckLenghtTextBox
            // 
            this.NeckLenghtTextBox.Location = new System.Drawing.Point(114, 45);
            this.NeckLenghtTextBox.Name = "NeckLenghtTextBox";
            this.NeckLenghtTextBox.Size = new System.Drawing.Size(41, 23);
            this.NeckLenghtTextBox.TabIndex = 19;
            this.NeckLenghtTextBox.Text = "40";
            // 
            // BendDiameterTextBox
            // 
            this.BendDiameterTextBox.Location = new System.Drawing.Point(114, 74);
            this.BendDiameterTextBox.Name = "BendDiameterTextBox";
            this.BendDiameterTextBox.Size = new System.Drawing.Size(41, 23);
            this.BendDiameterTextBox.TabIndex = 20;
            this.BendDiameterTextBox.Text = "5";
            // 
            // BendLenghtTextBox
            // 
            this.BendLenghtTextBox.Location = new System.Drawing.Point(114, 103);
            this.BendLenghtTextBox.Name = "BendLenghtTextBox";
            this.BendLenghtTextBox.Size = new System.Drawing.Size(41, 23);
            this.BendLenghtTextBox.TabIndex = 21;
            this.BendLenghtTextBox.Text = "30";
            // 
            // NeckDiameterTextBox
            // 
            this.NeckDiameterTextBox.Location = new System.Drawing.Point(114, 132);
            this.NeckDiameterTextBox.Name = "NeckDiameterTextBox";
            this.NeckDiameterTextBox.Size = new System.Drawing.Size(41, 23);
            this.NeckDiameterTextBox.TabIndex = 22;
            this.NeckDiameterTextBox.Text = "10";
            // 
            // DependenciesLabel
            // 
            this.DependenciesLabel.AutoSize = true;
            this.DependenciesLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DependenciesLabel.Location = new System.Drawing.Point(6, 49);
            this.DependenciesLabel.Name = "DependenciesLabel";
            this.DependenciesLabel.Size = new System.Drawing.Size(0, 19);
            this.DependenciesLabel.TabIndex = 24;
            // 
            // ErrorsLabel
            // 
            this.ErrorsLabel.AutoSize = true;
            this.ErrorsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ErrorsLabel.Location = new System.Drawing.Point(6, 19);
            this.ErrorsLabel.MaximumSize = new System.Drawing.Size(500, 500);
            this.ErrorsLabel.Name = "ErrorsLabel";
            this.ErrorsLabel.Size = new System.Drawing.Size(0, 15);
            this.ErrorsLabel.TabIndex = 25;
            // 
            // ParametersGroupbox
            // 
            this.ParametersGroupbox.Controls.Add(this.label1);
            this.ParametersGroupbox.Controls.Add(this.label2);
            this.ParametersGroupbox.Controls.Add(this.label4);
            this.ParametersGroupbox.Controls.Add(this.label3);
            this.ParametersGroupbox.Controls.Add(this.NeckDiameterTextBox);
            this.ParametersGroupbox.Controls.Add(this.label6);
            this.ParametersGroupbox.Controls.Add(this.BendLenghtTextBox);
            this.ParametersGroupbox.Controls.Add(this.label5);
            this.ParametersGroupbox.Controls.Add(this.BendDiameterTextBox);
            this.ParametersGroupbox.Controls.Add(this.label8);
            this.ParametersGroupbox.Controls.Add(this.NeckLenghtTextBox);
            this.ParametersGroupbox.Controls.Add(this.label7);
            this.ParametersGroupbox.Controls.Add(this.FlastDiameterTextBox);
            this.ParametersGroupbox.Controls.Add(this.label10);
            this.ParametersGroupbox.Controls.Add(this.label9);
            this.ParametersGroupbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ParametersGroupbox.Location = new System.Drawing.Point(12, 12);
            this.ParametersGroupbox.Name = "ParametersGroupbox";
            this.ParametersGroupbox.Size = new System.Drawing.Size(241, 164);
            this.ParametersGroupbox.TabIndex = 27;
            this.ParametersGroupbox.TabStop = false;
            this.ParametersGroupbox.Text = "Parameters";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DependenciesButton);
            this.groupBox1.Controls.Add(this.DependenciesLabel);
            this.groupBox1.Location = new System.Drawing.Point(259, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(97, 164);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Dependencies";
            // 
            // DependenciesButton
            // 
            this.DependenciesButton.BackColor = System.Drawing.SystemColors.Control;
            this.DependenciesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DependenciesButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.DependenciesButton.FlatAppearance.BorderSize = 0;
            this.DependenciesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DependenciesButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DependenciesButton.Image = ((System.Drawing.Image)(resources.GetObject("DependenciesButton.Image")));
            this.DependenciesButton.Location = new System.Drawing.Point(67, 130);
            this.DependenciesButton.Name = "DependenciesButton";
            this.DependenciesButton.Size = new System.Drawing.Size(25, 25);
            this.DependenciesButton.TabIndex = 29;
            this.DependenciesButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.DependenciesButton.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ErrorsLabel);
            this.groupBox2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.groupBox2.Location = new System.Drawing.Point(12, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 102);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Errors";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // DependenciesToolTip
            // 
            this.DependenciesToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.DependenciesToolTip.ToolTipTitle = "Info:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(368, 320);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ParametersGroupbox);
            this.Controls.Add(this.PromtButton);
            this.Controls.Add(this.BuildButton);
            this.Name = "MainForm";
            this.Text = "Flask Wurtz";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ParametersGroupbox.ResumeLayout(false);
            this.ParametersGroupbox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BuildButton;
        private System.Windows.Forms.Button PromtButton;
        private System.Windows.Forms.TextBox FlastDiameterTextBox;
        private System.Windows.Forms.TextBox NeckLenghtTextBox;
        private System.Windows.Forms.TextBox BendDiameterTextBox;
        private System.Windows.Forms.TextBox BendLenghtTextBox;
        private System.Windows.Forms.TextBox NeckDiameterTextBox;
        private System.Windows.Forms.Label DependenciesLabel;
        private System.Windows.Forms.Label ErrorsLabel;
        private System.Windows.Forms.GroupBox ParametersGroupbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DependenciesButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolTip DependenciesToolTip;
    }
}