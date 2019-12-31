using System;

namespace _04._Songs
{
    class Program
    {
        static void Main()
        {
            int numberOfSongs = int.Parse(Console.ReadLine());
            Song[] songs = new Song[numberOfSongs];
            
            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] temp = Console.ReadLine().Split('_');

                var song = new Song();
                song.TypeList = temp[0];
                song.Name = temp[1];
                song.Time = temp[2];

                songs[i] = song;
            }

            string search = Console.ReadLine();

            for (int i = 0; i < songs.Length; i++)
            {
                if (search == songs[i].TypeList && search != "all")
                {
                    Console.WriteLine(songs[i].Name);
                }
                else if (search == "all")
                {
                    Console.WriteLine(songs[i].Name);
                }
            }
        }
    }
    
    public class Song
    {
        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }
    }

}
