using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogisticApp.Models;
using Microsoft.Data.Sqlite;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;



namespace LogisticApp.Services
{
    internal class DatabaseService
    {

        private readonly string _connectionString = "Data Source=logistics.db";

        public DatabaseService()
        {
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = @"
            CREATE TABLE IF NOT EXISTS Trucks (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            Model TEXT NOT NULL,
            KM TEXT NOT NULL,
            Driver TEXT NOT NULL,
            CurrentLocation TEXT NOT NULL,
            LicensePhoto TEXT,
            TruckPhoto TEXT
            );

            CREATE TABLE IF NOT EXISTS Trailers (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            LicensePlate TEXT NOT NULL,
            Type TEXT NOT NULL,
            Capacity REAL NOT NULL
             );
           ";
            
            command.ExecuteNonQuery();
        }

        public void AddTruck(Truck truck)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = @"
                INSERT INTO Trucks (Model, KM, Driver, CurrentLocation, LicensePhoto, TruckPhoto)
                VALUES ($model, $km, $driver, $currentLocation, $licensePhoto, $truckPhoto);
            ";

            command.Parameters.AddWithValue("$model", truck.Model);
            command.Parameters.AddWithValue("$km", truck.KM);
            command.Parameters.AddWithValue("$driver", truck.Driver);
            command.Parameters.AddWithValue("$currentLocation", truck.CurrentLocation);
            command.Parameters.AddWithValue("$licensePhoto", truck.LicensePhoto);
            command.Parameters.AddWithValue("$truckPhoto", truck.TruckPhoto);

            command.ExecuteNonQuery();
        }

        public void AddTrailer(Trailer trailer)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = @"
                INSERT INTO Trailers (LicensePlate, Type, Capacity)
                VALUES ($licensePlate, $type, $capacity);
            ";

            command.Parameters.AddWithValue("$licensePlate", trailer.LicensePlate);
            command.Parameters.AddWithValue("$type", trailer.Type);
            command.Parameters.AddWithValue("$capacity", trailer.Capacity);

            command.ExecuteNonQuery();
        }






    }
}
