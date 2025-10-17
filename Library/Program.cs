using System;
using Library.Data;

public abstract class Lib{ 
}

public class Book : Lib
{
    public int? Id { get; set; }
    public string? Title { get; set; }
    public string? Author { get; set; }
    public int? Count { get; set; }
}

public class Visitor : Lib
{
    public int? Id { get; set; }
    public string? FullName { get; set; }
    public List<Book> TakenBooks { get; set; } = new List<Book>();
}

class Program
{
    static void Main(string[] args)
    {
        List<Book> books = InitialData.GetInitialBooks();
        List<Visitor> visitors = InitialData.GetInitialVisitors();
        
        while (true){
        start:

        Console.WriteLine(@"
        === Добро пожаловать в библиотеку! ===
        Выберите действие:
        1. Просмотреть список книг
        2. Просмотреть список посетителей
        0. Выйти");

        string? choice = Console.ReadLine();
    
        switch (choice){
            case "1":
                Console.WriteLine("Список доступных книг:");
                foreach (var book in books)
                {
                        Console.WriteLine($"ID: {book.Id} - Книга: {book.Title} - Автор: {book.Author} - В наличии: {book.Count}");
                }
                    while(true){
                        Console.WriteLine("----------------------------------------\n Выберите действие: \n1 - Взять книгу, \n2 - Вернуть книгу, \n0 - Назад");
                        string? action1 = Console.ReadLine();
                        switch(action1){
                            case "1":
                                Console.WriteLine("Введите ID посетителя:");
                                // показываем всех посетителей
                                foreach (var visitor in visitors){
                                        Console.WriteLine($"ID: {visitor.Id} ; Посетитель: {visitor.FullName} ; Взятые книги: {visitor.TakenBooks.Count}");
                                    }
                                // получаем айди посетителя
                                if (int.TryParse(Console.ReadLine(), out int visitorId)) {
                                    Console.WriteLine("Список доступных книг:");
                                    // все книги
                                    foreach (var book in books)
                                    {
                                        if (book.Count != 0)
                                        {
                                            Console.WriteLine($"ID: {book.Id} - {book.Title} - {book.Author}");
                                        }
                                        else continue;
                                    }
                                    //получаем айдишник книги
                                    Console.WriteLine("Введите айди книги которую вы хотите взять:");
                                    if (int.TryParse(Console.ReadLine(), out int bookId))
                                    {
                                        // ищем тут короче книгу и посетителя по айдишникам
                                        var selectedVisitor = visitors.FirstOrDefault(v => v.Id == visitorId);
                                        var selectedBook = books.FirstOrDefault(b => b.Id == bookId);

                                        // если все гуд, то книгу из её количество убираем, и добавляем в список взятых постетителем
                                        if (selectedVisitor != null && selectedBook != null && selectedBook.Count > 0)
                                        {
                                            selectedVisitor.TakenBooks.Add(selectedBook);
                                            selectedBook.Count--;
                                            Console.WriteLine($"Книга '{selectedBook.Title}' успешно взята посетителем '{selectedVisitor.FullName}'.");
                                        }
                                        else
                                        {
                                            // ну либо иначе иди в попу
                                            Console.WriteLine("Ошибка: Неверный ID посетителя или книги, либо книга недоступна.");
                                        }
                                        
                                        

                                    }
                                    else continue;
                                    

                                }

                                else continue;

                                break;
                            case "2":
                                Console.WriteLine("Введите ID посетителя:");
                                // опять же все посетители
                                foreach (var visitor in visitors)
                                {
                                    Console.WriteLine($"ID: {visitor.Id} ; Посетитель: {visitor.FullName} ; Взятые книги: {visitor.TakenBooks.Count}");
                                }
                                // получаем айди нашего постетителя
                                if (int.TryParse(Console.ReadLine(), out int returnVisitorId))
                                {
                                    // сразу в списке находим тогда
                                    var returningVisitor = visitors.FirstOrDefault(v => v.Id == returnVisitorId);

                                    // и если короче он брал книги, то выводим. Если он ничего не брал, пусть топает брать наши лучшие книги, а то совсем обнаглел
                                    if (returningVisitor != null && returningVisitor.TakenBooks.Count > 0)
                                    {
                                        // а здесь выводим тех кто все таки решился взять наши книги и соизволил их вовремя вернуть
                                        Console.WriteLine("Книги, взятые этим посетителем:");
                                        foreach (var takenBook in returningVisitor.TakenBooks)
                                        {
                                            Console.WriteLine($"ID: {takenBook.Id} - {takenBook.Title} - {takenBook.Author}");
                                        }
                                        Console.WriteLine("Введите ID книги, которую хотите вернуть:");

                                        // а тут получаем айди книги которую он хочет вернуть
                                        if (int.TryParse(Console.ReadLine(), out int returnBookId))
                                        {
                                            // тут все так же поиск который я не разобрал до конца
                                            var returningBook = returningVisitor.TakenBooks.FirstOrDefault(b => b.Id == returnBookId);
                                            if (returningBook != null)
                                            {
                                                // если книга все таки нашлась, то удаляем её из списка взятых и добавляем в общее количество на складе
                                                returningVisitor.TakenBooks.Remove(returningBook);
                                                var libraryBook = books.FirstOrDefault(b => b.Id == returnBookId);
                                                if (libraryBook != null)
                                                {
                                                    libraryBook.Count++;
                                                }
                                                Console.WriteLine($"Книга '{returningBook.Title}' успешно возвращена.");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Ошибка: У этого посетителя нет такой книги.");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ошибка: Неверный ID посетителя или у него нет взятых книг.");
                                    }
                                }
                                else continue;
                                break;
                            case "0":
                                goto start;
                            default:
                                Console.WriteLine("Некорректный выбор. Пожалуйста, попробуйте снова.");
                                goto start;
                                }
                            }

            case "2":
                Console.WriteLine("Список посетителей:");
                // тут опять же все посетители
                foreach (var visitor in visitors)
                {
                Console.WriteLine($"ID: {visitor.Id} - Посетитель: {visitor.FullName} - Взятые книги: {visitor.TakenBooks.Count}");
                }

                Console.WriteLine("Введите посетителя, чтобы посмотреть какие книги он взял:");
                
                // получаем его айди
                if (int.TryParse(Console.ReadLine(), out int viewVisitorId))
                {
                    // опять поиск
                    var viewVisitor = visitors.FirstOrDefault(v => v.Id == viewVisitorId);
                    if (viewVisitor != null)
                    {
                        // и все таки если он нашелся, то выводим то что он взял
                        Console.WriteLine($"Посетитель: {viewVisitor.FullName} взял следующие книги:");
                        // и если взятые книги есть, то выводим их, если он ничего не брал то говори что он плохой человек
                        if (viewVisitor.TakenBooks.Count != 0){
                            foreach (var takenBook in viewVisitor.TakenBooks)
                            {
                                
                                Console.WriteLine($"ID: {takenBook.Id} - {takenBook.Title} - {takenBook.Author}");
                            }
                        }
                        else{
                            Console.WriteLine("Этот посетитель не брал книги.");
                        }
                    }
                    else
                    {
                        // а тут нашего постетиля все таки нет в бд
                        Console.WriteLine("Ошибка: Неверный ID посетителя.");
                    }
                }
                else continue;
                
                
                
            break;

            case "0":
                Console.WriteLine("Выход из программы. До свидания!");
                return;
            default:
                Console.WriteLine("Некорректный выбор. Пожалуйста, попробуйте снова.");
                break;
        }
        }
    }
}