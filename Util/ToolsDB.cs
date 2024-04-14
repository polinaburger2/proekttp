﻿using SchoolDance.Class.DB;
using SchoolDance.Class.Logic;

namespace SchoolDance.Util
{
    public static class ToolsDB
    {
        public static void AddNewData()
        {
            AddDanceHall();
            AddDanceStyle();
            AddTopUp();
            AddStudent();
            AddCoach();
            AddAdministrator();
            AddLesson();
            AddPayment();
        }

        static void AddDanceHall()
        {
            for (int i = 1; i <= 10; i++)
            {
                DanceHall obj = new DanceHall
                {
                    roomNumber = $"Room{i}",
                    capacity = i * 5
                };

                DB_Controller.Add(obj);
            }
        }

        static void AddDanceStyle()
        {
            List<DanceStyle> danceStyles = new List<DanceStyle>
            {
                new DanceStyle { name = "Вальс", description = "Вальс - это не только танец, но и способ самовыражения." },
                new DanceStyle { name = "Сальса", description = "Сальса - это энергичный и яркий латиноамериканский танец." },
                new DanceStyle { name = "Фламенко", description = "Фламенко - это горячий испанский танец с гитарой и кастаньетами." },
                new DanceStyle { name = "Танго", description = "Танго - это страстный аргентинский танец, полный эмоций." },
                new DanceStyle { name = "Брейк-данс", description = "Брейк-данс - это энергичный и акробатический уличный танец." },
                new DanceStyle { name = "Балет", description = "Балет - это изящное и классическое искусство танца." },
                new DanceStyle { name = "Хип-хоп", description = "Хип-хоп - это современный и стильный уличный танец." },
                new DanceStyle { name = "Самба", description = "Самба - это праздничный и живой бразильский танец." },
                new DanceStyle { name = "Кизомба", description = "Кизомба - это сенсуальный и романтичный африканский танец." },
                new DanceStyle { name = "Шахтинская", description = "Шахтинская - это народный танец, символизирующий труд и единство." }
            };

            foreach (var item in danceStyles)
                DB_Controller.Add(item);
        }

        static void AddTopUp()
        {
            TopUp obj = new TopUp
            {
                studentId = 1,
                paymentTime = DateTime.Now,
                price = 100
            };

            DB_Controller.Add(obj);

            obj = new TopUp
            {
                studentId = 2,
                paymentTime = DateTime.Now.AddHours(1),
                price = 1200
            };

            DB_Controller.Add(obj);

            obj = new TopUp
            {
                studentId = 3,
                paymentTime = DateTime.Now.AddHours(2),
                price = 140
            };

            DB_Controller.Add(obj);

            obj = new TopUp
            {
                studentId = 4,
                paymentTime = DateTime.Now.AddHours(3),
                price = 10
            };

            DB_Controller.Add(obj);

            obj = new TopUp
            {
                studentId = 5,
                paymentTime = DateTime.Now.AddHours(4),
                price = 500
            };

            DB_Controller.Add(obj);

            obj = new TopUp
            {
                studentId = 6,
                paymentTime = DateTime.Now.AddHours(5),
                price = 11100
            };

            DB_Controller.Add(obj);

            obj = new TopUp
            {
                studentId = 7,
                paymentTime = DateTime.Now.AddHours(6),
                price = 1200
            };

            DB_Controller.Add(obj);

            obj = new TopUp
            {
                studentId = 8,
                paymentTime = DateTime.Now.AddHours(7),
                price = 100
            };

            DB_Controller.Add(obj);

            obj = new TopUp
            {
                studentId = 9,
                paymentTime = DateTime.Now.AddHours(8),
                price = 1400
            };

            DB_Controller.Add(obj);

            obj = new TopUp
            {
                studentId = 10,
                paymentTime = DateTime.Now.AddHours(9),
                price = 100
            };

            DB_Controller.Add(obj);
        }

        static void AddStudent()
        {
            List<Student> students = new List<Student>
            {
            new Student
            {
                login = "quani",
                password = SignInUpLogic.EncodeStringToBase64("password1"),
                fullName = "Поляков Леша Сергеевич",
                gender = "Male",
                date = DateTime.Now.AddDays(-10),
                typePerson = TypePerson.Student,
                balance = 2300
            },
            new Student
            {
                login = "emma789",
                password = SignInUpLogic.EncodeStringToBase64("password2"),
                fullName = "Коврикова Алена Викторовна",
                gender = "Female",
                date = DateTime.Now.AddDays(-20),
                typePerson = TypePerson.Student,
                balance = 1100
            },
            new Student
            {
                login = "alexander321",
                password = SignInUpLogic.EncodeStringToBase64("password3"),
                fullName = "Синицин Олег Вячеславович",
                gender = "Male",
                date = DateTime.Now.AddDays(-30),
                typePerson = TypePerson.Student,
                balance = 400
            },
            new Student
            {
                login = "sophia456",
                password = SignInUpLogic.EncodeStringToBase64("password4"),
                fullName = "Токарева Ирина Игоревна",
                gender = "Female",
                date = DateTime.Now.AddDays(-40),
                typePerson = TypePerson.Student,
                balance = 200
            },
            new Student
            {
                login = "william987",
                password = SignInUpLogic.EncodeStringToBase64("password5"),
                fullName = "Пиратов Сергей Анатольевич",
                gender = "Male",
                date = DateTime.Now.AddDays(-50),
                typePerson = TypePerson.Student,
                balance = 0
            },
            new Student
            {
                login = "olivia654",
                password = SignInUpLogic.EncodeStringToBase64("password6"),
                fullName = "Русакова Ольга Викторовна",
                gender = "Female",
                date = DateTime.Now.AddDays(-60),
                typePerson = TypePerson.Student,
                balance = 10
            },
            new Student
            {
                login = "james789",
                password = SignInUpLogic.EncodeStringToBase64("password7"),
                fullName = "Токарев Леонид Сергеевич",
                gender = "Male",
                date = DateTime.Now.AddDays(-70),
                typePerson = TypePerson.Student,
                balance = 100
            },
            new Student
            {
                login = "isabella123",
                password = SignInUpLogic.EncodeStringToBase64("password8"),
                fullName = "Кадочникова Елена Андреевна",
                gender = "Female",
                date = DateTime.Now.AddDays(-80),
                typePerson = TypePerson.Student,
                balance = 4100
            },
            new Student
            {
                login = "michael456",
                password = SignInUpLogic.EncodeStringToBase64("password9"),
                fullName = "Калин Данил Вячеславович",
                gender = "Male",
                date = DateTime.Now.AddDays(-90),
                typePerson = TypePerson.Student,
                balance = 2100
            },
            new Student
            {
                login = "sophia987",
                password = SignInUpLogic.EncodeStringToBase64("password10"),
                fullName = "Волкова Соня Владимировна",
                gender = "Female",
                date = DateTime.Now.AddDays(-100),
                typePerson = TypePerson.Student,
                balance = 1004
            }
        };

            foreach (var item in students)
                DB_Controller.Add(item);
        }

        static void AddCoach()
        {
            Coach obj = new Coach
            {
                login = "alexandra",
                password = SignInUpLogic.EncodeStringToBase64("password123"),
                fullName = "Нестерова Милана Улебовна",
                gender = "Female",
                date = DateTime.Now.AddDays(-10),
                typePerson = TypePerson.Coach,
                danceStylesId = "2, 4, 7",
                position = "Experienced Coach",
                phoneNumber = "9876543210",
                workExperienceMonth = 24
            };

            DB_Controller.Add(obj);

            obj = new Coach
            {
                login = "johndoe",
                password = SignInUpLogic.EncodeStringToBase64("securepass"),
                fullName = "Савин Донат Никитевич",
                gender = "Male",
                date = DateTime.Now.AddDays(-20),
                typePerson = TypePerson.Coach,
                danceStylesId = "1, 3, 6",
                position = "Senior Coach",
                phoneNumber = "1234567890",
                workExperienceMonth = 36
            };

            DB_Controller.Add(obj);

            obj = new Coach
            {
                login = "emilyb",
                password = SignInUpLogic.EncodeStringToBase64("mypassword"),
                fullName = "Евсеева Валерия Парфеньевна",
                gender = "Female",
                date = DateTime.Now.AddDays(-5),
                typePerson = TypePerson.Coach,
                danceStylesId = "1, 4, 5",
                position = "Lead Coach",
                phoneNumber = "9876543210",
                workExperienceMonth = 48
            };

            DB_Controller.Add(obj);

            obj = new Coach
            {
                login = "michaels",
                password = SignInUpLogic.EncodeStringToBase64("mypass123"),
                fullName = "Григорьев Тимофей Мартынович",
                gender = "Male",
                date = DateTime.Now.AddDays(-15),
                typePerson = TypePerson.Coach,
                danceStylesId = "2, 3, 7",
                position = "Master Coach",
                phoneNumber = "1234567890",
                workExperienceMonth = 60
            };

            DB_Controller.Add(obj);

            obj = new Coach
            {
                login = "sophiep",
                password = SignInUpLogic.EncodeStringToBase64("secure123"),
                fullName = "Савельева Владлена Филипповна",
                gender = "Female",
                date = DateTime.Now.AddDays(-8),
                typePerson = TypePerson.Coach,
                danceStylesId = "1, 4, 6",
                position = "Junior Coach",
                phoneNumber = "9876543210",
                workExperienceMonth = 12
            };

            DB_Controller.Add(obj);

            obj = new Coach
            {
                login = "davidm",
                password = SignInUpLogic.EncodeStringToBase64("pass1234"),
                fullName = "Поляков Сергей Лукьевич",
                gender = "Male",
                date = DateTime.Now.AddDays(-12),
                typePerson = TypePerson.Coach,
                danceStylesId = "3, 5, 7",
                position = "Assistant Coach",
                phoneNumber = "1234567890",
                workExperienceMonth = 18
            };

            DB_Controller.Add(obj);

            obj = new Coach
            {
                login = "olivial",
                password = SignInUpLogic.EncodeStringToBase64("mypassword123"),
                fullName = "Афанасьева Зара Федоровна",
                gender = "Female",
                date = DateTime.Now.AddDays(-6),
                typePerson = TypePerson.Coach,
                danceStylesId = "2, 4, 6",
                position = "Specialty Coach",
                phoneNumber = "9876543210",
                workExperienceMonth = 30
            };
            DB_Controller.Add(obj);

            obj = new Coach
            {
                login = "matthewt",
                password = SignInUpLogic.EncodeStringToBase64("password1234"),
                fullName = "Рогов Роберт Геннадьевич",
                gender = "Male",
                date = DateTime.Now.AddDays(-18),
                typePerson = TypePerson.Coach,
                danceStylesId = "1, 3, 7",
                position = "Expert Coach",
                phoneNumber = "1234567890",
                workExperienceMonth = 42
            };

            DB_Controller.Add(obj);

            obj = new Coach
            {
                login = "hannahm",
                password = SignInUpLogic.EncodeStringToBase64("pass12345"),
                fullName = "Блохина Эстелла Максовна",
                gender = "Female",
                date = DateTime.Now.AddDays(-9),
                typePerson = TypePerson.Coach,
                danceStylesId = "2, 5, 6",
                position = "Lead Instructor",
                phoneNumber = "9876543210",
                workExperienceMonth = 54
            };

            DB_Controller.Add(obj);

            obj = new Coach
            {
                login = "williamh",
                password = SignInUpLogic.EncodeStringToBase64("securepass123"),
                fullName = "Мартынов Сергей Дмитриевич",
                gender = "Male",
                date = DateTime.Now.AddDays(-14),
            };

            DB_Controller.Add(obj);
        }

        static void AddLesson()
        {

            Lesson obj = new Lesson
            {
                className = "Самба в космосе",
                weekdays = "Понедельник, Среда",
                danceHallId = 1,
                danceStylesId = 5,
                coachId = 3,
                price = 2000,
                description = "Изучайте самбу на низкой гравитации и с погружением в вакуум!",
                time_start = "18:00",
                studentId = "1, 2, 3"
            };

            DB_Controller.Add(obj);

            obj = new Lesson
            {
                className = "Танцы с пингвинами",
                weekdays = "Вторник, Четверг",
                danceHallId = 2,
                danceStylesId = 1,
                coachId = 4,
                price = 1800,
                description = "Научитесь танцевать вместе с пингвинами и ощутите их неповторимую грацию!",
                time_start = "17:30",
                studentId = "2, 3, 1"
            };

            DB_Controller.Add(obj);

            obj = new Lesson
            {
                className = "Танец с котятами",
                weekdays = "Среда, Пятница",
                danceHallId = 3,
                danceStylesId = 2,
                coachId = 5,
                price = 1600,
                description = "Танцуйте вместе с милыми котятами и получайте удовольствие от уникального дуэта!",
                time_start = "16:45",
                studentId = ""
            };

            DB_Controller.Add(obj);
        }

        static void AddPayment()
        {
            Payment obj = new Payment
            {
                studentId = 1,
                lessonId = 1,
                date_end_subscription = DateTime.Now,
            };

            DB_Controller.Add(obj);

            obj = new Payment
            {
                studentId = 1,
                lessonId = 2,
                date_end_subscription = DateTime.Now,
            };

            DB_Controller.Add(obj);

            obj = new Payment
            {
                studentId = 2,
                lessonId = 1,
                date_end_subscription = DateTime.Now,
            };

            DB_Controller.Add(obj);

            obj = new Payment
            {
                studentId = 2,
                lessonId = 2,
                date_end_subscription = DateTime.Now,
            };

            DB_Controller.Add(obj);
        }

        static void AddAdministrator()
        {
            Administrator obj = new Administrator
            {
                login = "admin",
                password = SignInUpLogic.EncodeStringToBase64("qwerty"),
                fullName = "Груздев Владимир Владимирович",
                gender = "Female",
                date = DateTime.Now.AddDays(-10),
                typePerson = TypePerson.Administrator,
                position = "Главный администратор",
                phoneNumber = "9876543210",
                workExperienceMonth = 24
            };

            DB_Controller.Add(obj);
        }
    }
}
