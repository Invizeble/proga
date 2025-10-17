using System.Collections.Generic;

namespace Library.Data
{
    public static class InitialData
    {
        public static List<Book> GetInitialBooks()
        {
            return new List<Book>
            {
                new Book { Id = 1, Title = "Война и мир", Author = "Лев Толстой", Count = 5 },
                new Book { Id = 2, Title = "Преступление и наказание", Author = "Фёдор Достоевский", Count = 3 },
                new Book { Id = 3, Title = "Мастер и Маргарита", Author = "Михаил Булгаков", Count = 2 },
                new Book { Id = 4, Title = "1984", Author = "Джордж Оруэлл", Count = 4 },
                new Book { Id = 5, Title = "Отцы и дети", Author = "Иван Тургенев", Count = 6 },
                new Book { Id = 6, Title = "Преступление и наказание", Author = "Фёдор Достоевский", Count = 3 },
                new Book { Id = 7, Title = "Анна Каренина", Author = "Лев Толстой", Count = 4 },
                new Book { Id = 8, Title = "Герой нашего времени", Author = "Михаил Лермонтов", Count = 5 },
                new Book { Id = 9, Title = "Мёртвые души", Author = "Николай Гоголь", Count = 2 },
                new Book { Id = 10, Title = "Евгений Онегин", Author = "Александр Пушкин", Count = 3 },
                new Book { Id = 11, Title = "Идиот", Author = "Фёдор Достоевский", Count = 4 },
                new Book { Id = 12, Title = "Дубровский", Author = "Александр Пушкин", Count = 5 },
                new Book { Id = 13, Title = "Тихий Дон", Author = "Михаил Шолохов", Count = 2 },
                new Book { Id = 14, Title = "Обломов", Author = "Иван Гончаров", Count = 3 },
                new Book { Id = 15, Title = "Собачье сердце", Author = "Михаил Булгаков", Count = 4 },
                new Book { Id = 16, Title = "Лолита", Author = "Владимир Набоков", Count = 2 },
                new Book { Id = 17, Title = "Доктор Живаго", Author = "Борис Пастернак", Count = 3 },
                new Book { Id = 18, Title = "Пикник на обочине", Author = "Аркадий и Борис Стругацкие", Count = 4 },
                new Book { Id = 19, Title = "Маленький принц", Author = "Антуан де Сент-Экзюпери", Count = 5 },
                new Book { Id = 20, Title = "Фауст", Author = "Иоганн Вольфганг фон Гёте", Count = 2 },
                new Book { Id = 21, Title = "Гамлет", Author = "Уильям Шекспир", Count = 3 },
                new Book { Id = 22, Title = "Макбет", Author = "Уильям Шекспир", Count = 4 },
                new Book { Id = 23, Title = "Ромео и Джульетта", Author = "Уильям Шекспир", Count = 2 },
                new Book { Id = 24, Title = "Отелло", Author = "Уильям Шекспир", Count = 3 },
                new Book { Id = 25, Title = "Король Лир", Author = "Уильям Шекспир", Count = 4 },
                new Book { Id = 26, Title = "Сон в летнюю ночь", Author = "Уильям Шекспир", Count = 5 },
            };
        }

        public static List<Visitor> GetInitialVisitors()
        {
            return new List<Visitor>{
                new Visitor { Id = 1, FullName = "Иванов Иван Иванович", TakenBooks = new List<Book>() },
                new Visitor { Id = 2, FullName = "Петров Петр Петрович", TakenBooks = new List<Book>()},
                new Visitor { Id = 3, FullName = "Сидорова Мария Александровна", TakenBooks = new List<Book>()},
                new Visitor { Id = 4, FullName = "Кузнецов Алексей Сергеевич", TakenBooks = new List<Book>()},
                new Visitor { Id = 5, FullName = "Васильева Анна Михайловна", TakenBooks = new List<Book>()},
                new Visitor { Id = 6, FullName = "Смирнов Дмитрий Николаевич", TakenBooks = new List<Book>()},
                new Visitor { Id = 7, FullName = "Морозова Елена Викторовна", TakenBooks = new List<Book>()},
                new Visitor { Id = 8, FullName = "Новиков Сергей Александрович", TakenBooks = new List<Book>()},
                new Visitor { Id = 9, FullName = "Федорова Ольга Ивановна", TakenBooks = new List<Book>()},
                new Visitor { Id = 10, FullName = "Соколов Андрей Петрович", TakenBooks = new List<Book>()},
                new Visitor { Id = 11, FullName = "Зайцева Наталья Сергеевна", TakenBooks = new List<Book>()},
                new Visitor { Id = 12, FullName = "Михайлов Владимир Александрович", TakenBooks = new List<Book>()},
                new Visitor { Id = 13, FullName = "Алексеева Татьяна Владимировна", TakenBooks = new List<Book>()},
                new Visitor { Id = 14, FullName = "Григорьев Максим Сергеевич", TakenBooks = new List<Book>()},
                new Visitor { Id = 15, FullName = "Козлова Ирина Николаевна", TakenBooks = new List<Book>()},
                new Visitor { Id = 16, FullName = "Попов Евгений Дмитриевич", TakenBooks = new List<Book>()},
            };
        }
    }
}