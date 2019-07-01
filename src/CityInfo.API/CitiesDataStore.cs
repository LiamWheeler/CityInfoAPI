using CityInfo.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; } 

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The one with the big park",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Central Park",
                            Description = "The United States' most visited urban park." },
                        new PointOfInterestDto()
                        { 


                            Id = 2,
                            Name = "Empire State Building",
                            Description = "A 102-story skyscraper."
                        },
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Antwerp",
                    Description = "The one with the unfinished cathedral",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 3,
                            Name = "Cathedral of Our Lady",
                            Description = "A Gothic style cathedral." },
                        new PointOfInterestDto()
                        {


                            Id = 4,
                            Name = "Antwerp central station",
                            Description = "Belgium's Best railway architecture."
                        },
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Paris",
                    Description = "The one with the big tower",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 5,
                            Name = "Eiffel Tower",
                            Description = "A wrought iron lattice tower." },
                        new PointOfInterestDto()
                        {


                            Id = 6,
                            Name = "The Louvre",
                            Description = "The World's largest museum."
                        },
                    }
                },
                new CityDto()
                {
                    Id = 4,
                    Name = "Salford",
                    Description = "The one with sunshine and gun crime",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 7,
                            Name = "Salford University",
                            Description = "Heart of the sunshine."
                        },
                        new PointOfInterestDto()
                        {


                            Id = 8,
                            Name = "Salford Precinct",
                            Description = "Heart of the gun crime."

                        },
                    }
                }
            };

        }

    }
}
