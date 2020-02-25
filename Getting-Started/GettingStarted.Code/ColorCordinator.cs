using System;
using System.Diagnostics.CodeAnalysis;

namespace GettingStarted.Code
{
    public class ColorCordinator
    {
        [ExcludeFromCodeCoverage]
        public string shirtColor { get; set; }

        public void suggestMyShirtColor(String pantsColor)
        {
            if ((pantsColor == "") || (pantsColor == "gray"))
            {
                this.shirtColor = "error";
                return;
            }

            switch (pantsColor)
            {
                case "red":
                    this.shirtColor = "pink";
                    break;

                case "blue":
                    this.shirtColor = "green";
                    break;

                case "green":
                    this.shirtColor = "blue";
                    break;

                case "pink":
                    this.shirtColor = "yellow";
                    break;

                case "black":
                    this.shirtColor = "white";
                    break;

                default:
                    this.shirtColor = "black";
                    break;
            }
        }

        [ExcludeFromCodeCoverage]
        public String sugggestMySockColor(String shoeColor, String shirtColor)
        {
            return "black";
        }
    }
}
