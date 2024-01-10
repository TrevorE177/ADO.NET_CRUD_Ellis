namespace ADO.NET_CRUD_Ellis
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
            peopleFoundListBox = new ListBox();
            personIDText = new TextBox();
            searchButton = new Button();
            personID = new Label();
            SuspendLayout();
            // 
            // peopleFoundListBox
            // 
            peopleFoundListBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            peopleFoundListBox.FormattingEnabled = true;
            peopleFoundListBox.ItemHeight = 30;
            peopleFoundListBox.Location = new Point(12, 57);
            peopleFoundListBox.Name = "peopleFoundListBox";
            peopleFoundListBox.Size = new Size(827, 634);
            peopleFoundListBox.TabIndex = 0;
            // 
            // personIDText
            // 
            personIDText.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            personIDText.Location = new Point(118, 15);
            personIDText.Name = "personIDText";
            personIDText.Size = new Size(214, 32);
            personIDText.TabIndex = 1;
            // 
            // searchButton
            // 
            searchButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchButton.Location = new Point(338, 17);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(82, 29);
            searchButton.TabIndex = 2;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // personID
            // 
            personID.AutoSize = true;
            personID.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            personID.Location = new Point(12, 18);
            personID.Name = "personID";
            personID.Size = new Size(92, 25);
            personID.TabIndex = 3;
            personID.Text = "Person ID";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 720);
            Controls.Add(personID);
            Controls.Add(searchButton);
            Controls.Add(personIDText);
            Controls.Add(peopleFoundListBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox peopleFoundListBox;
        private TextBox personIDText;
        private Button searchButton;
        private Label personID;
    }
}