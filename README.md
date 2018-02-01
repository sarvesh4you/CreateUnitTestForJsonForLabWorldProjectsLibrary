# Test Engineer Test #

The project "JsonForLabWorldProjects" is supposed to be a library which server and client are using at the same time. 
The server answers to the clients by sending a list of "modules".
The library provides an Object-Type "ServerAnswerAsData" to store data. 
It translates a "ServerAnswerAsData"-Object into a JSON-string and sends it to the client (sending is not part of this library).
On the client, the library will translate the JSON-string back into a "ServerAnswerAsData"-Object.


### Unit Tests ###

I have created few basic unit tests for "JsonForLabWorldProjects" library that could be used by a developer for ongoing development of the library. Please find "UnitTestForLibrary.cs" under the 
 
 \CreateUnitTestForJsonForLabWorldProjectsLibrary\JsonForLabWorldProducts\Example\UnitTestForLibrary.cs


Test 1 - [Test with the valid/invalid input data that library provides an valid Object-Type "ServerAnswerAsData" successfully.]

Test 2 - [Test that library translates a "ServerAnswerAsData"-Object into a valid JSON-string successfully.]

Test 3 - [Test that library translates the JSON-string back into a "ServerAnswerAsData"-Object successfully.]
         
