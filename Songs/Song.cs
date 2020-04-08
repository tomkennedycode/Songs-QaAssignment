using System;
using System.Collections.Generic;
using System.Text;

namespace Songs
{
    public class Song
    {
        private string Name;
        private string Artist;
        private int CopiesSold;

        public Song(string Name, string Artist, int CopiesSold)
        {
            this.Name = Name;
            this.Artist = Artist;
            this.CopiesSold = CopiesSold;
        }

        public string GetArtist()
        {
            return Artist;
        }

        public string GetDetails()
        {
            return $"Name: {Name} Artist: {Artist} Copies Sold: {CopiesSold}";
        }

        public string GetCertification()
        {
            if (CopiesSold < 200000)
            {
                return null;
            } else if (CopiesSold < 400000)
            {
                return "Silver";
            } else if (CopiesSold < 600000)
            {
                return "Gold";
            }

            return "Platinum";
        }
    }
}
