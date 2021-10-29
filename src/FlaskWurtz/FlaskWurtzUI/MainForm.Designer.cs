
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.FlastDiameterTextBox = new System.Windows.Forms.TextBox();
            this.NeckLenghtTextBox = new System.Windows.Forms.TextBox();
            this.BendDiameterTextBox = new System.Windows.Forms.TextBox();
            this.BendLenghtTextBox = new System.Windows.Forms.TextBox();
            this.NeckDiameterTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DependenciesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flask diameter (A)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "20 - 100 mm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "40 - 200 mm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Neck lenght (B)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "5 - 30 mm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Bend diameter (C)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(168, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "30 - 300 mm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Bend lenght (D)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(168, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "10 - 85 mm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "Neck diameter (E)";
            // 
            // BuildButton
            // 
            this.BuildButton.Enabled = false;
            this.BuildButton.FlatAppearance.BorderSize = 0;
            this.BuildButton.Location = new System.Drawing.Point(12, 160);
            this.BuildButton.Name = "BuildButton";
            this.BuildButton.Size = new System.Drawing.Size(75, 23);
            this.BuildButton.TabIndex = 15;
            this.BuildButton.Text = "Build";
            this.BuildButton.UseVisualStyleBackColor = true;
            this.BuildButton.TextChanged += new System.EventHandler(this.NeckLenghtTextBox_TextChanged);
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
            this.PromtButton.Location = new System.Drawing.Point(207, 160);
            this.PromtButton.Name = "PromtButton";
            this.PromtButton.Size = new System.Drawing.Size(25, 25);
            this.PromtButton.TabIndex = 17;
            this.PromtButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.PromtButton.UseVisualStyleBackColor = false;
            this.PromtButton.Click += new System.EventHandler(this.PromtButton_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.toolTip1_Draw);
            // 
            // FlastDiameterTextBox
            // 
            this.FlastDiameterTextBox.Location = new System.Drawing.Point(121, 11);
            this.FlastDiameterTextBox.Name = "FlastDiameterTextBox";
            this.FlastDiameterTextBox.Size = new System.Drawing.Size(41, 23);
            this.FlastDiameterTextBox.TabIndex = 18;
            this.toolTip1.SetToolTip(this.FlastDiameterTextBox, "Dependence A ≥ 2*E ");
            this.FlastDiameterTextBox.TextChanged += new System.EventHandler(this.FlastDiameterTextBox_TextChanged);
            this.FlastDiameterTextBox.Enter += new System.EventHandler(this.FlastDiameterTextBox_Enter);
            // 
            // NeckLenghtTextBox
            // 
            this.NeckLenghtTextBox.Location = new System.Drawing.Point(121, 40);
            this.NeckLenghtTextBox.Name = "NeckLenghtTextBox";
            this.NeckLenghtTextBox.Size = new System.Drawing.Size(41, 23);
            this.NeckLenghtTextBox.TabIndex = 19;
            this.NeckLenghtTextBox.TextChanged += new System.EventHandler(this.NeckLenghtTextBox_TextChanged);
            this.NeckLenghtTextBox.Enter += new System.EventHandler(this.NeckLenghtTextBox_Enter);
            // 
            // BendDiameterTextBox
            // 
            this.BendDiameterTextBox.Location = new System.Drawing.Point(121, 69);
            this.BendDiameterTextBox.Name = "BendDiameterTextBox";
            this.BendDiameterTextBox.Size = new System.Drawing.Size(41, 23);
            this.BendDiameterTextBox.TabIndex = 20;
            this.BendDiameterTextBox.TextChanged += new System.EventHandler(this.BendDiameterTextBox_TextChanged);
            this.BendDiameterTextBox.Enter += new System.EventHandler(this.BendDiameterTextBox_Enter);
            // 
            // BendLenghtTextBox
            // 
            this.BendLenghtTextBox.Location = new System.Drawing.Point(121, 98);
            this.BendLenghtTextBox.Name = "BendLenghtTextBox";
            this.BendLenghtTextBox.Size = new System.Drawing.Size(41, 23);
            this.BendLenghtTextBox.TabIndex = 21;
            this.BendLenghtTextBox.TextChanged += new System.EventHandler(this.BendLenghtTextBox_TextChanged);
            this.BendLenghtTextBox.Enter += new System.EventHandler(this.BendLenghtTextBox_Enter);
            // 
            // NeckDiameterTextBox
            // 
            this.NeckDiameterTextBox.Location = new System.Drawing.Point(121, 127);
            this.NeckDiameterTextBox.Name = "NeckDiameterTextBox";
            this.NeckDiameterTextBox.Size = new System.Drawing.Size(41, 23);
            this.NeckDiameterTextBox.TabIndex = 22;
            this.NeckDiameterTextBox.TextChanged += new System.EventHandler(this.NeckDiameterTextBox_TextChanged);
            this.NeckDiameterTextBox.Enter += new System.EventHandler(this.NeckDiameterTextBox_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 15);
            this.label11.TabIndex = 23;
            this.label11.Text = "Dependencies:";
            // 
            // DependenciesLabel
            // 
            this.DependenciesLabel.AutoSize = true;
            this.DependenciesLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DependenciesLabel.Location = new System.Drawing.Point(116, 184);
            this.DependenciesLabel.Name = "DependenciesLabel";
            this.DependenciesLabel.Size = new System.Drawing.Size(0, 19);
            this.DependenciesLabel.TabIndex = 24;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 237);
            this.Controls.Add(this.DependenciesLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.NeckDiameterTextBox);
            this.Controls.Add(this.BendLenghtTextBox);
            this.Controls.Add(this.BendDiameterTextBox);
            this.Controls.Add(this.NeckLenghtTextBox);
            this.Controls.Add(this.FlastDiameterTextBox);
            this.Controls.Add(this.PromtButton);
            this.Controls.Add(this.BuildButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Flask Wurtz";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Click += new System.EventHandler(this.MainForm_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox FlastDiameterTextBox;
        private System.Windows.Forms.TextBox NeckLenghtTextBox;
        private System.Windows.Forms.TextBox BendDiameterTextBox;
        private System.Windows.Forms.TextBox BendLenghtTextBox;
        private System.Windows.Forms.TextBox NeckDiameterTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label DependenciesLabel;
    }
}