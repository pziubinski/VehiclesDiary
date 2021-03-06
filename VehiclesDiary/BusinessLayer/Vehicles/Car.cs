﻿namespace VehiclesDiary.BusinessLayer.Vehicles
{
	public class Car : Vehicle
	{
		public Car(string name, RegistrationPlate plate) : base(name)
		{
			Plate = plate;
		}
		public RegistrationPlate Plate { get; private set; }
		
		public void ChangePlate(RegistrationPlate newPlate)
		{
			if (newPlate == null)
			{
				throw new UpdateFailedException("value is missing");
			}

			Plate = newPlate;
		}
	}
}