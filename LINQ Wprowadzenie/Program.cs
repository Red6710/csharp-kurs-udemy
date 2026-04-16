using CsvHelper;
using CsvHelper.Configuration;
using LINQ_Wprowadzenie;
using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

// ReSharper disable UseFormatSpecifierInInterpolation

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string csvPath = @"D:\Program Files\TextFiles\LINQ Files\googleplaystore1.csv";
            var googleApps = LoadGoogleAps(csvPath);

            GroupData(googleApps);

           

        }

        static void GroupData(IEnumerable<GoogleApp> googleApps)
        {
            var categoryGroup = googleApps.GroupBy(app => new { app.Category, app.Type });

            foreach (var group in categoryGroup)
            {
                var key = group.Key;
                var apps = group.ToList();
                Console.WriteLine($"Displaing elemeents for group {group.Key.Category}, {group.Key.Type}");
                Display(apps);
            }
           
        }

        static void DataSetOperation(IEnumerable<GoogleApp> googleApps)
        {
            var paidAppsCategories = googleApps.Where((GoogleApp app) => app.Type == Type.Paid)
                .Select(a => a.Category)
                .Distinct();
            //Console.WriteLine($"Paid apps categories:{string.Join(", ", paidAppsCategories)}");

            var setA = googleApps.Where(a => a.Rating > 4.7 && a.Type == Type.Paid && a.Reviews > 1000);
            var setB = googleApps.Where(a => a.Name.Contains("Pro") && a.Rating > 4.6 && a.Reviews > 10000);

            //Display(setB);
            //Display(setA);

            var appsUnion = setA.Union(setB);
          

            Console.WriteLine("appsUnion");

            Display(appsUnion);

            var appsIntersect = setA.Intersect(setB);
            Console.WriteLine("appsIntersect");
            Display(appsIntersect);

            var appsExcept = setA.Except(setB);
            Console.WriteLine("AppsExcept");
            Display(appsExcept);



        }

        static void DataVerification(IEnumerable<GoogleApp> googleApps)
        {
            var wheatherApplications = googleApps.Where((GoogleApp app) => app.Category == Category.WEATHER)
                .All(app => app.Reviews > 11);
            var anyOperatorCheck = googleApps.Where((GoogleApp app) => app.Category == Category.WEATHER)
                .Any(app => app.Reviews <3_000_000);
            Console.WriteLine($"Is good: {anyOperatorCheck}");
                                    
        }

        static void OrderData (IEnumerable<GoogleApp> googleApps)
        {
         var highRatedBeautyApps = googleApps.Where((GoogleApp app) => app.Rating > 4.4 && app.Category == Category.BEAUTY);
         var sortedResults = highRatedBeautyApps.OrderByDescending(app => app.Rating)
                .ThenBy(app => app.Name);
         Display(sortedResults);
        }

        static void DivideData(IEnumerable<GoogleApp> googleApps)
        {
            var highRatedBeautyApps = googleApps.Where((GoogleApp app) => app.Rating > 4.6 && app.Category == Category.BEAUTY);

            var firstHighRatedBeautyApps = highRatedBeautyApps.TakeWhile(app => app.Reviews > 1000);
            var skippedResults = highRatedBeautyApps.Skip(5);

            Display(firstHighRatedBeautyApps);
            Display(skippedResults);
        }

        static void ProjectData(IEnumerable<GoogleApp> googleApps)
        {
            var highRatedBeautyApps = googleApps.Where((GoogleApp app) => app.Rating > 4.6 && app.Category == Category.BEAUTY);
            var highRatedBeautyAppsNames = highRatedBeautyApps.Select(app => app.Name);

            var dtos = highRatedBeautyApps.Select(app => new GoogleAppsDto()
            {
                Reviews = app.Reviews,
                Name = app.Name

            });

            var anonymousDtos = highRatedBeautyApps.Select(app => new
            {
                Reviews = app.Reviews,
                Name = app.Name,
                Category = app.Category

            });


            var geners = highRatedBeautyApps.SelectMany(app => app.Genres);

            foreach (var dto in anonymousDtos)
            {
                Console.WriteLine($"{dto.Name}: {dto.Reviews}");
            }    
            Console.WriteLine(string.Join(", ", highRatedBeautyAppsNames));

            Console.WriteLine(string.Join("; ", geners));

        }
        static void GetData(IEnumerable<GoogleApp> googleApps)
        {
 
            var highRatedApps = googleApps.Where((GoogleApp app) => app.Rating > 4.6);
            var highRatedBeautyApps = googleApps.Where((GoogleApp app) => app.Rating > 4.6 && app.Category == Category.BEAUTY);
            Display(highRatedBeautyApps);

            var firstHighRatedBeautyApp = highRatedBeautyApps.Last(app => app.Reviews < 300);
            Console.WriteLine(firstHighRatedBeautyApp);
        }

        static void Display(IEnumerable<GoogleApp> googleApps)
        {
            foreach (var googleApp in googleApps)
            {
                Console.WriteLine(googleApp);
            }

        }
        static void Display(GoogleApp googleApp)
        {
            Console.WriteLine(googleApp);
        }

        static List<GoogleApp> LoadGoogleAps(string csvPath)
        {
            using (var reader = new StreamReader(csvPath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<GoogleAppMap>();
                var records = csv.GetRecords<GoogleApp>().ToList();
                return records;
            }

        }

    }


}