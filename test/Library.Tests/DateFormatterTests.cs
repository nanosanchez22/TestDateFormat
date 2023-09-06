using NUnit.Framework.Internal;

namespace Library.Tests;

public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void FechaCorrecta(){
        const string expected = "1997-11-10";
        const string prueba = "10/11/1997";
        DateFormatterTests dateFormatterTests= new DateFormatterTests();
        Assert.That(TestDateFormat.DateFormatter.ChangeFormat(prueba), Is.EqualTo(expected));
        

    }
    [Test]
    public void FechaIncorrecta(){
        const string expected = "1997-11-10";
        const string prueba = "10111997";
        DateFormatterTests dateFormatterTests= new DateFormatterTests();
        Assert.That(TestDateFormat.DateFormatter.ChangeFormat(prueba), Is.Not.EqualTo(expected));


    }
    [Test]
    public void FechaEnBlanco(){
        const string prueba = "";
        DateFormatterTests dateFormatterTests= new DateFormatterTests();
        Assert.Throws<ArgumentOutOfRangeException>(() => TestDateFormat.DateFormatter.ChangeFormat(prueba));
    } 

}