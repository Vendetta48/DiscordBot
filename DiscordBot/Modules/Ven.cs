using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Discord;

namespace MemeballBot.Modules
{
   public class Ven : ModuleBase<SocketCommandContext>
    {
        Random rand = new Random();

        string[] venPlays;

        [Command("Ven")]
        public async Task VenAsync()
        {
            venPlays = System.IO.File.ReadAllLines("Memes/ven/ven.txt");
            System.Console.WriteLine("Contents of ven.txt = ");
            foreach (string venPlays in venPlays)
            {
                Console.WriteLine(venPlays);
            };
            int randomVenPlay = rand.Next(venPlays.Length);
            string venPlaysToPost = venPlays[randomVenPlay];
            await ReplyAsync(venPlaysToPost);

        }
       
    }
}
