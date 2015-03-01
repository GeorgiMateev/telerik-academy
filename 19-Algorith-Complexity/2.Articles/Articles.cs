using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wintellect.PowerCollections;
using System.IO;

namespace _2.Articles
{
    class Articles
    {
        struct Article : IComparable<Article>
        {
            int barcode;

            public int Barcode
            {
                get { return barcode; }
                set { barcode = value; }
            }
            string vendor;

            public string Vendor
            {
                get { return vendor; }
                set { vendor = value; }
            }
            string title;

            public string Title
            {
                get { return title; }
                set { title = value; }
            }
            decimal price;

            public decimal Price
            {
                get { return price; }
                set { price = value; }
            }

            public Article(int barcode, string vendor, string title, decimal price)
            {
                this.barcode = barcode;
                this.vendor = vendor;
                this.title = title;
                this.price = price;
            }

            public override string ToString()
            {
                return String.Format("Barcode: {0}, {1}, {2} Price: {3}", barcode, vendor, title, price);
            }
                        
            public int CompareTo(Article other)
            {
                if (this.price<other.price)
                {
                    return -1;
                }
                if (this.price>other.price)
                {
                    return 1;
                }
                return 0;
            }
        }

        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            OrderedMultiDictionary<decimal,Article> articles = new OrderedMultiDictionary<decimal,Article>(true);

            string articlesPath = "articles.txt";

            StreamReader articlesReader = new StreamReader(articlesPath);
            using (articlesReader)
            {
                string articleLine = articlesReader.ReadLine();
                while (articleLine!=null)
                {
                    string[] articleParts = articleLine.Split(new string[]{" - "}, StringSplitOptions.None);
                    Article article = 
                        new Article(int.Parse(articleParts[0]), articleParts[1], articleParts[2], decimal.Parse(articleParts[3]) );
                    articles.Add(article.Price, article);
                    articleLine = articlesReader.ReadLine();
                }
            }

            Console.Write("From price: ");
            decimal from = decimal.Parse(Console.ReadLine());

            Console.Write("To: ");
            decimal to = decimal.Parse(Console.ReadLine());

            OrderedMultiDictionary<decimal, Article>.View selection = articles.Range(from, true, to, true);
            foreach (var item in selection)
            {
                Console.WriteLine(item.Value.ToString());
            }

            Console.ReadKey();
        }
    }
}
