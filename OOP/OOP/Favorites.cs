using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Favorites
    {
        public string anime, hobby;
        public int watched, read;

        public Favorites(string anime, string hobby, int watched, int read)
        {
            this.anime = anime;
            this.hobby = hobby;
            this.watched = watched;
            this.read = read;

            Console.WriteLine("Favorite anime of all time: "+anime);
            Console.WriteLine("His hobby is: "+hobby);
            Console.WriteLine("He watched " + watched + " Animes");
            Console.WriteLine("He read " + read + " Animes");
            Console.WriteLine();
    


        }
    }
}
