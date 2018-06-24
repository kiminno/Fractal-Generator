namespace Fractal_Summative
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
            this.components = new System.ComponentModel.Container();
            this.newtonFractalPictureBox = new System.Windows.Forms.PictureBox();
            this.displayNewtonButton = new System.Windows.Forms.Button();
            this.maxIterationsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.animateNewtonTimer = new System.Windows.Forms.Timer(this.components);
            this.animateNewtonButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.complexCoordLabel = new System.Windows.Forms.Label();
            this.juliaFractalPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.newtonFractalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxIterationsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.juliaFractalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // newtonFractalPictureBox
            // 
            this.newtonFractalPictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.newtonFractalPictureBox.Location = new System.Drawing.Point(0, 0);
            this.newtonFractalPictureBox.Name = "newtonFractalPictureBox";
            this.newtonFractalPictureBox.Size = new System.Drawing.Size(400, 400);
            this.newtonFractalPictureBox.TabIndex = 0;
            this.newtonFractalPictureBox.TabStop = false;
            this.newtonFractalPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.fractalPictureBox_Paint);
            this.newtonFractalPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.newtonFractalPictureBox_MouseClick);
            this.newtonFractalPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.fractalPictureBox_MouseMove);
            // 
            // displayNewtonButton
            // 
            this.displayNewtonButton.Location = new System.Drawing.Point(12, 406);
            this.displayNewtonButton.Name = "displayNewtonButton";
            this.displayNewtonButton.Size = new System.Drawing.Size(97, 34);
            this.displayNewtonButton.TabIndex = 1;
            this.displayNewtonButton.Text = "Display Fractal";
            this.displayNewtonButton.UseVisualStyleBackColor = true;
            this.displayNewtonButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // maxIterationsNumericUpDown
            // 
            this.maxIterationsNumericUpDown.Location = new System.Drawing.Point(170, 415);
            this.maxIterationsNumericUpDown.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.maxIterationsNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxIterationsNumericUpDown.Name = "maxIterationsNumericUpDown";
            this.maxIterationsNumericUpDown.Size = new System.Drawing.Size(45, 20);
            this.maxIterationsNumericUpDown.TabIndex = 2;
            this.maxIterationsNumericUpDown.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Iterations:";
            // 
            // animateNewtonTimer
            // 
            this.animateNewtonTimer.Tick += new System.EventHandler(this.animateTimer_Tick);
            // 
            // animateNewtonButton
            // 
            this.animateNewtonButton.Location = new System.Drawing.Point(226, 413);
            this.animateNewtonButton.Name = "animateNewtonButton";
            this.animateNewtonButton.Size = new System.Drawing.Size(75, 23);
            this.animateNewtonButton.TabIndex = 4;
            this.animateNewtonButton.Text = "Animate";
            this.animateNewtonButton.UseVisualStyleBackColor = true;
            this.animateNewtonButton.Click += new System.EventHandler(this.animateButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Complex Coord:";
            // 
            // complexCoordLabel
            // 
            this.complexCoordLabel.AutoSize = true;
            this.complexCoordLabel.Location = new System.Drawing.Point(314, 423);
            this.complexCoordLabel.Name = "complexCoordLabel";
            this.complexCoordLabel.Size = new System.Drawing.Size(0, 13);
            this.complexCoordLabel.TabIndex = 6;
            // 
            // juliaFractalPictureBox
            // 
            this.juliaFractalPictureBox.Location = new System.Drawing.Point(418, 0);
            this.juliaFractalPictureBox.Name = "juliaFractalPictureBox";
            this.juliaFractalPictureBox.Size = new System.Drawing.Size(300, 300);
            this.juliaFractalPictureBox.TabIndex = 7;
            this.juliaFractalPictureBox.TabStop = false;
            this.juliaFractalPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.juliaFractalPictureBox_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 448);
            this.Controls.Add(this.juliaFractalPictureBox);
            this.Controls.Add(this.complexCoordLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.animateNewtonButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxIterationsNumericUpDown);
            this.Controls.Add(this.displayNewtonButton);
            this.Controls.Add(this.newtonFractalPictureBox);
            this.Name = "Form1";
            this.Text = "Newton Fractal & Modified Julia Set (Nancy Ngo)";
            ((System.ComponentModel.ISupportInitialize)(this.newtonFractalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxIterationsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.juliaFractalPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox newtonFractalPictureBox;
        private System.Windows.Forms.Button displayNewtonButton;
        private System.Windows.Forms.NumericUpDown maxIterationsNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer animateNewtonTimer;
        private System.Windows.Forms.Button animateNewtonButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label complexCoordLabel;
        private System.Windows.Forms.PictureBox juliaFractalPictureBox;
    }
}

