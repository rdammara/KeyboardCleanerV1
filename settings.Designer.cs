namespace KeyboardCleaner
{
    partial class settings
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
            txtPassword = new TextBox();
            label1 = new Label();
            saveButton = new Button();
            exitButton = new Button();
            chkPasswordProtection = new CheckBox();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(122, 124);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 127);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 1;
            label1.Text = "Set Password";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(143, 319);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 29);
            saveButton.TabIndex = 2;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(263, 319);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(94, 29);
            exitButton.TabIndex = 3;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            // 
            // chkPasswordProtection
            // 
            chkPasswordProtection.AutoSize = true;
            chkPasswordProtection.Location = new Point(15, 84);
            chkPasswordProtection.Name = "chkPasswordProtection";
            chkPasswordProtection.Size = new Size(213, 24);
            chkPasswordProtection.TabIndex = 4;
            chkPasswordProtection.Text = "Enable Password Protection";
            chkPasswordProtection.UseVisualStyleBackColor = true;
            // 
            // settings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 387);
            Controls.Add(chkPasswordProtection);
            Controls.Add(exitButton);
            Controls.Add(saveButton);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Name = "settings";
            Text = "settings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private Label label1;
        private Button saveButton;
        private Button exitButton;
        private CheckBox chkPasswordProtection;
    }
}