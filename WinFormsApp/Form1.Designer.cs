namespace WinFormsApp
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
            components = new System.ComponentModel.Container();
            runBtn = new Button();
            numberOfItems = new TextBox();
            seed = new TextBox();
            capacity = new TextBox();
            numberOfItems_text = new Label();
            seed_text = new Label();
            capacity_text = new Label();
            result_text = new Label();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // runBtn
            // 
            runBtn.Location = new Point(75, 235);
            runBtn.Name = "runBtn";
            runBtn.Size = new Size(125, 29);
            runBtn.TabIndex = 0;
            runBtn.Text = "run";
            runBtn.UseVisualStyleBackColor = true;
            runBtn.Click += button1_Click;
            // 
            // numberOfItems
            // 
            numberOfItems.Location = new Point(75, 78);
            numberOfItems.Name = "numberOfItems";
            numberOfItems.Size = new Size(125, 27);
            numberOfItems.TabIndex = 1;
            numberOfItems.TextAlign = HorizontalAlignment.Right;
            numberOfItems.TextChanged += numberOfItems_TextChanged;
            numberOfItems.Validating += numberOfItems_Validating;
            // 
            // seed
            // 
            seed.Location = new Point(75, 134);
            seed.Name = "seed";
            seed.Size = new Size(125, 27);
            seed.TabIndex = 2;
            seed.TextAlign = HorizontalAlignment.Right;
            seed.Validating += seed_Validating;
            // 
            // capacity
            // 
            capacity.Location = new Point(75, 187);
            capacity.Name = "capacity";
            capacity.Size = new Size(125, 27);
            capacity.TabIndex = 3;
            capacity.TextAlign = HorizontalAlignment.Right;
            capacity.Validating += capacity_Validating;
            // 
            // numberOfItems_text
            // 
            numberOfItems_text.AutoSize = true;
            numberOfItems_text.Location = new Point(75, 55);
            numberOfItems_text.Name = "numberOfItems_text";
            numberOfItems_text.Size = new Size(125, 20);
            numberOfItems_text.TabIndex = 7;
            numberOfItems_text.Text = "number od items:";
            // 
            // seed_text
            // 
            seed_text.AutoSize = true;
            seed_text.Location = new Point(75, 111);
            seed_text.Name = "seed_text";
            seed_text.Size = new Size(43, 20);
            seed_text.TabIndex = 8;
            seed_text.Text = "seed:";
            // 
            // capacity_text
            // 
            capacity_text.AutoSize = true;
            capacity_text.Location = new Point(75, 164);
            capacity_text.Name = "capacity_text";
            capacity_text.Size = new Size(67, 20);
            capacity_text.TabIndex = 9;
            capacity_text.Text = "capacity:";
            // 
            // result_text
            // 
            result_text.AutoSize = true;
            result_text.Location = new Point(299, 81);
            result_text.Name = "result_text";
            result_text.Size = new Size(52, 20);
            result_text.TabIndex = 10;
            result_text.Text = "Wynik:";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(result_text);
            Controls.Add(capacity_text);
            Controls.Add(seed_text);
            Controls.Add(numberOfItems_text);
            Controls.Add(capacity);
            Controls.Add(seed);
            Controls.Add(numberOfItems);
            Controls.Add(runBtn);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button runBtn;
        private TextBox numberOfItems;
        private TextBox seed;
        private TextBox capacity;
        private Label numberOfItems_text;
        private Label seed_text;
        private Label capacity_text;
        private Label result_text;
        private ErrorProvider errorProvider;
    }
}