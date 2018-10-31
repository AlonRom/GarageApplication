﻿using System.Collections.Generic;
using GarageLogic.Exceptions;
using GarageLogic.Interfaces;

namespace GarageLogic.Models
{
    class Truck : Vehicle, IRegularVehicle
    {
        public const int k_MaxAirPressureByManufacturer = 28;

        public const int k_NumberOfWheels = 12;
        public Truck()
        {
            FuelType = eFuelType.Octan96;
            MaxAmountOfFuelInLiters = 115;
            Wheels = new List<Wheel>();
        }
        public bool IsCarryingHazardousMaterials { get; set; }
        public float MaxCarryingWeightAllowed { get; set; }

        public eFuelType FuelType { get; set; }

        public float CurrentAmountOfFuelInLiters { get; set; }

        public float MaxAmountOfFuelInLiters { get; set; }

        public void Refuel(float i_LitersToAdd, eFuelType i_FuelType)
        {
            if (i_LitersToAdd < 0 || CurrentAmountOfFuelInLiters + i_LitersToAdd > MaxAmountOfFuelInLiters)
            {
                throw new ValueOutOfRangeException($"The fuel must be between {0} and {MaxAmountOfFuelInLiters}! Please try again");
            }
            CurrentAmountOfFuelInLiters += i_LitersToAdd;
        }
    }
}
