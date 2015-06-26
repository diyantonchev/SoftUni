using System;
using System.Threading;

public class AsyncTimer
{
    private int ticks;
    private int timeInterval;

    public AsyncTimer(Action<int> action, int ticks, int timeInteval)
    {
        this.Action = action;
        this.Ticks = ticks;
        this.TimeInterval = timeInterval;
    }

    public Action<int> Action { get; private set; }

    public int Ticks
    {
        get { return this.ticks;}

        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("value", "The method should be executed at least once.");
            }
            this.ticks = value;
        }
    }

    public int TimeInterval
    {
        get { return this.timeInterval; }

        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Time interval cannot be negative","value");
            }
            this.timeInterval = value;
        }
    }

    public void Run()
    {
        var paralelThread = new Thread(ExecuteAction);
        paralelThread.Start();
    }

    private void ExecuteAction()
    {
        for (int i = 0; i < this.Ticks; i++)
        {
            Thread.Sleep(this.TimeInterval);
            
            if (this.Action != null)
            {
                this.Action(i);
            }
        }
    }

}