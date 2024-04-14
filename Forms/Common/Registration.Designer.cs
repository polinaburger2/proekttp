namespace SchoolDance.Forms
{
    partial class Registration
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
            text_registration = new Label();
            input_password = new TextBox();
            input_login = new TextBox();
            label2 = new Label();
            Password_text = new Label();
            text_password = new Label();
            text_login = new Label();
            background = new Panel();
            dateTime_birth_date = new DateTimePicker();
            radio_female = new RadioButton();
            radio_male = new RadioButton();
            b_SignUp = new Button();
            input_patronymic = new TextBox();
            input_second_name = new TextBox();
            input_first_name = new TextBox();
            text_birth_date = new Label();
            text_gender = new Label();
            text_patronymic = new Label();
            text_second_name = new Label();
            text_first_name = new Label();
            background.SuspendLayout();
            SuspendLayout();
            // 
            // text_registration
            // 
            text_registration.AutoSize = true;
            text_registration.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            text_registration.Location = new Point(107, -13);
            text_registration.Name = "text_registration";
            text_registration.Size = new Size(378, 81);
            text_registration.TabIndex = 1;
            text_registration.Text = "Регистрация";
            // 
            // input_password
            // 
            input_password.Location = new Point(154, 83);
            input_password.Name = "input_password";
            input_password.Size = new Size(239, 27);
            input_password.TabIndex = 10;
            // 
            // input_login
            // 
            input_login.BackColor = SystemColors.Window;
            input_login.Location = new Point(154, 21);
            input_login.Name = "input_login";
            input_login.Size = new Size(239, 27);
            input_login.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 324);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 8;
            // 
            // Password_text
            // 
            Password_text.AutoSize = true;
            Password_text.Location = new Point(189, 253);
            Password_text.Name = "Password_text";
            Password_text.Size = new Size(0, 20);
            Password_text.TabIndex = 9;
            // 
            // text_password
            // 
            text_password.AutoSize = true;
            text_password.BackColor = SystemColors.ActiveCaption;
            text_password.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            text_password.Location = new Point(32, 76);
            text_password.Name = "text_password";
            text_password.Size = new Size(96, 32);
            text_password.TabIndex = 6;
            text_password.Text = "Пароль";
            // 
            // text_login
            // 
            text_login.AutoSize = true;
            text_login.BackColor = SystemColors.ActiveCaption;
            text_login.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            text_login.Location = new Point(32, 21);
            text_login.Name = "text_login";
            text_login.Size = new Size(81, 32);
            text_login.TabIndex = 7;
            text_login.Text = "Логин";
            // 
            // background
            // 
            background.BackColor = SystemColors.ActiveCaption;
            background.Controls.Add(dateTime_birth_date);
            background.Controls.Add(radio_female);
            background.Controls.Add(radio_male);
            background.Controls.Add(input_password);
            background.Controls.Add(b_SignUp);
            background.Controls.Add(input_login);
            background.Controls.Add(input_patronymic);
            background.Controls.Add(text_password);
            background.Controls.Add(input_second_name);
            background.Controls.Add(input_first_name);
            background.Controls.Add(text_birth_date);
            background.Controls.Add(text_gender);
            background.Controls.Add(text_patronymic);
            background.Controls.Add(text_login);
            background.Controls.Add(text_second_name);
            background.Controls.Add(text_first_name);
            background.Location = new Point(57, 76);
            background.Name = "background";
            background.Size = new Size(439, 524);
            background.TabIndex = 12;
            // 
            // dateTime_birth_date
            // 
            dateTime_birth_date.Location = new Point(222, 380);
            dateTime_birth_date.Margin = new Padding(3, 4, 3, 4);
            dateTime_birth_date.Name = "dateTime_birth_date";
            dateTime_birth_date.Size = new Size(188, 27);
            dateTime_birth_date.TabIndex = 13;
            // 
            // radio_female
            // 
            radio_female.AutoSize = true;
            radio_female.Location = new Point(154, 336);
            radio_female.Margin = new Padding(3, 4, 3, 4);
            radio_female.Name = "radio_female";
            radio_female.Size = new Size(92, 24);
            radio_female.TabIndex = 12;
            radio_female.TabStop = true;
            radio_female.Text = "Женский";
            radio_female.UseVisualStyleBackColor = true;
            // 
            // radio_male
            // 
            radio_male.AutoSize = true;
            radio_male.Location = new Point(306, 336);
            radio_male.Margin = new Padding(3, 4, 3, 4);
            radio_male.Name = "radio_male";
            radio_male.Size = new Size(93, 24);
            radio_male.TabIndex = 12;
            radio_male.TabStop = true;
            radio_male.Text = "Мужской";
            radio_male.UseVisualStyleBackColor = true;
            // 
            // b_SignUp
            // 
            b_SignUp.BackColor = Color.PaleGreen;
            b_SignUp.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            b_SignUp.Location = new Point(103, 441);
            b_SignUp.Name = "b_SignUp";
            b_SignUp.Size = new Size(250, 68);
            b_SignUp.TabIndex = 4;
            b_SignUp.Text = "Зарегистрироваться";
            b_SignUp.UseVisualStyleBackColor = false;
            b_SignUp.Click += b_SignIn_Click;
            // 
            // input_patronymic
            // 
            input_patronymic.BackColor = SystemColors.Window;
            input_patronymic.Location = new Point(154, 277);
            input_patronymic.Name = "input_patronymic";
            input_patronymic.Size = new Size(239, 27);
            input_patronymic.TabIndex = 11;
            // 
            // input_second_name
            // 
            input_second_name.BackColor = SystemColors.Window;
            input_second_name.Location = new Point(154, 223);
            input_second_name.Name = "input_second_name";
            input_second_name.Size = new Size(239, 27);
            input_second_name.TabIndex = 11;
            // 
            // input_first_name
            // 
            input_first_name.BackColor = SystemColors.Window;
            input_first_name.Location = new Point(154, 169);
            input_first_name.Name = "input_first_name";
            input_first_name.Size = new Size(239, 27);
            input_first_name.TabIndex = 11;
            // 
            // text_birth_date
            // 
            text_birth_date.AutoSize = true;
            text_birth_date.BackColor = SystemColors.ActiveCaption;
            text_birth_date.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            text_birth_date.Location = new Point(32, 375);
            text_birth_date.Name = "text_birth_date";
            text_birth_date.Size = new Size(184, 32);
            text_birth_date.TabIndex = 7;
            text_birth_date.Text = "Дата рождения";
            // 
            // text_gender
            // 
            text_gender.AutoSize = true;
            text_gender.BackColor = SystemColors.ActiveCaption;
            text_gender.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            text_gender.Location = new Point(34, 328);
            text_gender.Name = "text_gender";
            text_gender.Size = new Size(58, 32);
            text_gender.TabIndex = 7;
            text_gender.Text = "Пол";
            // 
            // text_patronymic
            // 
            text_patronymic.AutoSize = true;
            text_patronymic.BackColor = SystemColors.ActiveCaption;
            text_patronymic.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            text_patronymic.Location = new Point(32, 277);
            text_patronymic.Name = "text_patronymic";
            text_patronymic.Size = new Size(117, 32);
            text_patronymic.TabIndex = 7;
            text_patronymic.Text = "Отчество";
            // 
            // text_second_name
            // 
            text_second_name.AutoSize = true;
            text_second_name.BackColor = SystemColors.ActiveCaption;
            text_second_name.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            text_second_name.Location = new Point(32, 223);
            text_second_name.Name = "text_second_name";
            text_second_name.Size = new Size(113, 32);
            text_second_name.TabIndex = 7;
            text_second_name.Text = "Фамилия";
            // 
            // text_first_name
            // 
            text_first_name.AutoSize = true;
            text_first_name.BackColor = SystemColors.ActiveCaption;
            text_first_name.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            text_first_name.Location = new Point(32, 169);
            text_first_name.Name = "text_first_name";
            text_first_name.Size = new Size(61, 32);
            text_first_name.TabIndex = 7;
            text_first_name.Text = "Имя";
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 615);
            Controls.Add(label2);
            Controls.Add(Password_text);
            Controls.Add(background);
            Controls.Add(text_registration);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Registration";
            Text = "Школа танцев";
            background.ResumeLayout(false);
            background.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label text_registration;
        private TextBox input_password;
        private TextBox input_login;
        private Label label2;
        private Label Password_text;
        private Label text_password;
        private Label text_login;
        private Panel background;
        private Button b_SignUp;
        private TextBox input_patronymic;
        private TextBox input_second_name;
        private TextBox input_first_name;
        private Label text_patronymic;
        private Label text_second_name;
        private Label text_first_name;
        private RadioButton radio_female;
        private RadioButton radio_male;
        private Label text_gender;
        private DateTimePicker dateTime_birth_date;
        private Label text_birth_date;
    }
}