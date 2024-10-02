using System;

class RemoteControlCar
{
    // TODO: define the constructor for the 'RemoteControlCar' class
    private int speed;
    private int batteryDrain;
    private int metersDriven = 0;
    private int battery = 100;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    public bool BatteryDrained() => battery > 0 && battery >= batteryDrain ? false : true;

    public int DistanceDriven() => metersDriven;

    public void Drive()
    {
        if(battery > 0 && battery >= batteryDrain)
        {
            this.metersDriven += speed;
            this.battery -= batteryDrain;
        }
    }

    public static RemoteControlCar Nitro()
    {
        throw new NotImplementedException("Please implement the (static) RemoteControlCar.Nitro() method");
    }
}

class RaceTrack
{
    // TODO: define the constructor for the 'RaceTrack' class
    private int distance;

    public RaceTrack(int distance)
    {
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        throw new NotImplementedException("Please implement the RaceTrack.TryFinishTrack() method");
    }
}