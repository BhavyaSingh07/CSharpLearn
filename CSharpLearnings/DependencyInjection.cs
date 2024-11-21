public interface IPaymentService{
    bool ProccessPayment(decimal amount);
}

public interface INotificationService{
    void SendNotification(string message);
}

public interface IOrderService{
    void PlaceOrder(decimal amount);
}

public class PaymentService : IPaymentService{
    public bool ProccessPayment(decimal amount){
        Console.WriteLine($"Processing payment of {amount}");
        return true;
    }
}

public class NotificationService : INotificationService{
    public void SendNotification(string message){
        Console.WriteLine($"Notification sent: {message}");
    }
}

public class OrderService : IOrderService{
    private readonly IPaymentService paymentService;
    private readonly INotificationService notificationService;

    public OrderService(IPaymentService paymentService, INotificationService notificationService){
        this.paymentService = paymentService;
        this.notificationService = notificationService;
    }

    public void PlaceOrder(decimal amount){
        if(paymentService.ProccessPayment(amount)){
            Console.WriteLine("Order placed successfully!!!");
            notificationService.SendNotification("Your order has been confirmed");
        }
        else{
            Console.WriteLine("Order failed due to payment issues");
        }
    }
}

class Porgram{
    static void Main(){
        IPaymentService paymentService = new PaymentService();
        INotificationService notificationService = new NotificationService();

        IOrderService orderService = new OrderService(paymentService, notificationService);
        orderService.PlaceOrder(150.32m);
    }
}