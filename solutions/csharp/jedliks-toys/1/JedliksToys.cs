class RemoteControlCar
{
    private int _distanceDrivenInMeters = 0;
    private int _batteryPercentage = 100;
    
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {_distanceDrivenInMeters} meters";
    }

    public string BatteryDisplay()
    {
        if (_batteryPercentage == 0) {
            return "Battery empty";
        }
        
        return $"Battery at {_batteryPercentage}%";
    }

    public void Drive()
    {
        if (_batteryPercentage > 0) {
            _distanceDrivenInMeters += 20;
            _batteryPercentage--;
        }
    }
}
