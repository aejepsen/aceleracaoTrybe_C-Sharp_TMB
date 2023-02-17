struct Schedule
{
    public int Day;
    public int Hour;
    public int Minute;

    public int Second;

    public Schedule(int day, int hour, int minute, int second)
    {
        this.Day = day;
        this.Hour = hour % 24;
        this.Minute = minute % 60;
        this.Second = second % 60;
    }

    public string getSchedule()
    {
        return this.Day + " " + this.Hour + ":" + this.Minute + ":" + this.Second;
    }

}

class Program
{
    static void Main(string[] args)
    {
        Schedule schedule = new Schedule(10, 250, 610, 610);
        Console.WriteLine(schedule.getSchedule());

        Schedule schedule2 = schedule;
        Console.WriteLine(schedule2.getSchedule());
    }
}
