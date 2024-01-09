﻿using System;

namespace Lab10_csharp
{
    class Teacher:Employee
    {
        protected string subjectTaught; //преподаваемый предмет

        public string SubjectTaught
        {
            get => subjectTaught;
            set
            {
                if (value.Length > 2)
                    subjectTaught = value;
                else
                {
                    Console.WriteLine("Ошибка. Преподаваемый предмет не может быть меньше 3 символов");
                    subjectTaught = "-";
                }
            }
        }

        //конструктор без параметров
        public Teacher():base()
        {
            subjectTaught = "-";
        }

        //конструктор с параметрами
        public Teacher( string _firstName, string _secondName, double _salary, string _placeWork, string _subjectTaught) 
                        :base(_firstName, _secondName, _salary, _placeWork)
        {
            SubjectTaught = _subjectTaught;
        }

        //Ввод данных в класс вручную
        public void Init(string _firstName, string _secondName, double _salary, string _placeWork, string _subjectTaught)
        {
            base.Init(_firstName, _secondName, _salary, _placeWork);
            SubjectTaught = _subjectTaught;
        }

        //Ввод данных в класс автоматически
        public override void RandomInit()
        {
            base.RandomInit();

            Random random = new Random();
            switch (random.Next(6))
            {
                case 1:
                    {
                        subjectTaught = "Математика";
                        break;
                    }
                case 2:
                    {
                        subjectTaught = "Физика";
                        break;
                    }
                case 3:
                    {
                        subjectTaught = "Информатика";
                        break;
                    }
                case 4:
                    {
                        subjectTaught = "Биология";
                        break;
                    }
                case 5:
                    {
                        subjectTaught = "Философия";
                        break;
                    }
                case 6:
                    {
                        subjectTaught = "Социология";
                        break;
                    }
            }

        }

        //вывод на экран
        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Преподаваемый предмет: {subjectTaught}");
        }
    }
}
