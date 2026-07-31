using System;
using System.Collections.Generic;
using System.Text;

namespace Sudoku
{
    internal class SudokuCellule
    {
        private char _value = ISudokuModel.VIDE;
        private List<Zone> zoneList = new List<Zone>();

        public char Value
        {
            get
            {
                return this._value;
            }
            set
            {
                if (!Lock)
                {
                    this._value = value;
                }
            }
        }

        public bool Lock
        {
            get;
            set
            {
                field = Value == ISudokuModel.VIDE & value;
            }
        } = false;

        public void AddZone(Zone zone)
        {
            zoneList.Add(zone);
        }

        void testPoubelle()
        {
            Zone z = new Zone("toto");
            zoneList.Add(z);
            if (zoneList.Count > 0) { }
            foreach (Zone zo in zoneList)
            {
                zo.Contains(2);
            }
        }
    }
}
