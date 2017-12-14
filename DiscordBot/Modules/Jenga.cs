using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Discord;


namespace MemeballBot.Modules
{
    public class Jenga : ModuleBase<SocketCommandContext>
    {
        Random rand = new Random();

        string[] jenga;

        [Command("jenga")]
        public async Task JengaAsync()
        {
            jenga = System.IO.File.ReadAllLines("Memes/jenga/jenga.txt");
            System.Console.WriteLine("Contents of lb.array.txt = ");
            foreach (string jenga in jenga)
            {
                Console.WriteLine(jenga);
            };
            int randomJengaPost = rand.Next(jenga.Length);
            string jengaPostsToPost = jenga[randomJengaPost];
            await ReplyAsync(jengaPostsToPost);
        }




    }

}
