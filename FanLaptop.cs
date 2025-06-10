using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_103022300137
{
    public class FanLaptop
    {
        enum state
        {
            QUIET,
            BALANCED,
            TURBO
        }

        private state fanState;
        public FanLaptop()
        {
            fanState = state.TURBO;
        }
        public void SetFanState(string mode)
        {
            switch (mode.ToUpper())
            {
                case "QUIET":
                    if (fanState == state.TURBO)
                    {
                        Console.WriteLine("Fan TURBO berubah menjadi QUIET");
                    } 
                    else if (fanState == state.BALANCED)
                    {
                        Console.WriteLine("Fan BALANCED berubah menjadi QUIET");
                    }
                    fanState = state.QUIET;
                    break;
                case "BALANCED":
                    if (fanState == state.TURBO)
                    {
                        Console.WriteLine("Fan TURBO berubah menjadi BALANCED");
                    }
                    else if (fanState == state.QUIET)
                    {
                        Console.WriteLine("Fan QUIET berubah menjadi BALANCED");
                    }
                    fanState = state.BALANCED;
                    break;
                case "TURBO":
                    if (fanState == state.QUIET)
                    {
                        Console.WriteLine("Fan QUIET berubah menjadi TURBO");
                    }
                    else if (fanState == state.BALANCED)
                    {
                        Console.WriteLine("Fan BALANCED berubah menjadi TURBO");
                    }
                    fanState = state.TURBO;
                    break;
                default:
                    throw new ArgumentException("Mode tidak valid. Gunakan 'QUIET', 'BALANCED', atau 'TURBO'.");
            }
        }

        public string GetFanState()
        {
            return fanState.ToString();
        }
    }
}
