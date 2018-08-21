using System;
using System.Threading;
using System.Threading.Tasks;
using Unosquare.RaspberryIO;
using Unosquare.RaspberryIO.Gpio;

namespace Alarm
{
    class Program
    {

        static void Main(string[] args) => MainAsync(args).GetAwaiter().GetResult();

        static async Task MainAsync(string[] args)
        {
            Console.WriteLine("Starting Alarm ...");
            Console.WriteLine("Waitting sensors to calibrate ...");
            //siren need 2 pins. 1st pin for the power/stop and the second for start
            var siren = new Siren()
            {
                SirenPowerGpio = Pi.Gpio[P1.Gpio23],
                SirenStartGpio = Pi.Gpio[P1.Gpio24]
            };
            //PIR sensors
            //PIR1
            var pir1 = new PirSensor(false)
            {
                NameLocation = "SaloniOnRasp",
                Data = Pi.Gpio[P1.Gpio25]
            };
            pir1.Data.PinMode = GpioPinDriveMode.Input;

            pir1.Attach(siren);
            pir1.Status = pir1.Data.Read();

            //Thread.Sleep(3000);
            //Console.WriteLine("Ready!");
            ////siren test
            //Siren.alarm(3000);
            //Console.Clear();
            //string sensorTriggered = "";
            //bool iterationloop = true;
            //bool sirenStatus = false;
            ////Arm infinite loop
            //while (true)
            //{
            //    //initialize a thread for arm loop
            //    var passwordInput = new Thread(async () => iterationloop = await User.ArmDesarm());
            //    passwordInput.IsBackground = true;
            //    passwordInput.Start();
            //    if (iterationloop)
            //    {
            //        Console.Clear();
            //        Console.WriteLine("Give pass to arm!");
            //        Thread.Sleep(1000);
            //        continue;
            //    }
            //    else
            //    {
            //        Console.Clear();
            //        Console.WriteLine("Home locking down in few seconds");
            //        //make a noice with siren here
            //        Siren.alarm(3000);
            //        //Sleep for a while to give user time to get out
            //        Thread.Sleep(30000);
            //        Console.Clear();
            //        Console.WriteLine("Armed");
            //        iterationloop = !iterationloop;
            //        //initialize a thread for desarm loop
            //        passwordInput = new Thread(async () => iterationloop = await User.ArmDesarm());
            //        passwordInput.IsBackground = true;
            //        passwordInput.Start();
            //    }
            //    do
            //    {
            //        // Here we check the sensors every few seconds. This is armed mode = on
            //        if (pir1.Data.Read() && sirenStatus == false)
            //        {
            //            sirenStatus = true;
            //            sensorTriggered = pir1.NameLocation;
            //        }

            //        //If any sensor enabled will make siren alarm for a while
            //        if (sirenStatus)
            //        {
            //            //alarm for 10 mins
            //            var sirenAlarm = new Thread(() => Siren.alarm(600000));
            //            sirenAlarm.IsBackground = true;
            //            sirenAlarm.Start();
            //            var result = await ApiComm.GetResponseAsync("http://localhost:50122/api/SaveRecords/Alarm/-/"+ sensorTriggered);
            //            if (result)
            //            {
            //               Console.WriteLine("Record of the alarm success!");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Record of the alarm failed!");
            //            }
                       
            //        }
            //        // .. and be sure to Yield/Sleep to prevent 100% CPU usage.

            //        Thread.Sleep(0);
            //    } while (iterationloop);

            //    iterationloop = !iterationloop;
            }
        }


    }
}
