using System.Reflection.Metadata.Ecma335;
using ForzaMimic.TransferObjects;

namespace ForzaMimic.MockDataAccess
{
    // normally I'd put this data in a database, but since I wanted this data to be available in code, 
    // I'm just going to deploy it with the mocks and only change that if there's a compelling reason to add create/update/delete features.
    public class MockDataAccess : IForzaMimicDataAccess
    {
        public MockDataAccess()
        {
            _fieldStudies.Add(_greenJaguar);
            _fieldStudies.Add(_jasonsVolkswagen);
            _fieldStudies.Add(_redCorvette);
            _fieldStudies.Add(_wrxSti);
        }

        public IEnumerable<FieldStudy> RetrieveAllFieldStudies()
        {
            return _fieldStudies.ToList();
        }

        public FieldStudy? RetrieveFieldStudiesById(Guid paramFieldStudyId)
        {
            FieldStudy? returnable = (
                from item in _fieldStudies
                where item.FieldStudyId == paramFieldStudyId
                select item
            ).FirstOrDefault();

            return returnable;
        }

        private List<FieldStudy> _fieldStudies = new List<FieldStudy>();
        
        private FieldStudy _jasonsVolkswagen = new FieldStudy()
        {
            VehicleFriendlyName = "An Interesting Car",
            VehicleDescription = "Remember, it's not just a car; it's a Volkswagen.",
            CardColor = "Purple",
            CarMake = "Volkswagen",
            CarModel = "Golf R",
            Weight = 3069,
            FrontWeight = 0.56M,
            DriveType = "AWD",
            PowerBandMin = 1700,
            Torque = 270,
            IsForcedInduction = false,
            NumberOfGears = 5,
            RearTireSectionWidth = 255,
            SidewallAspectRatio = 25,
            WheelDiameter = 20,
            PerformanceIndex = 500,
            SimulatedZeroToSixty = 0,
            SimulatedZeroToOneHundred = 12.901M,
            SimulatedQuarterMile = 0,
            TopSpeed = 158.2M,
            BreakingDistance60InFeet = 0,
            BreakingDistance100InFeet = 0,
            LateralG60 = 0,
            LateralG120 = 0,
            FrontPsi = 29,
            RearPsi = 29,
            FinalGearing = 2.21M,
            FrontCamber = -2.2M,
            RearCamber = -1.2M,
            FrontToe = 0,
            RearToe = 0,
            FrontCaster = 5.6M,
            FrontAntiRoll = 19.0M,
            RearAntiRoll = 15.5M,
            FrontSprings = 637.4M,
            RearSprings = 500.9M,
            FrontRideHeight = "MEDIUM",
            RearRideHeight = "MEDIUM",
            FrontRebound = 6.8M,
            RearRebound = 5.3M,
            FrontBump = 4.1M,
            RearBump = 4.0M,
            FrontDownforce = "MEDIUM",
            RearDownforce = "LOW",
            BrakingBalance = 0.53M,
            BrakingForce = 1M,
            RearDifferentialAccel = 0.49M,
            RearDifferentialDecel = 0.31M,
            FieldStudyId = new Guid("b0f77449-acac-4042-8859-53abc421e154"),
            FieldLaps = 2,
            ElapsedTotal = 1350,
            RollingStart = false,
            FieldTestComments = "Fairly easy to control this car because it's both rather low in power, and FF cars are pretty easy to control already.",
            VideoUrl = "https://www.youtube.com/embed/1ig00IB20PE"
        };
        private FieldStudy _redCorvette = new FieldStudy()
        {
            CardColor = "Red",
            VehicleFriendlyName = "Red Corvette",
            VehicleDescription = "A close approximation of Letty's red Corvette from the fast & the furious series",
            CarMake = "Chevrolet",
            CarModel = "Corvette",
            Weight = 3092,
            FrontWeight = 48,
            DriveType = "RWD",
            PowerBandMin = 4300,
            Torque = 425,
            IsForcedInduction = false,
            NumberOfGears = 6,
            RearTireSectionWidth = 295,
            SidewallAspectRatio = 40,
            WheelDiameter = 18,
            PerformanceIndex = 599,
            SimulatedZeroToSixty = 0,
            SimulatedZeroToOneHundred = 10.03M,
            SimulatedQuarterMile = 0,
            TopSpeed = 164.4M,
            BreakingDistance60InFeet = 0,
            BreakingDistance100InFeet = 0,
            LateralG60 = 0,
            LateralG120 = 0,
            FrontPsi = 28.5M,
            RearPsi = 28.5M,
            FinalGearing = 3.14M,
            FrontCamber = -2,
            RearCamber = -1.2M,
            FrontToe = 0,
            RearToe = 0,
            FrontCaster = 5.7M,
            FrontAntiRoll = 19.6M,
            RearAntiRoll = 18.5M,
            FrontSprings = 529.1M,
            RearSprings = 573.2M,
            FrontRideHeight = "MEDIUM",
            RearRideHeight = "MEDIUM",
            FrontRebound = 5.8M,
            RearRebound = 6.1M,
            FrontBump = 4.2M,
            RearBump = 4.6M,
            FrontDownforce = "LOW",
            RearDownforce = "MEDIUM",
            BrakingBalance = 0.52M,
            BrakingForce = 1,
            RearDifferentialAccel = 0.43M,
            RearDifferentialDecel = 0.35M,
            FieldStudyId = new Guid("9e508840-196f-46f0-b82b-ff224ce26c39"),
            FieldLaps = 2,
            ElapsedTotal = 1266,
            RollingStart = true,
            FieldTestComments = "Despite being an RWD car, it was relatively easy to keep on the road, potentially because of the low weight, rear downforce, and not being remarkably overpowered.  I wasn't too eager to turn of TCS though.",
            VideoUrl = "https://www.youtube.com/embed/CPIBjtRutyg"

        };
        private FieldStudy _wrxSti = new FieldStudy()
        {
            CardColor = "White",
            VehicleFriendlyName = "White Subaru WRX STI",
            VehicleDescription = "A tuned WRX STI",
            CarMake = "Subaru",
            CarModel = "WRX",
            Weight = 3444,
            FrontWeight = 55,
            DriveType = "AWD",
            PowerBandMin = 4600,
            Torque = 425,
            IsForcedInduction = true,
            NumberOfGears = 6,
            RearTireSectionWidth = 265,
            SidewallAspectRatio = 35,
            WheelDiameter = 20,
            PerformanceIndex = 718,
            SimulatedZeroToSixty = 0,
            SimulatedZeroToOneHundred = 8.878M,
            SimulatedQuarterMile = 0,
            TopSpeed = 200.7M,
            BreakingDistance60InFeet = 0,
            BreakingDistance100InFeet = 0,
            LateralG60 = 0,
            LateralG120 = 0,
            FrontPsi = 28,
            RearPsi = 28,
            FinalGearing = 3.18M,
            FrontCamber = -2.2M,
            RearCamber = -1.3M,
            FrontToe = 0,
            RearToe = 0,
            FrontCaster = 5.9M,
            FrontAntiRoll = 27.6M,
            RearAntiRoll = 23.2M,
            FrontSprings = 658.8M,
            RearSprings = 561,
            FrontRideHeight = "MEDIUM",
            RearRideHeight = "MEDIUM",
            FrontRebound = 7.3M,
            RearRebound = 6.0M,
            FrontBump = 5.2M,
            RearBump = 4.5M,
            FrontDownforce = "LOW",
            RearDownforce = "LOW",
            BrakingBalance = 0.53M,
            BrakingForce = 1M,
            RearDifferentialAccel = 0.52M,
            RearDifferentialDecel = 0.28M,
            FieldStudyId = new Guid("88285f78-1bce-42d7-9c71-77d1c677659a"),
            FieldLaps = 2,
            ElapsedTotal = 1210,
            RollingStart = true,
            FieldTestComments = "Because of the well tuned differentials, the driver was able to turn off TCS and still keep control over the vehicle most of the time at high speeds.  I was underpowered for my class, so there was some aggressive driving in the beginning.",
            VideoUrl = "https://www.youtube.com/embed/" + "v5oABO4QxpE"
        };
        private FieldStudy _greenJaguar = new FieldStudy()
        {
            CardColor = "Green",
            VehicleFriendlyName = "Green Jaguar",
            VehicleDescription = "This green Jaguar is meant to simulate the car driven by Deckard Shaw, played by Jason Statham.",
            CarMake = "Jaguar",
            CarModel = "F-Type R Coupe",
            Weight = 3388,
            FrontWeight = 51,
            DriveType = "RWD",
            PowerBandMin = 2400,
            Torque = 500,
            IsForcedInduction = true,
            NumberOfGears = 8,
            RearTireSectionWidth = 295,
            SidewallAspectRatio = 25,
            WheelDiameter = 22,
            PerformanceIndex = 687,
            SimulatedZeroToSixty = 0,
            SimulatedZeroToOneHundred = 7.394M,
            SimulatedQuarterMile = 0,
            TopSpeed = 195,
            BreakingDistance60InFeet = 0,
            BreakingDistance100InFeet = 0,
            LateralG60 = 0,
            LateralG120 = 0,
            FrontPsi = 28,
            RearPsi = 28,
            FinalGearing = 3.31M,
            FrontCamber = -1.9M,
            RearCamber = -1.1M,
            FrontToe = 0,
            RearToe = 0,
            FrontCaster = 5.8M,
            FrontAntiRoll = 18.7M,
            RearAntiRoll = 17,
            FrontSprings = 608.8M,
            RearSprings = 585,
            FrontRideHeight = "MEDIUM",
            RearRideHeight = "MEDIUM",
            FrontRebound = 6.7M,
            RearRebound = 6.3M,
            FrontBump = 4.8M,
            RearBump = 4.7M,
            FrontDownforce = "LOW",
            RearDownforce = "LOW",
            BrakingBalance = 0.53M,
            BrakingForce = 1,
            RearDifferentialAccel = 0.45M,
            RearDifferentialDecel = 0.34M,
            FieldStudyId = new Guid("ef92a120-fc21-4bef-8d18-4008a26f31d4"),
            FieldLaps = 2,
            ElapsedTotal = 1235,
            RollingStart = false,
            FieldTestComments = "Driver still had difficulty keeping this thing on the road despite turning TCS on.  Lots of power in the rear to propel the vehicle forward, but that power comes at the risk of spinning out and chance of oversteer. ",
            VideoUrl = "https://www.youtube.com/embed/" + "KonURgN8wlk"
        };


    }
}