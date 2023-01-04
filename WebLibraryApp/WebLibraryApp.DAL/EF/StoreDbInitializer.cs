//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using WebLibraryApp.DAL.Entities;
//using System.Data.Entity;

//namespace WebLibraryApp.DAL.EF
//{
//    public class StoreDbInitializer : DropCreateDatabaseAlways<DataContext>
//    {
//        protected override void Seed(DataContext context)
//        {
//            context.BookTopics.Add(new BookTopic
//            {
//                Id = 1,
//                Topic = "Adventures",
//                Books = new List<Book>()
//                {
//                    new Book
//                    {
//                        Id = 7
//                    },
//                    new Book
//                    {
//                        Id = 8
//                    }
//                }
//            });
//            context.BookTopics.Add(new BookTopic
//            {
//                Id = 2,
//                Topic = "Fairytale",
//                Books = new List<Book>()
//                {
//                    new Book
//                    {
//                        Id = 3
//                    },
//                    new Book
//                    {
//                        Id = 4
//                    },
//                    new Book
//                    {
//                        Id = 5
//                    }
//                }
//            });
//            context.BookTopics.Add(new BookTopic
//            {
//                Id = 3,
//                Topic = "Psychology",
//                Books = new List<Book>()
//                {
//                    new Book
//                    {
//                        Id = 1
//                    },
//                    new Book
//                    {
//                        Id = 2
//                    },
//                    new Book
//                    {
//                        Id = 6
//                    }
//                }
//            });
//            context.Authors.Add(new Author
//            {
//                Id = 1,
//                Name = "Valerian Pidmohylyny",
//                Books = new List<Book>()
//                {
//                    new Book
//                    {
//                        Id = 1
//                    },
//                    new Book
//                    {
//                        Id = 2
//                    }
//                }
//            });
//            context.Authors.Add(new Author
//            {
//                Id = 2,
//                Name = "Oksana Zabuzhko",
//                Books = new List<Book>()
//                {
//                    new Book
//                    {
//                        Id = 3
//                    },
//                    new Book
//                    {
//                        Id = 4
//                    }
//                }
//            });
//            context.Authors.Add(new Author
//            {
//                Id = 3,
//                Name = "Donna Tartt",
//                Books = new List<Book>()
//                {
//                    new Book
//                    {
//                        Id = 5
//                    },
//                    new Book
//                    {
//                        Id = 6
//                    }
//                }
//            });
//            context.Authors.Add(new Author
//            {
//                Id = 4,
//                Name = "Mark Twain",
//                Books = new List<Book>()
//                {
//                    new Book
//                    {
//                        Id = 7
//                    },
//                    new Book
//                    {
//                        Id = 8
//                    }
//                }
//            });
//            context.Books.Add(new Book
//            {
//                Id = 1,
//                Name = "A little drama",
//                NumberOfAvailable = 3,
//                Authors = new List<Author>()
//                {
//                    new Author
//                    {
//                        Id= 1,
//                    }
//                },
//                BookTopics = new List<BookTopic>()
//                {
//                    new BookTopic
//                    {
//                        Id = 3
//                    }
//                },
//                UserCards = new List<UserCard>()
//            });
//            context.Books.Add(new Book
//            {
//                Id = 2,
//                Name = "City",
//                NumberOfAvailable = 2,
//                Authors = new List<Author>()
//                {
//                    new Author
//                    {
//                        Id= 1,
//                    }
//                },
//                BookTopics = new List<BookTopic>()
//                {
//                    new BookTopic
//                    {
//                        Id = 3
//                    }
//                },
//                UserCards = new List<UserCard>()
//            });
//            context.Books.Add(new Book
//            {
//                Id = 3,
//                Name = "Museum of Abandoned Secrets",
//                NumberOfAvailable = 2,
//                Authors = new List<Author>()
//                {
//                    new Author
//                    {
//                        Id= 2,
//                    }
//                },
//                BookTopics = new List<BookTopic>()
//                {
//                    new BookTopic
//                    {
//                        Id = 2
//                    }
//                },
//                UserCards = new List<UserCard>()
//            });
//            context.Books.Add(new Book
//            {
//                Id = 4,
//                Name = "A tale about a viburnum pipe",
//                NumberOfAvailable = 3,
//                Authors = new List<Author>()
//                {
//                    new Author
//                    {
//                        Id= 2,
//                    }
//                },
//                BookTopics = new List<BookTopic>()
//                {
//                    new BookTopic
//                    {
//                        Id = 2
//                    }
//                },
//                UserCards = new List<UserCard>()
//            });
//            context.Books.Add(new Book
//            {
//                Id = 5,
//                Name = "Goldfinch",
//                NumberOfAvailable = 2,
//                Authors = new List<Author>()
//                {
//                    new Author
//                    {
//                        Id= 3,
//                    }
//                },
//                BookTopics = new List<BookTopic>()
//                {
//                    new BookTopic
//                    {
//                        Id = 2
//                    }
//                },
//                UserCards = new List<UserCard>()
//            });
//            context.Books.Add(new Book
//            {
//                Id = 6,
//                Name = "A secret story",
//                NumberOfAvailable = 3,
//                Authors = new List<Author>()
//                {
//                    new Author
//                    {
//                        Id= 3,
//                    }
//                },
//                BookTopics = new List<BookTopic>()
//                {
//                    new BookTopic
//                    {
//                        Id = 3
//                    }
//                },
//                UserCards = new List<UserCard>()
//            });
//            context.Books.Add(new Book
//            {
//                Id = 7,
//                Name = "The Adventures of Tom Sawyer",
//                NumberOfAvailable = 2,
//                Authors = new List<Author>()
//                {
//                    new Author
//                    {
//                        Id= 4,
//                    }
//                },
//                BookTopics = new List<BookTopic>()
//                {
//                    new BookTopic
//                    {
//                        Id = 1
//                    }
//                },
//                UserCards = new List<UserCard>()
//            });
//            context.Books.Add(new Book
//            {
//                Id = 8,
//                Name = "The prince and the pauper",
//                NumberOfAvailable = 3,
//                Authors = new List<Author>()
//                {
//                    new Author
//                    {
//                        Id= 4,
//                    }
//                },
//                BookTopics = new List<BookTopic>()
//                {
//                    new BookTopic
//                    {
//                        Id = 1
//                    }
//                },
//                UserCards = new List<UserCard>()
//            });
//            context.SaveChanges();
//        }
//    }
//}
