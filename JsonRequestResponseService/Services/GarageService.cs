using System;
using System.Linq;
using JsonRequestResponseService.Models;

namespace JsonRequestResponseService.Services
{
    public class GarageService
    {
        public GarageResponse GarageModification(GarageRequest data)
        {
            string result = $"Hi {data.Name}, your cars:";

            if (data.SortType == "ASC")
            {
                data.Cars = data.Cars.OrderBy(c => c).ToList();
            }
            else if (data.SortType == "DESC")
            {
                data.Cars = data.Cars.OrderByDescending(c => c).ToList();
            }
            else
            {
                throw new Exception("Incorrect sortyng type"); 
            }
            foreach (string car in data.Cars)
            {
                result += $" {car}";
            }
                
            return new GarageResponse { Result = result };
        }
    }
}
