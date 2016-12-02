using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace town
{
    public class House
    {
        // Declare objects
        public string Name { get; set; }
        public string BldgType { get; set; }
        public string ConstMaterial { get; set; }
        public int NumOfRooms { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public double SqFoot
        {
            get { return Length * Width; } // Read only property
        }

        public int Floors { get; set; }
        public int Bedrooms { get; set; }
        public int Bathrooms { get; set; }
        public double Volume
        {
            get { return Length * Width * Height; } // Read only property
        }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }

        public string FullAddress
        {
            get { return ($" {Address1}, {Address2},  {City}, {State}, {Zip}"); } // Read only property
        }

        public int Occupants
        {
            get { return Occupants; } //Read only property

        }

        // Declare method
        public House()
        {
            // Declare constructors and initiaize
            this.Name = Name;
            this.BldgType = BldgType;
            this.ConstMaterial = ConstMaterial;
            this.NumOfRooms = 0;
            this.Height = 0;
            this.Width = 0;
            this.Length = 0;
            this.Floors = 0;
            this.Bedrooms = 0;
            this.Bathrooms = 0;
            this.Address1 = Address1;
            this.Address2 = Address2;
            this.City = City;
            this.State = State;
            this.Zip = Zip;


        }
        public static int IncreaseOccupants(int CurrentOccupants)
        {
            return CurrentOccupants++;
        }

        public static int DecreaseOccupants(int CurrentOccupants)
        {
            return CurrentOccupants--;
        }



    }


}
