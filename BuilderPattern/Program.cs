public interface Builder
{
    void reset();
    void setSeats(int num);
    void setEngine(string engine);
    void setTripComputer();
    void setGPS();
}

public class Director
{
    public void makeSUV(Builder builder)
    {
        builder.reset();
        builder.setEngine("SUV Engine");
        builder.setGPS();
        builder.setSeats(5);
        builder.setTripComputer();
    }

    public void makeSportsCar(Builder builder)
    {
        builder.reset();
        builder.setEngine("Sports Car Engine");
        builder.setSeats(2);
    }
}

public class CarBuilder : Builder
{
    private Car car;

    public CarBuilder()
    {
        this.reset();
    }

    public void reset()
    {
        this.car = new Car();
    }

    public void setEngine(string engine)
    {
        this.car.Engine = engine;
    }

    public void setGPS()
    {
        this.car.GPS = true;
    }

    public void setSeats(int num)
    {
        this.car.Seats = num;
    }

    public void setTripComputer()
    {
        this.car.TripComputer = true;
    }

    public Car getResult()
    {
        return this.car;
    }
}

public class CarManualBuilder : Builder
{
    private Manual manual;

    public CarManualBuilder()
    {
        this.reset();
    }

    public void reset()
    {
        this.manual = new Manual();
    }

    public void setEngine(string engine)
    {
        this.manual.EngineInfo = engine;
    }

    public void setGPS()
    {
        this.manual.GPSInfo = "Manual GPS Info";
    }

    public void setSeats(int num)
    {
        this.manual.SeatsInfo = $"Manual seats info: {num} seats";
    }

    public void setTripComputer()
    {
        this.manual.TripComputerInfo = "Manual Trip Computer Info";
    }

    public Manual getResult()
    {
        return this.manual;
    }
}

public class Car
{
    public string Engine { get; set; }
    public bool GPS { get; set; }
    public int Seats { get; set; }
    public bool TripComputer { get; set; }
}

public class Manual
{
    public string EngineInfo { get; set; }
    public string GPSInfo { get; set; }
    public string SeatsInfo { get; set; }
    public string TripComputerInfo { get; set; }
}

class Program
{
    static void Main(string[] args)
    {

        Director director= new Director();
        CarBuilder builder= new CarBuilder();
        director.makeSportsCar(builder);
        Car car = builder.getResult();
        Console.WriteLine($"Car engine-{car.Engine}\nCar Seats-{car.Seats}\nTrip Computer-{car.TripComputer}");

    }
}
