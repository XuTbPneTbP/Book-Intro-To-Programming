using System;
using System.Diagnostics;
using System.Net;

class SystenNetWebclient
{
    static void Main()
    {
        string url = "http://imgs.tuts.dragoart.com/how-to-draw-a-spaceship_1_000000003677_5.jpg";
        string rocket = "rocket-pic.jpg";
        Console.WriteLine("Download {0}.....",url);
        WebClient lKikov = new WebClient();
        lKikov.DownloadFile(url, rocket);

        Process.Start(rocket);
    }
}

