# ConnectivityChallenge
Connectivity Challenge - The API converts a Pokemon name to it's Shakespear's style.

# Pre-requisites
Visual studio 2019, download free from https://visualstudio.microsoft.com/downloads/

# Using the solution
To work with the code just download the zip file or clone the repository.

Ensure the ConnectivityChallenge.WebAPI is the initial startup project

Open the ConnectivityChallenge.sln and clean and rebuild the entire solution

Press F5 or select Run to startup the API

Add the pokemon name at the end of the URL e.g. https://localhost:5001/pokemon/charizard

This will return a JSON response as under:

{"name":"charizard","description":"Charizard flies 'round the sky insearch of powerful opponents.'t breathes fire of such most wondrous heat yond 't melts aught. However,  itnever turns its fiery breath on anyopponent weaker than itself."}

# Solution Structure
ConnectivityChallengeWebAPI is the REST API exposed to the clients

ConnectivityChallenge.BLL is a class library which handles the call between the web API and third party API's and also provide validation

ConnectivityChallenge.API is a class library to connect to third party API's

ConnectivityChallenge.UT is the n-unit project for unit testing

# Technology used to build the application
VS 2019 for mac
.Net Core 3.1 
AutoMapper
Dependency injection
System.Text for Json serialization

# Unit tests 
Unit test are provided under the ConnectivityChallenge.UT project
Use the Test explorer window to run all tests

# Feeback
Any feedback is welcomed, thanks.


