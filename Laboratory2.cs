/*
Отправка сообщения(3 мин). 
Класс “Электронная почта”
  Свойства
    Тема письма
    Адрес получателя
    Текст письма
  Метод
    Расчёт времени доставки: добавить случайный интервал времени к дате отправления (DateTime.Now)
Класс «Почта России»
  Свойства
    Адрес получателя
    Текст письма
    Отделение почты
  Метод
    Расчёт доставки доставки: добавить 7 дней к текущей дате;
Класс «Список сообщений»
  Метод
    Расположить сообщения в порядке убывания даты доставки.
*/
using System;
using System.Globalization;
using System.Security.Cryptography;
using static SendList;

static void Main(string[] args)
{
    var post1 = new MailRus("Text", "Belorussia", "Russia, Moscow");
    // Console.WriteLine(post1.DeliveryTime());
    var email1 = new Email("tututut", "mail@mail.ru", "train");
    // Console.WriteLine(email1.DeliveryTime());
    var list = new SendList { post1, email1 };
    foreach (var e in list)
    {
        ISendDescending el = e as ISendDescending;
        if (el != null) Console.WriteLine(el.DateResult());
    }
    list.SortByDeliveryDate();
    foreach (var e in list)
    {
        ISendDescending el = e as ISendDescending;
        if (el != null) Console.WriteLine(el.DateResult());
    }

}

public abstract class SendMessageBase
{
    public string TextMessage { get; set; }
    public string AddressRecipient { get; set; }

    protected SendMessageBase(string textMessage, string addressRecipient)
    {
        TextMessage = textMessage;
        AddressRecipient = addressRecipient;
    }

}

public class MailRus: SendMessageBase, ISendDescending
{
    public string PostOffice { get; set; } //Почтовое отделение

    public MailRus(string textMessage, string addressRecipient, string postOffice) : base(textMessage, addressRecipient)
    {
        PostOffice = postOffice;
    }
   
    public DateTime DateResult() => DateTime.Now.AddMinutes(Randomize.Radomize());

}

public class Email: SendMessageBase, ISendDescending
{
    public string MessageTopic { get; set; } //Тема письма

    public Email(string textMessage, string addressRecipient, string messageTopic) : base(textMessage, addressRecipient)
    {
        MessageTopic = messageTopic;
    }
    //Расчёт доставки доставки: добавить 7 дней к текущей дате;
    public DateTime DateResult() => DateTime.Now.AddDays(7);
}

public static class Randomize
{
    public static int Radomize()
    {
        Random random = new Random();

        return random.Next(20, 180);
    }
}

public class SendList : List<SendMessageBase>
{
    public void SortByDeliveryDate()
    {
        // this.OfType<ISendDiscending>().Cast<ISendDiscending>().ToList().OrderByDescending(e => e.DeliveryTime());
        this.Sort((e, e2) =>
        {
            ISendDescending? newE = e as ISendDescending;
            ISendDescending? newE2 = e2 as ISendDescending;
            return string.Compare(newE.DateResult().ToString(), newE2.DateResult().ToString());
        });
    }

}

public interface ISendDescending
{
    DateTime DateResult();
}

