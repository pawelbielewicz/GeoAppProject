# README #

This is dotnet core web api app

### What is this repository for? ###

The goal of the task is a simple application that provides the API allowing to record geolocation measurements of objects and read the current location of the selected object.

Business requirements:
- Ability to save geolocation data. The measurement consists of:
object id (uuid),
longitude and latitude,
measurement accuracy (positive floating point number) and
time of taking the measurement.
- The ability to read geolocation data for a given object. For the given id (uuid), the system returns the newest measurement.

Technical requirements:
- .Net Core 3+ or .Net 5+
- Communication with any database in any way.
- Automatic tests.
