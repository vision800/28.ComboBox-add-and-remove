namespace _28.ComboBox_add_and_remove
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
            label1 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            label2 = new Label();
            txtItem = new TextBox();
            button2 = new Button();
            rdRemove = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(173, 122);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 0;
            label1.Text = "Proffession : ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(308, 119);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(448, 228);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(173, 65);
            label2.Name = "label2";
            label2.Size = new Size(48, 25);
            label2.TabIndex = 3;
            label2.Text = "Item";
            // 
            // txtItem
            // 
            txtItem.Location = new Point(308, 65);
            txtItem.Name = "txtItem";
            txtItem.Size = new Size(150, 31);
            txtItem.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(305, 228);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 5;
            button2.Text = "Add Item";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // rdRemove
            // 
            rdRemove.AutoSize = true;
            rdRemove.Location = new Point(357, 176);
            rdRemove.Name = "rdRemove";
            rdRemove.Size = new Size(101, 29);
            rdRemove.TabIndex = 6;
            rdRemove.TabStop = true;
            rdRemove.Text = "Remove";
            rdRemove.UseVisualStyleBackColor = true;
           // rdRemove.CheckedChanged += rdRemove_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rdRemove);
            Controls.Add(button2);
            Controls.Add(txtItem);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Button button1;
        private Label label2;
        private TextBox txtItem;
        private Button button2;
        private RadioButton rdRemove;
    }
}