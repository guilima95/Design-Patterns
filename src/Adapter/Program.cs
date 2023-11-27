using System;

namespace Adapter;

//reference: https://www.dofactory.com/net/adapter-design-pattern


internal class Program
{
    static void Main(string[] args)
    {
        var addClientLogDefault = new ClientService(new Logger());
        addClientLogDefault.AddClient();

        var addClientLogCustom = new ClientService(new LogAdapter(new LoggerAlternative()));
        addClientLogCustom.AddClient();
    }
}
