using System;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;


public class Mail 
{
    static void Main(string[] args)
    {
        Regex valid = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");

        Console.WriteLine("Введите логин почты:");
        string myaddress = Console.ReadLine();

        if (!valid.IsMatch(myaddress))
        {
            Console.WriteLine("Некорректный ввод почты");
            return ;
        }
        //нужно добавить в настройках своей почты mail.ru пароль для приложений и использовать его в качестве пароля
        Console.WriteLine("Пароль от почты:");
        string mypassword = Console.ReadLine();

        Console.WriteLine("Введите адрес отправки");
        string recipaddress = Console.ReadLine();
        if (!valid.IsMatch(recipaddress))
        {
            Console.WriteLine("Некорректный ввод почты");
            return;
        }

        Console.WriteLine("Заголовок:");
        string title = Console.ReadLine();

        Console.WriteLine("Сообщение:");
        string textmessage = Console.ReadLine();

        MailMessage mail = new MailMessage();
        mail.From = new MailAddress(myaddress); // Почта отправителя
        mail.To.Add(new MailAddress(recipaddress)); // Почта получателя
        mail.Subject = title;
        mail.Body = textmessage;
        
        SmtpClient client = new SmtpClient();
        client.Host = "smtp.mail.ru";
        client.Port = 587;
        client.EnableSsl = true;
        client.UseDefaultCredentials = false;
        client.Credentials = new NetworkCredential(myaddress, mypassword); // Логин и пароль вашей почты
        client.Send(mail);

        Console.WriteLine("Сообщение отправлено");
        Console.ReadKey();
        }
} 




