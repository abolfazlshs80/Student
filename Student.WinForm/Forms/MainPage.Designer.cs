namespace Student.WinForm
{
    partial class MainPage
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
            tabControl1 = new TabControl();
            TabPageManageCategory = new TabPage();
            Locadbutton = new Button();
            ButtonEditCategory = new Button();
            ButtonCreateCategory = new Button();
            TextBoxSearch = new TextBox();
            ButtonDeleteCategory = new Button();
            DataGridViewCategory = new DataGridView();
            tabControl1.SuspendLayout();
            TabPageManageCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewCategory).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(TabPageManageCategory);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(630, 476);
            tabControl1.TabIndex = 0;
            // 
            // TabPageManageCategory
            // 
            TabPageManageCategory.Controls.Add(Locadbutton);
            TabPageManageCategory.Controls.Add(ButtonEditCategory);
            TabPageManageCategory.Controls.Add(ButtonCreateCategory);
            TabPageManageCategory.Controls.Add(TextBoxSearch);
            TabPageManageCategory.Controls.Add(ButtonDeleteCategory);
            TabPageManageCategory.Controls.Add(DataGridViewCategory);
            TabPageManageCategory.Location = new Point(4, 24);
            TabPageManageCategory.Name = "TabPageManageCategory";
            TabPageManageCategory.Size = new Size(622, 448);
            TabPageManageCategory.TabIndex = 2;
            TabPageManageCategory.Text = "Manage Student";
            TabPageManageCategory.UseVisualStyleBackColor = true;
            // 
            // Locadbutton
            // 
            Locadbutton.Location = new Point(66, 410);
            Locadbutton.Name = "Locadbutton";
            Locadbutton.Size = new Size(106, 29);
            Locadbutton.TabIndex = 1;
            Locadbutton.Text = "Load Data";
            Locadbutton.UseVisualStyleBackColor = true;
            Locadbutton.Click += Locadbutton_Click;
            // 
            // ButtonEditCategory
            // 
            ButtonEditCategory.Location = new Point(178, 409);
            ButtonEditCategory.Name = "ButtonEditCategory";
            ButtonEditCategory.Size = new Size(110, 29);
            ButtonEditCategory.TabIndex = 1;
            ButtonEditCategory.Text = "Edit";
            ButtonEditCategory.UseVisualStyleBackColor = true;
            ButtonEditCategory.Click += ButtonEditCategory_Click;
            // 
            // ButtonCreateCategory
            // 
            ButtonCreateCategory.Location = new Point(433, 409);
            ButtonCreateCategory.Name = "ButtonCreateCategory";
            ButtonCreateCategory.Size = new Size(133, 29);
            ButtonCreateCategory.TabIndex = 1;
            ButtonCreateCategory.Text = "Create";
            ButtonCreateCategory.UseVisualStyleBackColor = true;
            ButtonCreateCategory.Click += ButtonCreateCategory_Click;
            // 
            // TextBoxSearch
            // 
            TextBoxSearch.Location = new Point(7, 10);
            TextBoxSearch.Name = "TextBoxSearch";
            TextBoxSearch.Size = new Size(565, 23);
            TextBoxSearch.TabIndex = 2;
            TextBoxSearch.TextChanged += TextBoxSearchCategory_TextChanged;
            // 
            // ButtonDeleteCategory
            // 
            ButtonDeleteCategory.Location = new Point(294, 409);
            ButtonDeleteCategory.Name = "ButtonDeleteCategory";
            ButtonDeleteCategory.Size = new Size(133, 29);
            ButtonDeleteCategory.TabIndex = 1;
            ButtonDeleteCategory.Text = "Delete";
            ButtonDeleteCategory.UseVisualStyleBackColor = true;
            ButtonDeleteCategory.Click += ButtonDeleteCategory_Click;
            // 
            // DataGridViewCategory
            // 
            DataGridViewCategory.AllowUserToAddRows = false;
            DataGridViewCategory.AllowUserToDeleteRows = false;
            DataGridViewCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCategory.Location = new Point(3, 39);
            DataGridViewCategory.MultiSelect = false;
            DataGridViewCategory.Name = "DataGridViewCategory";
            DataGridViewCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewCategory.Size = new Size(748, 365);
            DataGridViewCategory.TabIndex = 0;
            DataGridViewCategory.CellDoubleClick += DataGridViewCategory_CellDoubleClick;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 488);
            Controls.Add(tabControl1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainPage";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Main Form";
            Load += MainPage_Load;
            tabControl1.ResumeLayout(false);
            TabPageManageCategory.ResumeLayout(false);
            TabPageManageCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewCategory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage TabPageInsertPassword;
        private Button ButtonDelete;
        private Button ButtonEdit;
        private TabPage TabPageManageCategory;
        private TextBox TextBoxSearch;
        private DataGridView DataGridViewCategory;
        private Button ButtonEditCategory;
        private Button ButtonCreateCategory;
        private Button ButtonDeleteCategory;
        private Button Locadbutton;
    }
}
