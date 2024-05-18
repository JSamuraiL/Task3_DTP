// See https://aka.ms/new-console-template for more information
using Task_3;

Console.WriteLine("Hello, World!");
try { 
var TransportList = new DTP
{
    new Transport{Car_number = "3G4KK", DTPParticipant = true},
    new Transport{Car_number = "8F3KB", DTPParticipant = true},
    new Transport{Car_number = "7J9LM", DTPParticipant = false},
    new Transport{Car_number = "3C0JA", DTPParticipant = true},
    new Transport{Car_number = "0Q9KS", DTPParticipant = false}
};

foreach (Transport transport in TransportList) 
    { 
        if (transport.Car_number == null || transport.Car_number.Length == 0) { throw new ArgumentNullException(nameof(transport.Car_number)); }
    };

TransportList.CollectParticipant();
}
catch (ArgumentNullException e) {Console.WriteLine($"{e.Message}") ;}