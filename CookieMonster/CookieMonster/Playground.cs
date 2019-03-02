using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace CookieMonster
{
    public class Playground
    {
        private List<Plate> thePlates;

        public int NrOfMoves { get; private set; }
        public void IncrementNrOfMoves() { NrOfMoves++; }

        public Playground()
        {
            NrOfMoves = 0;
            thePlates = new List<Plate>();
        }

        /// <summary>
        /// If this playground has a plate with identity id,
        /// then that plate is returned,
        /// else null is returned
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Plate GetPlate(string id)
        {
            foreach (Plate p in thePlates)
                if (p.Id == id)
                    return p;
            return null;
        }

        /// <summary>
        /// If this playground has a plate that contains the point (xmouse, ymouse),
        /// then that plate is returned,
        /// else null is returned
        /// </summary>
        /// <param name="xmouse"></param>
        /// <param name="ymouse"></param>
        /// <returns></returns>
        public Plate GetPlate(int xmouse, int ymouse)
        {
            foreach (Plate plate in thePlates)
                if (plate.ContainsPoint(xmouse, ymouse))
                    return plate;
            return null;
        }

        /// <summary>
        /// If this playground does not have a plate with identity id,
        /// then a new plate is created, added to the list thePlates, and the returnvalue is true,
        /// else the returnvalue is false. 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="initialNrOfCookies"></param>
        /// <returns></returns>
        public bool AddPlate(string id, int x, int y, int initialNrOfCookies)
        {
            if (GetPlate(id) == null)
            {
                Plate temp = new Plate(id, x, y, initialNrOfCookies);
                thePlates.Add(temp);
                return true;
            }
            return false;
        }

        /// <summary>
        /// If this playground has a plate with identity id1 and also a plate with identity id2,
        /// then the id2-plate is added as a neighbor to the id1-plate, and also 
        ///      the id1-plate is added as a neighbor to the id2-plate
        ///      and the returnvalue is true,
        /// else the returnvalue is false. 
        /// </summary>
        /// <param name="id1"></param>
        /// <param name="id2"></param>
        /// <returns></returns>
        public bool AddConnection(string id1, string id2)
        {
            Plate plate1 = GetPlate(id1);
            Plate plate2 = GetPlate(id2);
            if (plate1 != null && plate2 != null)
            {
                plate1.AddNeighbor(plate2);
                plate2.AddNeighbor(plate1);
                return true;
            }
            return false;
        }

        /// <summary>
        /// constructs the playground with the information in the file
        /// </summary>
        /// <param name="filename"></param>
        public void StartLevelFromFile(string filename)
        {
            thePlates.Clear();
            NrOfMoves = 0;
            using (StreamReader sr = new StreamReader(new FileStream(filename, FileMode.Open, FileAccess.Read)))
            {
                string s = sr.ReadLine();
                while ((s = sr.ReadLine()) != "edges")
                {
                    string[] tokens = s.Split();
                    AddPlate(
                        tokens[0],
                        Convert.ToInt32(tokens[1]),
                        Convert.ToInt32(tokens[2]),
                        Convert.ToInt32(tokens[3]));
                }
                while ((s = sr.ReadLine()) != "end")
                {
                    string[] ids = s.Split();
                    AddConnection(ids[0], ids[1]);
                }
            }
        }

        /// <summary>
        /// All plates are drawn on the graphics gr, using the images in the Imagelist il
        /// (il.Images[0] for the image with 0 cookies; il.Images[1] for the image with 1 cookie, etc.)
        /// Also write the Id of the plate on the graphics gr.
        /// </summary>
        /// <param name="gr"></param>
        /// <param name="il"></param>
        public void DrawAllPlates(Graphics gr, ImageList il)
        {
            foreach (Plate p in thePlates)
            {
                gr.DrawImage(il.Images[p.NrOfCookies], p.X - Plate.Radius, p.Y - Plate.Radius);
                gr.DrawString(p.Id, new Font(FontFamily.GenericSerif, 20), Brushes.Black, p.X, p.Y);
            }
        }

        /// <summary>
        /// All lines (connections, edges) are drawn on the graphics gr
        /// </summary>
        /// <param name="gr"></param>
        public void DrawAllLines(Graphics gr)
        {
            foreach (Plate plate in thePlates)
            {
                foreach (Plate neighbor in plate.Neighbors)
                {
                    gr.DrawLine(Pens.Black, plate.X, plate.Y, neighbor.X, neighbor.Y);
                }
            }
        }

        public bool CheckWin()
        {
            int count = 0;
            foreach (Plate item in thePlates)
            {
                if (item.NrOfCookies == 3)
                    count++;
            }
            if (thePlates.Count == count)
                return true;
            return false;
        }
    }
}
