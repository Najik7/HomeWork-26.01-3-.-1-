using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.з__4_Alif
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите название книги: ");
            string title = Console.ReadLine();

            Console.Write("Введите автора: ");
            string author = Console.ReadLine();

            Console.Write("Введите жанр книги: ");
            string content = Console.ReadLine();

            Book book = new Book(title, author, content);


            Title t = new Title(title);
            t.Show();

            Author a = new Author(author);
            a.Show();

            Content c = new Content(content);
            c.Show();
        }

    }


    public class Book
    {

        Title title;
        Author author;
        Content content;

        public Book(string title, string author, string content)
        {
            this.title = new Title(title);
            this.author = new Author(author);
            this.content = new Content(content);
        }

    }

    class Title  //название
    {
        public string title;
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(title);
        }

        public Title(string title)
        {

            this.title = title;
        }
    }

    class Author  //Автор
    {
        public string author;
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(author);
        }

        public Author(string author)
        {
            this.author = author;
        }
    }

    class Content  //Жанр
    {
        public string content;
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(content);

        }

        public Content(string content)
        {
            this.content = content;
        }
    }
}
