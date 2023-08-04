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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DisableKeyboardBtn = new CheckBox();
            label1 = new Label();
            settingsButton = new Button();
            SuspendLayout();
            // 
            // DisableKeyboardBtn
            // 
            DisableKeyboardBtn.AutoSize = true;
            DisableKeyboardBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DisableKeyboardBtn.Location = new Point(37, 218);
            DisableKeyboardBtn.Margin = new Padding(3, 4, 3, 4);
            DisableKeyboardBtn.Name = "DisableKeyboardBtn";
            DisableKeyboardBtn.Size = new Size(312, 32);
            DisableKeyboardBtn.TabIndex = 0;
            DisableKeyboardBtn.Text = "Lock My Keyboard For Cleaning";
            DisableKeyboardBtn.UseVisualStyleBackColor = true;
            DisableKeyboardBtn.CheckedChanged += DisableKeyboardBtn_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(41, 95);
            label1.Name = "label1";
            label1.Size = new Size(308, 41);
            label1.TabIndex = 1;
            label1.Text = "Keyboard Cleaner v1";
            // 
            // settingsButton
            // 
            settingsButton.Location = new Point(238, 318);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(94, 29);
            settingsButton.TabIndex = 2;
            settingsButton.Text = "Settings";
            settingsButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 387);
            Controls.Add(settingsButton);
            Controls.Add(label1);
            Controls.Add(DisableKeyboardBtn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "KeyboardCleanerV1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox DisableKeyboardBtn;
        private Label label1;
        private Button settingsButton;
    }
}