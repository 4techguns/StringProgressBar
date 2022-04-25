using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProgressBar
{
    public class ProgressInfo
    {
        public string ProgressString { get; init; }
        public double Percentage { get; init; }

        /// <inheritdoc />
        public override string ToString()
        {
            return this.ProgressString;
        }
    }
}
