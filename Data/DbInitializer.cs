using System.Diagnostics;
using kiretfinalexam.Models;
namespace kiretfinalexam.Data
{
    public class DbInitializer
    {
        public static void Initialize(ExamContext context)
        {
            // Look for any students.
            if (context.Books.Any())
            {
                return;   // DB has been seeded
            }

            var book = new Books[]
            {
              new Books{name="Life Worth Living",type="Hardcover",Date=DateTime.Parse("2019-09-01"),publisher="The open field",language="English",NumberOfPages=352
                ,isbn10=0593489306,isbn13=978034897,weight="8 Ounces",dimensions="5.21 x 0.67 x 8.01 inches",
                    rank="#6 in non-fiction Books", review=4.5},
                
                new Books{name="Outlive",type="Audiobook",Date=DateTime.Parse("2023-03-28"),publisher="Random House Audio",language="English",NumberOfPages=0
                ,isbn10=1785044540,isbn13=978754540,weight="0 Ounces",dimensions="6.02 x 1.57 x 9.21 inches",
                    rank="#1 in non - fiction Books", review=4.6},
                
                new Books{name="Spare",type="paperback",Date=DateTime.Parse("2023-01-10"),publisher="Random House Large Print",language="English",NumberOfPages=672
                ,isbn10=0593677862,isbn13=978977865,weight="1.44 pounds",dimensions="6.05 x 1.16 x 9.18 inches",
                    rank="#3 in non - fiction Books", review=4.5},
                
                new Books{name="The Subtle Art of Not Giving a Fuck",type="kindle",Date=DateTime.Parse("2016-01-13"),publisher="Harper",language="English",NumberOfPages=212
                ,isbn10=0062641549,isbn13=978057714,weight="7.7 ounces",dimensions="5.31 x 0.68 x 8 inches",
                    rank="#3 in non - fiction Books", review=4.6},
                
                new Books{name="Greenlights",type="paperback",Date=DateTime.Parse("2021-03-30"),publisher="HACHETTE",language="English",NumberOfPages=304
                ,isbn10=0593139135,isbn13=978319134,weight="9.9 ounces",dimensions=" 5.08 x 0.98 x 7.76 inches",
                    rank="#13 in non - fiction Books", review=4.7},
                
                new Books{name="The Mountain is You",type="paperback",Date=DateTime.Parse("2020-06-01"),publisher="Thought Catalog Books",language="English",NumberOfPages=248
                ,isbn10=1949759229,isbn13=978159228,weight="8.8 ounces",dimensions=" 5 x 0.62 x 8 inches",
                    rank="#18 in non - fiction Books", review=4.7},
                
                new Books{name="Lessons in Chemistry",type="Paperback-Large Print",Date=DateTime.Parse("2022-04-12"),publisher="Random House Large Print",language="English",NumberOfPages=560
                ,isbn10=0593556674,isbn13=978936672,weight="1.15 pounds",dimensions="6.05 x 0.96 x 9.18 inches",
                    rank="#1 in fiction Books", review=4.6},
                
                new Books{name="I Will Find You",type="Hardcover",Date=DateTime.Parse("2023-03-14"),publisher="Grand Central Publishing",language="English",NumberOfPages=336
                ,isbn10=1538748363,isbn13=978157367,weight="1.1 pounds",dimensions="6.35 x 1.35 x 9.3 inches",
                    rank="#5 in fiction Books", review=4.5},
                
                new Books{name="Verity",type="Paperbck",Date=DateTime.Parse("2018-12-10"),publisher="Independently published ",language="English",NumberOfPages=331
                ,isbn10=1791392792,isbn13=978913976,weight="14.4 ounces",dimensions="5.5 x 0.83 x 8.5 inches",
                    rank="#16 in fiction Books", review=4.6},
                    
                new Books{name="Daisy Jones & The Six",type="Paperbck",Date=DateTime.Parse("2020-02-04"),publisher="Random House Publishing Group",language="English",NumberOfPages=400
                ,isbn10=1524798649,isbn13=978157942,weight=" 9.6  ounces",dimensions="5.13 x 0.83 x 8 inches",
                    rank="#3 in fiction Books", review=4.4}









            };

            context.Books.AddRange(book);
            context.SaveChanges();

            var author = new Author[]
            {
                //life worth living
                new Author{AName="Miroslav Volf",description="Miroslav Volf is the Henry B. Wright Professor of Theology at Yale Divinity School and Director of the Yale Center for Faith & Culture. He has published and edited nine books and over 60 scholarly articles, including his book Exclusion and Embrace, which won the 2002 Grawemeyer Award in Religion."},
               //life worth living
               new Author{AName="Matthew Croasmun",description="Matt Croasmun is Associate Research Scholar and Director of the Life Worth Living Program at the Yale Center for Faith and Culture and Lecturer of Divinity & Humanities at Yale University. He began working with YCFC after completing his Ph.D. in Religious Studies at Yale in 2014."}
            ,
               //outlive
            new Author  {AName="Peter Attia",description="Peter Attia, MD, is the founder of Early Medical, a medical practice that applies the principles of Medicine 3.0 to patients with the goal of lengthening their lifespan and simultaneously improving their healthspan.He is the host of The Drive, one of the most popular podcasts covering the topics of health and medicine.He is also the author of the #1 New York Times Bestseller, Outlive: The Science and Art of Longevity."},
            //spare
            new Author{AName="Prince Harry",description="Prince Harry, Duke of Sussex,[fn 2] KCVO (Henry Charles Albert David; born 15 September 1984)[2] is a member of the British royal family. He is the younger son of King Charles III and Diana, Princess of Wales. He is fifth in the line of succession to the British throne."},
            //The Subtle Art of Not Giving a Fuck
            new Author{AName="Mark Manson",description="Mark Manson is the New York Times bestselling author of The Subtle Art of Not Giving a F*ck (more than ten million copies sold worldwide) and a star blogger. Manson sold more than 250,000 copies of his self-published book, Models: Attract Women Through Honesty."},
            //Greenlights
            new Author{AName="Matthew McConaughey",description="Matthew McConaughey, in full Matthew David McConaughey, (born November 4, 1969, Uvalde, Texas, U.S.), American actor whose virile good looks and Southern charm established him as a romantic leading man, a status that belied an equal ability to evince flawed, unpleasant characters."},
            //the mountain is you
                new Author{AName="Brianna Wiest",description="Brianna is the bestselling author of the books 101 Essays That Will Change The Way You Think, The Mountain Is You, The Pivot Year, Salt Water, Ceremony, When You're Ready, This Is How You Heal, and more. Her books have sold over 1 million copies worldwide, regularly appear on global bestseller lists, and are currently being translated into 30+ languages."},
              //lessons in chem
                new Author{AName="Bonnie Garmus",description="BONNIE GARMUS is a copywriter and creative director who has worked widely in the fields of technology, medicine, and education. She’s an open-water swimmer, a rower, and mother to two pretty amazing daughters. Born in California and most recently from Seattle, she currently lives in London with her husband and her dog, 99."},
               //i will found you
                new Author{AName="Harlan Coben",description="With over 80 million books in print worldwide, Harlan Coben is the #1 New York Times author of thirty four novels including WIN, THE BOY FROM THE WOODS, RUN AWAY, FOOL ME ONCE, TELL NO ONE and the renowned Myron Bolitar series. His books are published in 45 languages around the globe."},
               //verity
                new Author{AName="Colleen Hoover",description="Colleen Hoover is the #1 New York Times bestselling author of twenty four novels and novellas. Hoover’s novels fall into the New Adult and Young Adult contemporary romance categories, as well as psychological thriller. \r\n\r\nColleen Hoover is published by Atria Books, Grand Central Publishing, Montlake Romance, and HarperCollins Publishers."},
                 
                //daisy jone and the six
                new Author{AName="Taylor Jenkins Reid",description="Taylor Jenkins Reid is the author of the New York Times Bestselling novels Carrie Soto Is Back, Malibu Rising, Daisy Jones and the Six and The Seven Husbands of Evelyn Hugo, as well as One True Loves, Maybe in Another Life, After I Do, and Forever, Interrupted. Her books have been chosen by Reese’s Book Club, Read with Jenna, Indie Next, Best of Amazon, and Book of the Month. Her novel, Daisy Jones and The Six, is currently being adapted by Hello Sunshine into a limited series for Amazon. She lives in Los Angeles."}
                 
            };

            context.Author.AddRange(author);
            context.SaveChanges();

            var info = new Information[]
            {
                new Information{AName="Miroslav Volf",Name="Life Worth Living",AuthorId=1,BooksID = 1},
                new Information{AName="Matthew Croasmun",Name="Life Worth Living",AuthorId = 2,BooksID=1},
                new Information{AName="Peter Attia",Name="Outlive",AuthorId=3,BooksID = 2},
                new Information{AName="Prince Harry",Name="The Subtle Art of Not Giving a Fuck",AuthorId=4,BooksID = 3},                
                new Information{AName="Mark Manson",Name="Spare" ,AuthorId=5,BooksID = 4},                
                new Information{AName="Matthew McConaughey",Name="Greenlights",AuthorId=6,BooksID = 5},                
                new Information{AName="Brianna Wiest",Name="The Mountain is You",AuthorId=7,BooksID = 6},                
                new Information{AName="Bonnie Garmus",Name="Lessons in Chemistry",AuthorId=8,BooksID = 7},                
                new Information{AName="Harlan Coben",Name="I Will Find You",AuthorId=9,BooksID = 8},              
                new Information{AName="Colleen Hoover",Name="Verity",AuthorId=10,BooksID = 9},                
                new Information{AName="Taylor Jenkins Reid",Name="Daisy Jones & The Six",AuthorId=11,BooksID = 10}               

            };

            context.Information.AddRange(info);
            context.SaveChanges();
        }
    }
}