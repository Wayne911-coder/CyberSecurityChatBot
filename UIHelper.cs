using System;

class UIHelper
{
    public static void ShowLogo()
    {
        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine(@"
   _____       _               _____                      _ _         ____        _   
  / ____|     | |             / ____|                    (_) |       |  _ \      | |  
 | |     _   _| |__   ___ _ __| (___   ___  ___ _   _ _ __ _| |_ _   _| |_) | ___ | |_ 
 | |    | | | | '_ \ / _ \ '__|\___ \ / _ \/ __| | | | '__| | __| | | |  _ < / _ \| __|
 | |____| |_| | |_) |  __/ |   ____) |  __/ (__| |_| | |  | | |_| |_| | |_) | (_) | |_ 
  \_____|\__,_|_.__/ \___|_|  |_____/ \___|\___|\__,_|_|  |_|\__|\__, |____/ \___/ \__|
                                                                __/ |                 
                                                               |___/                  

                        CyberSecurityBot
");

        Console.ResetColor();
    }
}
