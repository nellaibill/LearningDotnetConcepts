namespace OOPS
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
            button1 = new Button();
            button2 = new Button();
            toastMessage = new Label();
            btnStatic = new Button();
            btnAssociation = new Button();
            btnOperatorOverloading = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(43, 20);
            button1.Name = "button1";
            button1.Size = new Size(123, 36);
            button1.TabIndex = 0;
            button1.Text = "Shadowing";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Shadowing_Click;
            // 
            // button2
            // 
            button2.Location = new Point(172, 20);
            button2.Name = "button2";
            button2.Size = new Size(320, 36);
            button2.TabIndex = 1;
            button2.Text = "Can we implement interfaces with same method names?";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Scenario1_Click;
            // 
            // toastMessage
            // 
            toastMessage.AutoSize = true;
            toastMessage.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toastMessage.ForeColor = Color.Blue;
            toastMessage.Location = new Point(28, 347);
            toastMessage.Name = "toastMessage";
            toastMessage.Size = new Size(169, 32);
            toastMessage.TabIndex = 2;
            toastMessage.Text = "Toast message";
            // 
            // btnStatic
            // 
            btnStatic.Location = new Point(498, 20);
            btnStatic.Name = "btnStatic";
            btnStatic.Size = new Size(123, 36);
            btnStatic.TabIndex = 3;
            btnStatic.Text = "Static";
            btnStatic.UseVisualStyleBackColor = true;
            btnStatic.Click += btnStatic_Click;
            // 
            // btnAssociation
            // 
            btnAssociation.Location = new Point(627, 20);
            btnAssociation.Name = "btnAssociation";
            btnAssociation.Size = new Size(123, 36);
            btnAssociation.TabIndex = 4;
            btnAssociation.Text = "Association";
            btnAssociation.UseVisualStyleBackColor = true;
            btnAssociation.Click += btnAssociation_Click;
            // 
            // btnOperatorOverloading
            // 
            btnOperatorOverloading.Location = new Point(43, 87);
            btnOperatorOverloading.Name = "btnOperatorOverloading";
            btnOperatorOverloading.Size = new Size(123, 52);
            btnOperatorOverloading.TabIndex = 5;
            btnOperatorOverloading.Text = "Operator Overloading";
            btnOperatorOverloading.UseVisualStyleBackColor = true;
            btnOperatorOverloading.Click += btnOperatorOverloading_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 513);
            Controls.Add(btnOperatorOverloading);
            Controls.Add(btnAssociation);
            Controls.Add(btnStatic);
            Controls.Add(toastMessage);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label toastMessage;
        private Button btnStatic;
        private Button btnAssociation;
        private Button btnOperatorOverloading;
    }
}
