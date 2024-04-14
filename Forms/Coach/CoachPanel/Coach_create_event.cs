﻿using SchoolDance.Class.DB;
using SchoolDance.Controller;
using SchoolDance.Util;


namespace SchoolDance.Forms
{
    public partial class Coach_create_event : Form
    {
        MainController<EventDance> controller = new();

        public Coach_create_event()
        {
            InitializeComponent();
        }

        private void b_create_event_Click(object sender, EventArgs e)
        {
            if (input_name_event.Text == "" || input_description.Text == "")
            {
                ToolsForm.ShowMessage("Нужно заполнить все поля");
                return;
            }

            if (date_event.Value < DateTime.Now)
            {
                ToolsForm.ShowMessage("Дата мероприятия уже прошла");
                return;
            }

            EventDance eventDance = new EventDance
            {
                date = date_event.Value,
                nameEvent = input_name_event.Text,
                description = input_description.Text,
            };


            if (controller.AddFromDB(eventDance) == true)
            {
                ToolsForm.ShowMessage("Мероприятие создано", "Создание мероприятия", MessageBoxIcon.Asterisk);
            }
            else
            {
                ToolsForm.ShowMessage("Что-то пошло не так. Возможно такое значение уже занят.");
            }
        }
    }
}
