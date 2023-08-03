namespace KeyboardCleaner
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
            DisableKeyboardBtn = new CheckBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // DisableKeyboardBtn
            // 
            DisableKeyboardBtn.AutoSize = true;
            DisableKeyboardBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DisableKeyboardBtn.Location = new Point(72, 159);
            DisableKeyboardBtn.Name = "DisableKeyboardBtn";
            DisableKeyboardBtn.Size = new Size(157, 25);
            DisableKeyboardBtn.TabIndex = 0;
            DisableKeyboardBtn.Text = "Lock My Keyboard";
            DisableKeyboardBtn.UseVisualStyleBackColor = true;
            DisableKeyboardBtn.CheckedChanged += DisableKeyboardBtn_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(36, 71);
            label1.Name = "label1";
            label1.Size = new Size(251, 32);
            label1.TabIndex = 1;
            label1.Text = "Keyboard Cleaner v1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 290);
            Controls.Add(label1);
            Controls.Add(DisableKeyboardBtn);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox DisableKeyboardBtn;
        private Label label1;
    }
}