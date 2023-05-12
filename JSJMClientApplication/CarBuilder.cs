using JSJMClientApplication.Interface;

namespace JSJMClientApplication;

public class CarBuilder : ICarBuilder
{
    private GetInputClass _getInputClass = new GetInputClass();
    
    public string SetCarModel()
    {
        string carModel = _getInputClass.GetString("Please enter the car model:");
        return carModel;
    }

    public string SetCarBrand()
    {
        string carBrand = _getInputClass.GetString("Please enter the car brand:");
        return carBrand;
    }

    public int SetYearModel()
    {
        int yearModel = _getInputClass.GetInt("Please enter the year model:");
        return yearModel;
    }

    public int SetMileage()
    {
        int mileage = _getInputClass.GetInt("Please enter the mileage:");
        return mileage;
    }

    public string SetDescription()
    {
        string description = _getInputClass.GetString("Please enter the car description:");
        return description;
    }

    public TransmissionType SetTransmissionType()
    {
        int transmissionInput = _getInputClass.GetInt("Please enter the transmission type (0 for manual, 1 for automatic):");
        return (TransmissionType)transmissionInput;
    }

    public FuelType SetFuelType()
    {
        int fuelInput = _getInputClass.GetInt("Please enter the fuel type (0 for Gas, 1 for Diesel, 2 for Hybrid, 3 for Electric):");
        return (FuelType)fuelInput;
    }

    public int SetPrice()
    {
        int price = _getInputClass.GetInt("Please enter the car price:");
        return price;
    }

    public Car CreateCar()
    {
        string carModel = SetCarModel();
        string carBrand = SetCarBrand();
        int yearModel = SetYearModel();
        int mileage = SetMileage();
        string description = SetDescription();
        TransmissionType transmission = SetTransmissionType();
        FuelType fuel = SetFuelType();
        int price = SetPrice();

        Car car = new Car();
        car.CarModel = carModel;
        car.CarBrand = carBrand;
        car.YearModel = yearModel;
        car.Mileage = mileage;
        car.Description = description;
        car.Transmission = transmission;
        car.Fuel = fuel;
        car.Price = price;

        return car;
    }
}