﻿using System.Linq;

namespace MovCat.Models
{
    public class StartData
    {
        public static void Initialize(MovieContext context)
        {
            if (!context.Movies.Any())
            {
                context.Movies.AddRange(
                    new Movie
                    {
                        Name = "Термина́тор 2",
                        Description = @"Американский научно-фантастический боевик режиссёра Джеймса Кэмерона, пятый в его карьере, сиквел фильма «Терминатор». В главной роли снялся Арнольд Шварценеггер.
                                        По мнению многих исследователей, фильм стал первым в истории кинематографа, который привлёк широкое внимание к компьютерной анимации и изменил отношение к ней создателей других фильмов[2][3].
                                        Фильм снимали с июня по ноябрь 1990 года в Лос - Анджелесе. В 2017 и 2019 годах фильм вышел в повторный прокат в формате 3D.",
                        CreatedYear = "1991",
                        Director = "Джеймс Кэмерон"
                    },
                    new Movie
                    {
                        Name = "Храброе сердце",
                        Description = @"Американский фильм, рассказывающий о борьбе Шотландии за независимость против английского господства. Главный герой фильма — Уильям Уоллес, предводитель шотландцев, в исполнении Мела Гибсона.
                                        В 1995 году фильм «Храброе сердце» был выдвинут на 10 номинаций премии «Оскар» и выиграл 5 из них, включая награды за лучший фильм 1995 года, за лучший грим, режиссуру, работу оператора и звуковые эффекты.",
                        CreatedYear = "1995",
                        Director = "Мел Гибсон"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}