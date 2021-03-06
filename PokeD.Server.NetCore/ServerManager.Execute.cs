﻿using System;

using Open.Nat;

using PokeD.Server.Services;

namespace PokeD.Server.NetCore
{
    public partial class ServerManager
    {
        private bool ExecuteCommand(string message)
        {
            var command = message.Remove(0, 1).ToLower();
            message = message.Remove(0, 1);

            if (command.StartsWith("stop"))
            {
                Program.LastRunTime = DateTime.UtcNow;
                Stop();
                NatDiscoverer.ReleaseAll();

                Console.WriteLine();
                Console.WriteLine("Stopped the server. Press any key to continue...");
                Console.ReadKey();
            }

            else if (command.StartsWith("clear"))
            {
                Console.Clear();
            }

            else
                return Server.Services.GetService<CommandManagerService>()?.ExecuteServerCommand(message) == true;

            return true;
        }
    }
}