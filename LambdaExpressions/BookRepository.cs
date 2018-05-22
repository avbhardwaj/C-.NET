using System.Collections.Generic;

namespace LambdaExpressions
{
	public class BookRepository
	{
		public List<Book> GetBooks()
		{
			return new List<Book>
			{
				new Book() {Title = "Harry Potter", Price = 75},
				new Book() {Title = "Book 2", Price = 85},
				new Book() {Title = "Book 3", Price = 150}
			};
		}
	}
}