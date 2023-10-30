namespace CS311_Project2_RLV
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
            lblDice1 = new Label();
            lblDice2 = new Label();
            lblBalance = new Label();
            txtPlaceBets = new TextBox();
            btnRollDice = new Button();
            lblOutcome = new Label();
            SuspendLayout();
            // 
            // lblDice1
            // 
            lblDice1.AutoSize = true;
            lblDice1.Font = new Font("Franklin Gothic Book", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            lblDice1.Location = new Point(71, 57);
            lblDice1.Name = "lblDice1";
            lblDice1.Size = new Size(111, 38);
            lblDice1.TabIndex = 0;
            lblDice1.Text = "Dice 1";
            lblDice1.Click += lblDice1_Click;
            // 
            // lblDice2
            // 
            lblDice2.AutoSize = true;
            lblDice2.Font = new Font("Franklin Gothic Book", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            lblDice2.Location = new Point(71, 123);
            lblDice2.Name = "lblDice2";
            lblDice2.Size = new Size(111, 38);
            lblDice2.TabIndex = 1;
            lblDice2.Text = "Dice 2";
            lblDice2.Click += lblDice2_Click;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Franklin Gothic Book", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            lblBalance.Location = new Point(603, 57);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(97, 38);
            lblBalance.TabIndex = 2;
            lblBalance.Text = "$100";
            lblBalance.Click += lblBalance_Click;
            // 
            // txtPlaceBets
            // 
            txtPlaceBets.Font = new Font("Franklin Gothic Book", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point);
            txtPlaceBets.Location = new Point(482, 123);
            txtPlaceBets.Name = "txtPlaceBets";
            txtPlaceBets.PlaceholderText = "Enter your bet.";
            txtPlaceBets.Size = new Size(218, 45);
            txtPlaceBets.TabIndex = 3;
            txtPlaceBets.TextChanged += txtPlaceBets_TextChanged;
            // 
            // btnRollDice
            // 
            btnRollDice.Font = new Font("Segoe UI", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            btnRollDice.Location = new Point(71, 227);
            btnRollDice.Name = "btnRollDice";
            btnRollDice.Size = new Size(131, 80);
            btnRollDice.TabIndex = 4;
            btnRollDice.Text = "Roll !";
            btnRollDice.UseVisualStyleBackColor = true;
            btnRollDice.Click += btnRollDice_Click;
            // 
            // lblOutcome
            // 
            lblOutcome.AutoSize = true;
            lblOutcome.Font = new Font("Franklin Gothic Book", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point);
            lblOutcome.Location = new Point(551, 250);
            lblOutcome.Name = "lblOutcome";
            lblOutcome.Size = new Size(149, 38);
            lblOutcome.TabIndex = 5;
            lblOutcome.Text = "Outcome";
            lblOutcome.Click += lblOutcome_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 370);
            Controls.Add(lblOutcome);
            Controls.Add(btnRollDice);
            Controls.Add(txtPlaceBets);
            Controls.Add(lblBalance);
            Controls.Add(lblDice2);
            Controls.Add(lblDice1);
            Name = "Form1";
            Text = "Craps";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDice1;
        private Label lblDice2;
        private Label lblBalance;
        private TextBox txtPlaceBets;
        private Button btnRollDice;
        private Label lblOutcome;
    }
}