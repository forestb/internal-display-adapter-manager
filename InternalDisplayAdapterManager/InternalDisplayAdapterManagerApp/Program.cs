using DeviceHelperLib;
using System;
using System.Threading.Tasks;

namespace InternalDisplayAdapterManagerApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Device Manager -> "Class Guid" property
            Guid deviceGuid = new Guid("{4d36e968-e325-11ce-bfc1-08002be10318}");

            // Device Manager -> "Device instance path" property
            string instancePath = @"PCI\VEN_8086&DEV_9BC4&SUBSYS_200A1A58&REV_05\3&11583659&0&10";

            await DisableDevice (deviceGuid, instancePath);
            await Wait();
            await EnableDevice (deviceGuid, instancePath);
        }

        private static async Task DisableDevice(Guid deviceGuid, string instancePath)
        {
            Console.WriteLine("Disabling device...");
            DeviceHelper.SetDeviceEnabled(deviceGuid, instancePath, false);
            Console.WriteLine("Complete.");
        }

        private static async Task Wait()
        {
            int secondsToWait = 5;
            Console.WriteLine($"Waiting {secondsToWait} seconds...");

            for (int i = 0; i < secondsToWait; i++)
            {
                await Task.Delay(1000);
                Console.WriteLine($"{secondsToWait - i}");
            }
        }

        private static async Task EnableDevice(Guid deviceGuid, string instancePath)
        {
            Console.WriteLine("Re-enabling device...");
            DeviceHelper.SetDeviceEnabled(deviceGuid, instancePath, true);
            Console.WriteLine("Complete.");
        }
    }
}
