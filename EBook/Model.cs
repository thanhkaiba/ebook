using System;
using System.Collections.Generic;


namespace EBook
{
    public class Novel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string characters { get; set; }
        public string description { get; set; }
        public List<Chapter> chapters { get; set; }
    }

    public class Chapter
    {
        public int id { get; set; }
        public int number { get; set; }
        public string name { get; set; }
        public List<Page> pages { get; set; }
    }

    public class Page
    {
        public int id { get; set; }
        public Boolean bookmark { get; set; }
        public string name { get; set; }
        public string content { get; set; }
        public int pageNumber { get; set; }
        public int idChapter { get; set; }
    }
}
