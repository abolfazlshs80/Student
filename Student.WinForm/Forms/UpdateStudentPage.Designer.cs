namespace Student.WinForm.Forms
{
    partial class UpdateStudentPage
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
            TextBoxName = new TextBox();
            ButtonSubmitCategory = new Button();
            label1 = new Label();
            TextBoxNationalCode = new TextBox();
            label2 = new Label();
            label3 = new Label();
            DatePickerBirthDay = new DateTimePicker();
            SuspendLayout();
            // 
            // TextBoxName
            // 
            TextBoxName.Location = new Point(96, 10);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.Size = new Size(330, 23);
            TextBoxName.TabIndex = 0;
            // 
            // ButtonSubmitCategory
            // 
            ButtonSubmitCategory.Location = new Point(12, 114);
            ButtonSubmitCategory.Name = "ButtonSubmitCategory";
            ButtonSubmitCategory.Size = new Size(193, 32);
            ButtonSubmitCategory.TabIndex = 1;
            ButtonSubmitCategory.Text = "Submit Student";
            ButtonSubmitCategory.UseVisualStyleBackColor = true;
            ButtonSubmitCategory.Click += ButtonSubmitStudent_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 15);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 2;
            label1.Text = "FullName";
            // 
            // TextBoxNationalCode
            // 
            TextBoxNationalCode.Location = new Point(96, 39);
            TextBoxNationalCode.Name = "TextBoxNationalCode";
            TextBoxNationalCode.Size = new Size(330, 23);
            TextBoxNationalCode.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 44);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 2;
            label2.Text = "NationalCode";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 81);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 2;
            label3.Text = "BirthDay";
            // 
            // DatePickerBirthDay
            // 
            DatePickerBirthDay.Location = new Point(96, 73);
            DatePickerBirthDay.Name = "DatePickerBirthDay";
            DatePickerBirthDay.Size = new Size(200, 23);
            DatePickerBirthDay.TabIndex = 3;
            // 
            // UpdateStudentPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 158);
            Controls.Add(DatePickerBirthDay);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ButtonSubmitCategory);
            Controls.Add(TextBoxNationalCode);
            Controls.Add(TextBoxName);
            Name = "UpdateStudentPage";
            Text = "UpdateCategoryPage";
            Load += UpdateStudentPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxName;
        private Button ButtonSubmitCategory;
        private Label label1;
        private TextBox TextBoxNationalCode;
        private Label label2;
        private Label label3;
        private DateTimePicker DatePickerBirthDay;
    }
}