//factory pattern, provider, singleton, model binding --> complex model, data notations

using System.Security.Cryptography;

public interface INotification{
    void Notify(string message);
}

public class EmailNotification : INotification{
    public void Notify(string message){
        Console.WriteLine($"Sending Emai: {message}");
    }
}

public class SMSNotification : INotification{
    public void Notify(string message){
        Console.WriteLine($"Sending SMS: {message}");
    }
}

public class NotificationsFactory{
    public INotification GetNotification(string notifType){
        switch(notifType.ToLower()){
            case "email":
                 return new EmailNotification();
            case "sms":
                 return new SMSNotification();
            default:
                throw new ArgumentException("Invalid Input");
        }

    }
}

class Program{
    static void Main(){
        NotificationsFactory notification = new NotificationsFactory();

        INotification emailNotification = notification.GetNotification("email");
        emailNotification.Notify("Your email has been sent");

        INotification smsNotification = notification.GetNotification("sms");
        smsNotification.Notify("Your OTP is 1234");
    }
}