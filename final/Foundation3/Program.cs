using System;

class Address {
    private string street;
    private string city;
    private string state;
    private string zipCode;

    public Address(string street, string city, string state, string zipCode) {
        this.street = street;
        this.city = city;
        this.state = state;
        this.zipCode = zipCode;
    }

    public override string ToString() {
        return $"{street}, {city}, {state} {zipCode}";
    }
}

class Event {
    private string title;
    private string description;
    private DateTime date;
    private TimeSpan time;
    private Address address;

    public Event(string title, string description, DateTime date, TimeSpan time, Address address) {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public virtual string GetStandardDetails() {
        return $"Event: {title}\nDescription: {description}\nDate: {date.ToShortDateString()}\nTime: {time.ToString()}\nAddress: {address.ToString()}";
    }

    public virtual string GetFullDetails() {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription() {
        return $"Type: Generic\nEvent: {title}\nDate: {date.ToShortDateString()}";
    }
}

class Lecture : Event {
    private string speaker;
    private int capacity;

    public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity) : base(title, description, date, time, address) {
        this.speaker = speaker;
        this.capacity = capacity;
    }

    public override string GetFullDetails() {
        return $"{GetStandardDetails()}\nType: Lecture\nSpeaker: {speaker}\nCapacity: {capacity}";
    }

    public override string GetShortDescription() {
        return $"Type: Lecture\nEvent: {title}\nDate: {date.ToShortDateString()}";
    }
}

class Reception : Event {
    private string rsvpEmail;

    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail) : base(title, description, date, time, address) {
        this.rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails() {
        return $"{GetStandardDetails()}\nType: Reception\nRSVP Email: {rsvpEmail}";
    }

    public override string GetShortDescription() {
        return $"Type: Reception\nEvent: {title}\nDate: {date.ToShortDateString()}";
    }
}

class OutdoorGathering : Event {
    private string weatherForecast;

    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weatherForecast) : base(title, description, date, time, address) {
        this.weatherForecast = weatherForecast;
    }

    public override string GetFullDetails() {
        return $"{GetStandardDetails()}\nType: Outdoor Gathering\nWeather Forecast: {weatherForecast}";
    }

    public override string GetShortDescription() {
        return $"Type: Outdoor Gathering\nEvent: {title}\nDate: {date.ToShortDateString()}";
    }
}

class Program {
    static void Main(string[] args) {
        Address address1 = new Address("400 Oak St", "Mesa", "AZ", "12345");
        Address address2 = new Address("509 Main St", "Kansas City", "NY", "67890");
        Address address3 = new Address("333", "Lakeshore Dr.", "FL", "54321");

        Event genericEvent = new Event("Generic Event", "This is a generic event", new DateTime(2023, 4, 1), new TimeSpan(19, 0, 0), address1);
        Lecture lecture = new Lecture("Lecture on Mental Health", "A lecture on mental health", new DateTime(2023, 5, 1), new TimeSpan(13, 0, 0), address2, "Dr. John Doe", 50);
        Reception reception = new Reception("Networking Reception", "A networking reception for medical professionals", new DateTime(2023, 6, 1), new TimeSpan(18, 0, 0), address3, "rsvp@example.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Picnic in the Park", "A picnic in the park", new DateTime(2023, 7, 1), new TimeSpan(11, 0, 0), address1, "Sunny");

        Console.WriteLine(genericEvent.GetStandardDetails());
        Console.WriteLine(genericEvent.GetFullDetails());
        Console.WriteLine(genericEvent.GetShortDescription());

        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(lecture.GetShortDescription());

        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(reception.GetShortDescription());

        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine(outdoorGathering.GetShortDescription());
    }
}
