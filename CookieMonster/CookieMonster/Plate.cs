using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CookieMonster
{
    public class Plate
    {
        public static int Radius = 40; //the radius of every plate (that is why it is static)
        public string Id { get; private set; }
        public int NrOfCookies { get; private set; }
        public int X { get; private set; }
        public int Y { get; private set; }
        public List<Plate> Neighbors { get; private set; }

        public Plate(string id, int x, int y, int initialNrOfCookies)
        {
            Id = id;
            NrOfCookies = initialNrOfCookies;
            X = x;
            Y = y;
            Neighbors = new List<Plate>();
        }

        /// <summary>
        /// adds a cookie to the plate.
        /// If the number of cookies becomes 4, Cookie Monster eats them all, so no cookies are left.
        /// </summary>
        public void AddCookie()
        {
            NrOfCookies++;
            if (NrOfCookies == 4)
                NrOfCookies = 0;
        }

        /// <summary>
        /// If this plate has a neighbor with identity id,
        /// then that neighbor is returned,
        /// else null is returned
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Plate GetNeighbor(string id)
        {
            foreach (Plate p in Neighbors)
                if (p.Id == id)
                    return p;
            return null;
        }

        /// <summary>
        /// adds plate p to its neighbors
        /// </summary>
        /// <param name="p"></param>
        public void AddNeighbor(Plate p)
        {
            Neighbors.Add(p);
        }

        /// <summary>
        /// checks if the point (xmouse,ymouse) is on this plate.
        /// In other words: it checks if the distance between the center of this plate and the point (xmouse,ymouse)
        /// is less than or equal to the radius.
        /// </summary>
        /// <param name="xmouse"></param>
        /// <param name="ymouse"></param>
        /// <returns></returns>
        public bool ContainsPoint(int xmouse, int ymouse)
        {
            return (X - xmouse) * (X - xmouse) + (Y - ymouse) * (Y - ymouse) <= Radius * Radius;
        }
    }
}
