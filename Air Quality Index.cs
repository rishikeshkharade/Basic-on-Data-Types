using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_on_Data_Types
{

    public class Air_Quality_Index
    {
        public static void aqi()
        {
            Console.WriteLine("Enter the concentration of PM2.5 (mg/m³):");
            double pm25 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the concentration of PM10 (mg/m³):");
            double pm10 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the concentration of CO (mg/m³):");
            double co = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the concentration of NO2 (mg/m³):");
            double no2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the concentration of SO2 (µg/m³):");
            double so2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the concentration of O3 (µg/m³):");
            double o3 = Convert.ToDouble(Console.ReadLine());

            double aqi = CalculateAQI(pm25, pm10, co, no2, so2, o3);
            string aqiCategory = GetAQICategory(aqi);

            Console.WriteLine($"The calculated AQI is: {aqi}");
            Console.WriteLine($"AQI Category: {aqiCategory}");
        }

        static double CalculateAQI(double pm25, double pm10, double co, double no2, double so2, double o3)
        {
            double aqiPM25 = CalculateIndividualAQI(pm25, 0, 12, 35.4, 55.4, 150.4, 250.4, 500.4);
            double aqiPM10 = CalculateIndividualAQI(pm10, 0, 54, 154, 254, 354, 424, 604);
            double aqiCO = CalculateIndividualAQI(co, 0, 4.4, 9.4, 12.4, 15.4, 30.4, 50.4);
            double aqiNO2 = CalculateIndividualAQI(no2, 0, 53, 100, 360, 649, 1249, 1649);
            double aqiSO2 = CalculateIndividualAQI(so2, 0, 35, 75, 185, 304, 604, 804);
            double aqiO3 = CalculateIndividualAQI(o3, 0, 54, 70, 85, 105, 200, 404);

            return Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(aqiPM25, aqiPM10), aqiCO), aqiNO2), aqiSO2), aqiO3);
        }

        static double CalculateIndividualAQI(double concentration, params double[] breakpoints)
        {
            for (int i = 0; i < breakpoints.Length; i += 4)
            {

                double lowC = breakpoints[i];
                double lowI = breakpoints[i + 1];
                double highC = breakpoints[i + 2];
                double highI = breakpoints[i + 3];

                if (concentration >= lowC && concentration <= highC)
                {
                    return (highI - lowI) / (highC - lowC) * (concentration - lowC) + lowI;
                }
            }
            return 0;
        }

        static string GetAQICategory(double aqi)
        {
            if (aqi <= 50)
                return "Good";
            else if (aqi <= 100)
                return "Moderate";
            else return "Unhealthy";
        }
    }
}
