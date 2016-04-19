using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POA_GRA_GASNIER_HABIB
{
    class DrawCSV
    {
        private int idElement;
        private double valueRed;
        private double valueGreen;
        private double valueBlue;
        private int ranking;

        public DrawCSV(int IdElement, double ValueRed, double ValueGreen, double ValueBlue, int Ranking)
        {
            this.idElement = IdElement;
            this.valueRed = ValueRed;
            this.valueGreen = ValueGreen;
            this.valueBlue = ValueBlue;
        }


        public int IdElement
        { get { return idElement; } }

        public double ValueRed
        { get { return ValueRed; } }

        public double ValueGreen
        { get { return ValueRed; } }

        public double ValueBlue
        { get { return ValueRed; } }

        public int Ranking
        { get { return Ranking; } }

    }
}
