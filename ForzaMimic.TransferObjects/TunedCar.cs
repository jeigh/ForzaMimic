using System;
using System.ComponentModel;

namespace ForzaMimic.TransferObjects
{
    public class TunedCar
    {
        // Artificial
        [DisplayName("Vehicle Name")]
        public string VehicleFriendlyName { get; set; } = string.Empty;

        [DisplayName("Vehicle Description")] 
        public string VehicleDescription { get; set; } = string.Empty;

        [DisplayName("Make")] 
        public string CarMake { get; set; } = string.Empty;
        [DisplayName("Model")]
        public string CarModel { get; set; } = string.Empty;

        // Measurable
        public int Weight { get; set; }   //kg
        
        [DisplayName("Weight Front Percentage")]
        public decimal FrontWeight { get; set; } // percentage, range 0 to 100
        
        [DisplayName("Drive Type")]
        public string DriveType { get; set; } = string.Empty;
        [DisplayName("Best Power Band Starts At(RPM)")] 
        public int PowerBandMin { get; set; }
        [DisplayName("Maximum Torque (in Foot-pounds)")]
        public int Torque { get; set; }   // in lb-ft
        [DisplayName("Forced Induction? (Turbo-or-Super charger")]
        public Boolean IsForcedInduction { get; set; }   // does this have a turborcharger or supercharger?
        [DisplayName("Number of Gears")]
        public int NumberOfGears { get; set; }
        [DisplayName("Rear Tire Section Width")]
        public int RearTireSectionWidth { get; set; }
        [DisplayName("Rear Tire Sidewall Aspect Ratio")]
        public int SidewallAspectRatio { get; set; }
        [DisplayName("Rear Wheel Diameter")]
        public int WheelDiameter { get; set; }

        // Calculated
        [DisplayName("Forza Performance Index")]
        public int PerformanceIndex { get; set; } // range 0-1000
        [DisplayName("0-60mph in seconds")]
        public decimal SimulatedZeroToSixty { get; set; } // seconds
        [DisplayName("0-100mph in seconds")]
        public decimal SimulatedZeroToOneHundred { get; set; } // seconds
        [DisplayName("Quarter mile in seconds")]
        public decimal SimulatedQuarterMile { get; set; }  // seconds
        [DisplayName("Top Speed (mph)")]
        public decimal TopSpeed { get; set; }
        [DisplayName("Distance to break from 60 ft")]
        public decimal BreakingDistance60InFeet { get; set; }
        [DisplayName("Distance to break from 100 ft")] 
        public decimal BreakingDistance100InFeet { get; set; }
        [DisplayName("Lateral Gs (60)")] 
        public decimal LateralG60 { get; set; }
        [DisplayName("Lateral Gs (120)")] 
        public decimal LateralG120 { get; set; }



        // Tunable Properties
        [DisplayName("Front Tire Psi")] 
        public decimal FrontPsi { get; set; }
        [DisplayName("Rear Tire Psi")]
        public decimal RearPsi { get; set; }

        [DisplayName("Gearing")] 
        public decimal FinalGearing { get; set; }
        [DisplayName("Front Camber")]
        public decimal FrontCamber { get; set; }
        [DisplayName("Rear Camber")] 
        public decimal RearCamber { get; set; }

        [DisplayName("Front Toe")] 
        public decimal FrontToe { get; set; }
        [DisplayName("Rear Toe")] 
        public decimal RearToe { get; set; }

        [DisplayName("Front Caster")] 
        public decimal FrontCaster { get; set; }

        [DisplayName("Front Anti-Roll")] 
        public decimal FrontAntiRoll { get; set; }
        [DisplayName("Rear Anti-Roll")] 
        public decimal RearAntiRoll { get; set; }

        [DisplayName("Front Springs")] 
        public decimal FrontSprings { get; set; }
        [DisplayName("Rear Springs")] 
        public decimal RearSprings { get; set; }

        [DisplayName("Front Ride Height")] 
        public string FrontRideHeight { get; set; } = string.Empty;
        [DisplayName("Rear Ride Height")] 
        public string RearRideHeight { get; set; } = string.Empty;

        [DisplayName("Front Rebound")] 
        public decimal FrontRebound { get; set; }
        [DisplayName("Rear Rebound")] 
        public decimal RearRebound { get; set; }

        [DisplayName("Front Bump")] 
        public decimal FrontBump { get; set; }
        [DisplayName("Rear Bump")] 
        public decimal RearBump { get; set; }

        [DisplayName("Front Downforce")] 
        public string FrontDownforce { get; set; } = string.Empty;
        
        [DisplayName("Rear Downforce")] 
        public string RearDownforce { get; set; } = string.Empty;

        [DisplayName("Breaking Balance Ratio")] 
        public decimal BrakingBalance { get; set; }
        [DisplayName("Braking Force Ratio")] 
        public decimal BrakingForce { get; set; }
        [DisplayName("Rear Differential Accel Ratio")] 
        public decimal RearDifferentialAccel { get; set; }
        [DisplayName("Rear Differential Decel Ratio")] 
        public decimal RearDifferentialDecel { get; set; }

    }
}