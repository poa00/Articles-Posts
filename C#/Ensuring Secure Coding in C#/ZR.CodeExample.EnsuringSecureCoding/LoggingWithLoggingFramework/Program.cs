﻿using Serilog;

// Configure the Serilog logger
Log.Logger = new LoggerConfiguration()
    //.WriteTo.Console()
    .WriteTo.File("log.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();

try
{
    // Some code that may throw an exception
    int numerator = 10;
    int denominator = 0;
    int result = numerator / denominator; // This will throw a DivideByZeroException
    Console.WriteLine($"Result: {result}");
}
catch (DivideByZeroException ex)
{
    // Handle the exception gracefully
    Console.WriteLine("An error occurred: Cannot divide by zero.");
    // Log the exception using the configured logger
    Log.Error(ex, "An error occurred: Cannot divide by zero.");
}
catch (Exception ex)
{
    // Handle any other unexpected exceptions
    Console.WriteLine("An unexpected error occurred.");
    // Log the exception using the configured logger
    Log.Error(ex, "An unexpected error occurred.");
}
finally
{
    // Close and flush the logger to ensure all log messages are written before the application exits
    Log.CloseAndFlush();
}