// See https://aka.ms/new-console-template for more information
using OOP;
using OOP.Abstraction;
using OOP.Encapsulation;
using OOP.Inheritance;

Console.WriteLine("Hello, World!");

StructureOfAClass structureOfAClass = new StructureOfAClass();
structureOfAClass.Field1 = 1;


BaseClass baseClassObj = new BaseClass();
//baseClassObj.VariableProp = 3;
baseClassObj.DoSomething();


//ChildClass childClassObj = new ChildClass();


//UserBl userBl = new UserBl();

//Mapper mapper = new Mapper();
//var userDal = mapper. .MapUserBl(userBl);

SingletonClass singletonInstance = SingletonClass.GetInstance();


// --------------------------------



INotificationService notificationService1 = new EmailNotificationService("aa@a.a", "subject", "body", "message");
INotificationService notificationService2 = new SmsNotificationService("123456789", "body");


SendNotificationInterface(notificationService1);



// Some code here

void SendNotificationInterface(INotificationService notificationService)
{
    notificationService.SendNotifications();
}


// --------------------------------

NotificationServiceAbstract notificationService11 = new EmailNotificationServiceAbstract("aa@a.a", "subject", "body", "message");
NotificationServiceAbstract notificationService22 = new SmsNotificationServiceAbstract("123456789", "body");


SendNotificationAbstractClass(notificationService11);



// Some code here

void SendNotificationAbstractClass(NotificationServiceAbstract notificationService)
{
    notificationService.SendNotifications();
    notificationService.PrepareNotification();
    notificationService.AccomplishNotification();
}