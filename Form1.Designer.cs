namespace CyberSecurityBotGUI
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
            lblTable = new Label();
            txtInput = new TextBox();
            btnSend = new Button();
            lstChat = new ListBox();
            SuspendLayout();
            // 
            // lblTable
            // 
            lblTable.AutoSize = true;
            lblTable.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTable.ForeColor = Color.Cyan;
            lblTable.Location = new Point(321, 85);
            lblTable.Name = "lblTable";
            lblTable.Size = new Size(348, 46);
            lblTable.TabIndex = 0;
            lblTable.Text = "CyberSecurityBot";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(12, 486);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(878, 31);
            txtInput.TabIndex = 2;
            txtInput.TextChanged += txtInput_TextChanged;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(892, 484);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(112, 34);
            btnSend.TabIndex = 3;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // lstChat
            // 
            lstChat.BackColor = Color.Black;
            lstChat.ForeColor = Color.Lime;
            lstChat.FormattingEnabled = true;
            lstChat.ItemHeight = 25;
            lstChat.Location = new Point(12, 195);
            lstChat.Name = "lstChat";
            lstChat.Size = new Size(992, 279);
            lstChat.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1050, 637);
            Controls.Add(lstChat);
            Controls.Add(btnSend);
            Controls.Add(txtInput);
            Controls.Add(lblTable);
            Name = "Form1";
            Text = "CyberSecurityBot";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTable;
        private TextBox txtInput;
        private Button btnSend;
        private ListBox lstChat;
    }
}
