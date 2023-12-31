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
        Assert.That(TestDateFormat.DateFormatter.ChangeFormat(prueba), Is.EqualTo(expected));
        

    }
    [Test]
    public void FechaIncorrecta(){
        const string expected = "1997-11-10";
        const string prueba = "10111997";
        Assert.That(TestDateFormat.DateFormatter.ChangeFormat(prueba), Is.Not.EqualTo(expected));


    }
    [Test]
    public void FechaIncorrecta2(){
        const string expected = "Wrong format, try dd/mm/yyyy";
        const string prueba = "10111997";
        Assert.That(TestDateFormat.DateFormatter.ChangeFormat(prueba), Is.EqualTo(expected));


    }

    [Test]
    public void FechaVacia(){
        const string expected = "";
        const string prueba = "";
        Assert.That(TestDateFormat.DateFormatter.ChangeFormat(prueba), Is.EqualTo(expected));


    }
/*     [Test]
    public void FechaEnBlanco(){
        const string prueba = "";
        Assert.Throws<ArgumentOutOfRangeException>(() => TestDateFormat.DateFormatter.ChangeFormat(prueba));
    }  */

}