class RemoteControlCar
{
    private int _batteryPercentage;
    private int _distanceDriven;
    private int _speed;
    private int _batteryDrain;
    
    public RemoteControlCar(int speed, int batteryDrain) {
        _batteryPercentage = 100;
        _distanceDriven = 0;
        _speed = speed;
        _batteryDrain = batteryDrain;
    }
    
    public bool BatteryDrained()
    {
        return _batteryPercentage < _batteryDrain;
    }

    public int DistanceDriven()
    {
        return _distanceDriven;
    }

    public void Drive()
    {
        if (!BatteryDrained()) {
            _batteryPercentage -= _batteryDrain;
            _distanceDriven += _speed;
        }
    }

    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);
}

class RaceTrack
{
    private int _trackLength;
    public RaceTrack(int trackLength){
        _trackLength = trackLength;
    }
    
    public bool TryFinishTrack(RemoteControlCar car)
    {
        var distanceTraveledBeforeTryingOutTheRaceTrack = car.DistanceDriven();
        var distanceTraveled = 0;
        
        while (distanceTraveled < _trackLength) {
            if (car.BatteryDrained()) {
                return false;
            }
            
            car.Drive();
            distanceTraveled = car.DistanceDriven() - distanceTraveledBeforeTryingOutTheRaceTrack;
        }

        return true;
    }
}
