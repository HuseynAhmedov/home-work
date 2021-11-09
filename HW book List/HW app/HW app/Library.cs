using System;
using System.Collections.Generic;
using System.Text;

namespace HW_app
{
    class Library
    {
        public List<Book> booksMainList = new List<Book>();

        public List<Book> FindAllBooksByName(string wantedName)
        {
            List<Book> booksTemp = new List<Book>(booksMainList.Count);
            foreach (var item in booksMainList)
            {
                if (item.Name == wantedName)
                {
                    booksTemp.Add(item);
                }
            }
            return booksTemp;
        }

        public void RemoveAllBookByName(string deleteName)
        {
            List<Book> booksTemp = new List<Book>(booksMainList);
            foreach (var item in booksMainList)
            {
                if (item.Name == deleteName)
                {
                    booksTemp.Remove(item);
                }
            }
            booksMainList = booksTemp;
        }

        public List<Book> SearchBooks(string searchStr)
        {
            List<Book> booksTemp = new List<Book>(booksMainList.Count);
            searchStr = searchStr.Trim().ToLower();
            foreach (var item in booksMainList)
            {
                if (item.AuthorName.ToLower().Contains(searchStr) || item.Name.ToLower().Contains(searchStr) || item.PageCount.ToString().Contains(searchStr))
                {
                    booksTemp.Add(item);
                }
            }
            return booksTemp;
        }

        public List<Book> FindAllBooksByPageCountRange(int minCount , int maxCount)
        {
            List<Book> booksTemp = new List<Book>(booksMainList.Count);
            foreach (var item in booksMainList)
            {
                if (item.PageCount > minCount && item.PageCount < maxCount)
                {
                    booksTemp.Add(item);
                }
            }
            return booksTemp;
        }
        public void RemoveByCode(int removeNo)
        {
            List<Book> booksTemp = new List<Book>(booksMainList);
            foreach (var item in booksMainList)
            {
                if (item.NoMain == removeNo)
                {
                    booksTemp.Remove(item);
                }
            }
            booksMainList = booksTemp;
        }
    }
}
