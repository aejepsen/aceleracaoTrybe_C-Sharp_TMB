using System;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;

namespace delivery_server;

public class ProcessOrders
{
    public ArrayList OrdersList;
    public int TimeToCheck;

    public ProcessOrders()
    {   
        throw new NotImplementedException();
        this.DeliveryReadyOrders(TimeSpan.FromSeconds(TimeToCheck));    
    }

    public void AddOrder(Item item, int quantity)
    {
        throw new NotImplementedException();
    }

    async Task DeliveryReadyOrders(TimeSpan timeSpan)
    {
        var periodicTimer = new PeriodicTimer(timeSpan);
        while (await periodicTimer.WaitForNextTickAsync())
        {
            throw new NotImplementedException();
        }
    }

}
