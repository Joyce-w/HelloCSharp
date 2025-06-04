

/* SINGLETON PATTERN
 * Class should only have one instance
 * Provide a point of access 
 * useful for mangaing shared resources
 */

public class Database
{
    //Private variable that holds the instance of the database object
    private static Database _instance;

    //private constructor that write connection when called 
    private Database()
    {
        Console.WriteLine("Database connection established");
    }
    //Public method that assigns the private variable to a new instance of the db obj and returns that instance to the code that gets called
    public static Database GetInstance()
    {
        if(_instance === null)
        {
            _instance = new Database();
        }
        return _instance
    }
}


/* FACTORY PATTERN
 * Request code does not directly create objects
 * Factory method or class handles requests
 * factory takes input / object
 * allows for code flexibility */

//public interface
public interface INotification
{
    //interface includes method which takes parameter
    void Notification(string message);
}
 

//create 2 derived class that inherits interface
public class EmailNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine("Sending Email: " + message);
}

    public class SMSNotification: INotification
    {
        public void Send(string message) {
            Console.WriteLine("Sending SMS: " + message);
    }

//create new class that handles email and sms notification objects
public class NotificationFactory
        {
            //uses INotification as type, takes input 'channel' to tell factory what to create
            public INotification CreateNotificationString(string channel)
            {
                if(channel == "Email")
                {
                    return new EmailNotification();
                } else if (channel == "SMS")
                {
                    return new SMSNotification();
                }
            }
        }


/*OBSERVER PATTERN
 * allow one object to notifices other object regarding dynamic changes
 * useful for event notification 
 */

         
     // create public interface 
    public interface IObserver
        {
            //method sets temperature. sets how things get updates
            void Update(float temperature)
 
     }

        //create weather station class that acts as subject. manages IObserver and responsible for all new changes
        public class WeatherStation
        {
            private List<WeatherStation> observers = new List<IObserver>();
            private float temperature;

            public void RegisterObserver(IObserver observer)
            {
                observers.Add(observer);
            }

            RemoveObserver(IObserver observer)
            {
                observers.Remove(observer);
            }
            public void NotifyObserservers()
            {
                foreach (var observer in observers) {
                    observer.Update(temperature);
            }
        }

            public void SetTemperature(float newTemperature)
            {
                temperature = newTemperature;
                NotifyObserservers();
            }

        //Create derived class
        public class PhoneDisplay : IObserver
            {
                public void Update(float temperature)
                {
                    Console.WriteLine("Phone display: Temperature updated to " + temperature + " degrees.");
                }
            }

            // Using the observer in the program
        public class Program
            {
                public static void Main(string[] args)
                {
                    WeatherStation weatherstation = new WeatherStation();
                    PhoneDisplay phoneDisplay = new PhoneDisplay();

                    weatherstation.RegisterObserver(phoneDisplay);
                    weatherStation.RegisterObserver(weatherstation);

                    weatherstation.SetTemperature(25.0f);
                }
            }