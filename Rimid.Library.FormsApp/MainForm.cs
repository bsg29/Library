﻿using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using Rimid.Library.FormsApp.Models;
using Rimid.Library.Models;
using Rimid.Library.Models.Enums;
using Rimid.Library.Models.Repository;
using Rimid.Library.Models.Utils;

namespace Rimid.Library.FormsApp
{
    public partial class MainForm : Form
    {
        private readonly LibraryEntities _context;
        private readonly UserRepository _userRepository;

        private readonly List<User> _users;

        public MainForm()
        {
            InitializeComponent();

            _context = new LibraryEntities();
            _userRepository = new UserRepository(_context);

            _users = _userRepository.GetObjects().ToList();

            FillUsersTable();

            FillPositions();
        }

        private void FillPositions()
        {
            var positions = EnumUtils.GetLocalizedValues(typeof(PositionEnum));

            var positionItems = positions
                .Select(x => new ComboBoxItem
                {
                    Key = x.Key,
                    Text = x.Value
                })
                .Cast<object>()
                .ToArray();

            PositionComboBox.ValueMember = "Key";
            PositionComboBox.DisplayMember = "Text";

            PositionComboBox.Items.AddRange(positionItems);
        }

        private void FillUsersTable()
        {
            var dataSet = new DataTable();

            dataSet.Columns.Add("Логин");
            dataSet.Columns.Add("Имя");
            dataSet.Columns.Add("Фамилия");
            dataSet.Columns.Add("Отчество");
            dataSet.Columns.Add("Телефон");
            dataSet.Columns.Add("Должность");

            foreach (var user in _users)
            {
                dataSet.Rows.Add(user.Login, 
                    user.FirstName, 
                    user.LastName, 
                    user.MiddleName, 
                    user.Phone,
                    user.PositionWrapper.GetLocalizedValue());
            }

            UsersDataGrid.DataSource = dataSet;
        }

        private void UsersDataGrid_SelectionChanged(object sender, System.EventArgs e)
        {
            var isSelected = UsersDataGrid.SelectedRows.Count > 0;

            if (!isSelected) return;

            var selectedRow = UsersDataGrid.SelectedRows[0];

            var user = _users[selectedRow.Index];

            var positions = PositionComboBox.Items.Cast<ComboBoxItem>().ToList();

            FirstNameTextBox.Text = user.FirstName;
            LastNameTextBox.Text = user.LastName;
            MiddleNameTextBox.Text = user.MiddleName;
            LoginTextBox.Text = user.Login;
            PositionComboBox.SelectedItem = positions.First(x => x.Key == user.PositionId);
            PhoneTextBox.Text = user.Phone;
        }

        private void UserSaveButton_Click(object sender, System.EventArgs e)
        {
            var isSelected = UsersDataGrid.SelectedRows.Count > 0;

            User user;

            if (!isSelected)
            {
                user = new User()
                {
                    Password = PasswordTextBox.Text
                };
            }
            else
            {
                var selectedRow = UsersDataGrid.SelectedRows[0];

                user = _users[selectedRow.Index];
            }

            user.FirstName = FirstNameTextBox.Text.Trim();
            user.LastName = LastNameTextBox.Text.Trim();
            user.MiddleName = MiddleNameTextBox.Text.Trim();
            user.Login = LoginTextBox.Text.Trim();
            user.PositionId = ((ComboBoxItem)PositionComboBox.SelectedItem).Key;
            user.Phone = PhoneTextBox.Text.Trim();

            if (!string.IsNullOrEmpty(PasswordTextBox.Text))
            {
                user.Password = PasswordTextBox.Text;
            }

            _userRepository.Save(user);

            FillUsersTable();
        }
    }
}