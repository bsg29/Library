namespace Rimid.Library.FormsApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.UsersDataGrid = new System.Windows.Forms.DataGridView();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.MiddleNameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.MiddleNameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PositionComboBox = new System.Windows.Forms.ComboBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.UserSaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UsersDataGrid
            // 
            this.UsersDataGrid.AllowUserToAddRows = false;
            this.UsersDataGrid.AllowUserToDeleteRows = false;
            this.UsersDataGrid.AllowUserToOrderColumns = true;
            this.UsersDataGrid.AllowUserToResizeColumns = false;
            this.UsersDataGrid.AllowUserToResizeRows = false;
            this.UsersDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UsersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsersDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.UsersDataGrid.Location = new System.Drawing.Point(0, 0);
            this.UsersDataGrid.MultiSelect = false;
            this.UsersDataGrid.Name = "UsersDataGrid";
            this.UsersDataGrid.ReadOnly = true;
            this.UsersDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersDataGrid.Size = new System.Drawing.Size(800, 225);
            this.UsersDataGrid.TabIndex = 0;
            this.UsersDataGrid.SelectionChanged += new System.EventHandler(this.UsersDataGrid_SelectionChanged);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(53, 35);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(29, 13);
            this.FirstNameLabel.TabIndex = 1;
            this.FirstNameLabel.Text = "Имя";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(53, 59);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(56, 13);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "Фамилия";
            // 
            // MiddleNameLabel
            // 
            this.MiddleNameLabel.AutoSize = true;
            this.MiddleNameLabel.Location = new System.Drawing.Point(53, 81);
            this.MiddleNameLabel.Name = "MiddleNameLabel";
            this.MiddleNameLabel.Size = new System.Drawing.Size(54, 13);
            this.MiddleNameLabel.TabIndex = 3;
            this.MiddleNameLabel.Text = "Отчество";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(53, 103);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(45, 13);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Пароль";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(53, 12);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(38, 13);
            this.LoginLabel.TabIndex = 5;
            this.LoginLabel.Text = "Логин";
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.Location = new System.Drawing.Point(53, 126);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(65, 13);
            this.PositionLabel.TabIndex = 6;
            this.PositionLabel.Text = "Должность";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(157, 32);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.FirstNameTextBox.TabIndex = 7;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(157, 9);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(100, 20);
            this.LoginTextBox.TabIndex = 8;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(157, 56);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.LastNameTextBox.TabIndex = 9;
            // 
            // MiddleNameTextBox
            // 
            this.MiddleNameTextBox.Location = new System.Drawing.Point(157, 78);
            this.MiddleNameTextBox.Name = "MiddleNameTextBox";
            this.MiddleNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.MiddleNameTextBox.TabIndex = 10;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(157, 100);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.PasswordTextBox.TabIndex = 11;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // PositionComboBox
            // 
            this.PositionComboBox.FormattingEnabled = true;
            this.PositionComboBox.Location = new System.Drawing.Point(157, 123);
            this.PositionComboBox.Name = "PositionComboBox";
            this.PositionComboBox.Size = new System.Drawing.Size(100, 21);
            this.PositionComboBox.TabIndex = 12;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(53, 149);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(52, 13);
            this.PhoneLabel.TabIndex = 13;
            this.PhoneLabel.Text = "Телефон";
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(157, 146);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.PasswordChar = '*';
            this.PhoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.PhoneTextBox.TabIndex = 14;
            this.PhoneTextBox.UseSystemPasswordChar = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.UsersDataGrid);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.UserSaveButton);
            this.splitContainer1.Panel2.Controls.Add(this.LoginLabel);
            this.splitContainer1.Panel2.Controls.Add(this.PhoneTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.FirstNameLabel);
            this.splitContainer1.Panel2.Controls.Add(this.PhoneLabel);
            this.splitContainer1.Panel2.Controls.Add(this.LastNameLabel);
            this.splitContainer1.Panel2.Controls.Add(this.PositionComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.MiddleNameLabel);
            this.splitContainer1.Panel2.Controls.Add(this.PasswordTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.PasswordLabel);
            this.splitContainer1.Panel2.Controls.Add(this.MiddleNameTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.PositionLabel);
            this.splitContainer1.Panel2.Controls.Add(this.LastNameTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.FirstNameTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.LoginTextBox);
            this.splitContainer1.Panel2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 225;
            this.splitContainer1.TabIndex = 15;
            // 
            // UserSaveButton
            // 
            this.UserSaveButton.Location = new System.Drawing.Point(56, 175);
            this.UserSaveButton.Name = "UserSaveButton";
            this.UserSaveButton.Size = new System.Drawing.Size(75, 23);
            this.UserSaveButton.TabIndex = 15;
            this.UserSaveButton.Text = "Сохранить";
            this.UserSaveButton.UseVisualStyleBackColor = true;
            this.UserSaveButton.Click += new System.EventHandler(this.UserSaveButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "Главная";
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGrid)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView UsersDataGrid;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label MiddleNameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox MiddleNameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.ComboBox PositionComboBox;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button UserSaveButton;
    }
}

