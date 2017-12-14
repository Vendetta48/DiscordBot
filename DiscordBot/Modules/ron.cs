using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MemeballBot.Modules
{
    public class Ron : ModuleBase<SocketCommandContext>
    {
        Random rand = new Random();

        string[] ronImages;

        [Command("ron")]
        public async Task RonAsync()
        {
            ronImages = System.IO.File.ReadAllLines("Memes/ronimages/ronImages.txt");
            System.Console.WriteLine("Contents of ronImages.txt = ");
            foreach (string ronImages in ronImages)
            {
                Console.WriteLine(ronImages);
            };

            int randomRonImage = rand.Next(ronImages.Length);
            string ronImagesToPost = ronImages[randomRonImage];
            await ReplyAsync(ronImagesToPost);
        }
            
    }
}
