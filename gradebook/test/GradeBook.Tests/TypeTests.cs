using System;
using Xunit;

namespace GradeBook.Tests
{
    
    public delegate string WriteLogDelegate(string logMessage);


    public class TypeTests
    {
	[Fact]
	public void WriteLogDelegateCanPointToMethod() {
		WriteLogDelegate log;
		log = ReturnMessage;
		var result = log("Errorrrrrrrr");
		Assert.Equal("Errorrrrrrrr", result);
	}

	private string ReturnMessage(string logMessage)
	{
		return logMessage;
	}

	[Fact]
        public void Test1()
        {
		var x = getInt();
		SetInt(out x);
		Assert.Equal(42, x);
        }

	private void SetInt(out int x)
	{
		x = 42;
	}

	private int getInt()
	{
		return 3;
	}

	[Fact]
        public void Test2()
        {
		var book1 = GetBook("Book 1");
		var book2 = GetBook("Book 2");

		Assert.Equal("Book 1", book1.Book_title);
		Assert.Equal("Book 2", book2.Book_title);
        }

	private Book GetBook(string  title)
	{
		return new Book(title);
	}


	[Fact]
	public void StringsBehaveLikeValueTypes() {
		string name = "yoyo";
		name = MakeUpperCase(name);

		Assert.Equal("YOYO", name);

	}

	private string MakeUpperCase(string name)
	{
		return name.ToUpper();
	}


	}
}
