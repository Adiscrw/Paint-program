namespace hodina_21._3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pencil = new Button();
            rubber = new Button();
            button3 = new Button();
            panel1 = new Panel();
            colorDialog1 = new ColorDialog();
            numericUpDown1 = new NumericUpDown();
            tableLayoutPanel1 = new TableLayoutPanel();
            circle = new Button();
            rectangle = new Button();
            ellipse = new Button();
            sprayButton = new Button();
            highliter = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pencil
            // 
            pencil.Image = (Image)resources.GetObject("pencil.Image");
            pencil.Location = new Point(29, 12);
            pencil.Name = "pencil";
            pencil.Size = new Size(66, 56);
            pencil.TabIndex = 1;
            pencil.UseVisualStyleBackColor = true;
            pencil.Click += button1_Click;
            // 
            // rubber
            // 
            rubber.Image = Properties.Resources.eraser;
            rubber.Location = new Point(101, 12);
            rubber.Name = "rubber";
            rubber.Size = new Size(89, 56);
            rubber.TabIndex = 2;
            rubber.UseVisualStyleBackColor = true;
            rubber.Click += button2_Click;
            // 
            // button3
            // 
            button3.Image = Properties.Resources.color_circle;
            button3.Location = new Point(3, 46);
            button3.Name = "button3";
            button3.Size = new Size(142, 37);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(29, 125);
            panel1.Name = "panel1";
            panel1.Size = new Size(2000, 2000);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(196, 23);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(108, 35);
            numericUpDown1.TabIndex = 6;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 158F));
            tableLayoutPanel1.Controls.Add(circle, 0, 0);
            tableLayoutPanel1.Controls.Add(rectangle, 1, 0);
            tableLayoutPanel1.Controls.Add(ellipse, 2, 0);
            tableLayoutPanel1.Controls.Add(button3, 0, 1);
            tableLayoutPanel1.Controls.Add(sprayButton, 2, 1);
            tableLayoutPanel1.Controls.Add(highliter, 1, 1);
            tableLayoutPanel1.Location = new Point(495, 6);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(454, 86);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // circle
            // 
            circle.Image = Properties.Resources.dry_clean;
            circle.Location = new Point(3, 3);
            circle.Name = "circle";
            circle.Size = new Size(142, 37);
            circle.TabIndex = 0;
            circle.UseVisualStyleBackColor = true;
            circle.Click += circle_Click;
            // 
            // rectangle
            // 
            rectangle.Image = Properties.Resources.square;
            rectangle.Location = new Point(151, 3);
            rectangle.Name = "rectangle";
            rectangle.Size = new Size(142, 37);
            rectangle.TabIndex = 1;
            rectangle.UseVisualStyleBackColor = true;
            rectangle.Click += rectangle_Click;
            // 
            // ellipse
            // 
            ellipse.Image = Properties.Resources.vector;
            ellipse.Location = new Point(299, 3);
            ellipse.Name = "ellipse";
            ellipse.Size = new Size(152, 37);
            ellipse.TabIndex = 2;
            ellipse.UseVisualStyleBackColor = true;
            ellipse.Click += ellipse_Click;
            // 
            // sprayButton
            // 
            sprayButton.Image = Properties.Resources.spray_gun;
            sprayButton.Location = new Point(299, 46);
            sprayButton.Name = "sprayButton";
            sprayButton.Size = new Size(152, 37);
            sprayButton.TabIndex = 5;
            sprayButton.UseVisualStyleBackColor = true;
            sprayButton.Click += sprayButton_Click;
            // 
            // highliter
            // 
            highliter.Image = Properties.Resources.highlighter;
            highliter.Location = new Point(151, 46);
            highliter.Name = "highliter";
            highliter.Size = new Size(142, 37);
            highliter.TabIndex = 3;
            highliter.UseVisualStyleBackColor = true;
            highliter.Click += highliter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1225, 670);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(numericUpDown1);
            Controls.Add(panel1);
            Controls.Add(rubber);
            Controls.Add(pencil);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button pencil;
        private Button rubber;
        private Button button3;
        private Panel panel1;
        private ColorDialog colorDialog1;
        private NumericUpDown numericUpDown1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button circle;
        private Button rectangle;
        private Button ellipse;
        private Button highliter;
        private Button sprayButton;
    }
}