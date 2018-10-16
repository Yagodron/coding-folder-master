using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

[assembly: CLSCompliant(true)]

namespace BirdSpeciesLibrary
{
    #region Custom attribute

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct,
                    AllowMultiple = true, Inherited = false)]
    public sealed class BirdSpeciesAttribute : System.Attribute
    {
        public string Classification { get; set; }

        public BirdSpeciesAttribute(string birdSpecies)
        {
            Classification = birdSpecies;
        }
        public BirdSpeciesAttribute() { }
    }
    #endregion



    [SerializableAttribute]
    [BirdSpecies("Black, song is croak")]
    public class Crow
    {
    }

    [BirdSpecies("Small, song is usually described as a whistled peter-peter-peter")]
    public class Titmouse
    {
    }
}
