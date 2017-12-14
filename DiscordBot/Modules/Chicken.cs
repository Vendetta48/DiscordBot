using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Discord;

namespace MemeballBot.Modules
{
    public class Chicken : ModuleBase<SocketCommandContext>
    {
        Random rand = new Random();

        string[] chicken;

        [Command("chicken")]
        public async Task ChickenAsync()
        {
            chicken = System.IO.File.ReadAllLines("Memes/chicken/chicken.txt");
            System.Console.WriteLine("Contents of chicken.txt = ");
            foreach (string chicken in chicken)
            {
                Console.WriteLine(chicken);
            };
            int randomChickenPost = rand.Next(chicken.Length);
            string chickenPostsToPost = chicken[randomChickenPost];
            await ReplyAsync(chickenPostsToPost);
        }




    }

}

