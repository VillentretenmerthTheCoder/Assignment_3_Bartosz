using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1_Bartosz
{
   public class Book
    {
        private string _title;

        public string Title
        {
            get { return _title;}
            set
            {
                if (value.Length >= 2)
                    _title = value;
                else
                    throw new ArgumentOutOfRangeException("Title needs to be at least 2 characters long!");
            }
        }

        private string _author;
        public string Author
        {
            get { return _author;}
            set { _author = value;}
        }

        private int _pageNumber;
        public int PageNumber
        {
            get{ return _pageNumber; }
            set
            {
                if (value > 10 && value <= 1000)
                {
                    _pageNumber = value;
                }
                else throw new ArgumentOutOfRangeException("Page number need to be higher then 10 and lower or equal 1000!");
            }
        }

        private string _isbn13;
       
        public string Isbn13
        {
            get { return _isbn13; }
            set
            {
                if (value.Length == 13)
                    _isbn13 = value;
                else
                    throw new ArgumentOutOfRangeException("Isbn13 string needs to have exactly 13 characters!");
            }
        }

        public Book()
        {

        }

        public Book(string title, string author, int pageNumber, string isbn13)
        {
            Title = title;
            Author = author;
            PageNumber = pageNumber;
            Isbn13 = isbn13;

        }

        public override string ToString()
        {
            return $"ISBN13: {Isbn13}, Author: {Author}, Title: {Title}, Page number: {PageNumber}.";
        }
    }
}
