# semester3Project - forum

# Table of content
- Overview
- Prerequisites 
- Usage
- Features
- Architecture
- Code examples 
- testing 
- Things Learned. 

# Overview
Simulation of a forum. 

# Prerequisites 
you will need a windows machine , visual studio (NOT CODE) and a browser. 

# Usage
open the project in visual studio
- right click on the solution 
- select properties
- go under startup project, then do the following to start everything needed
1) mark the multiple startup projects 
2) select the Webserver MVC, RestAPI, and ForumGUI -> set to start
3) click apply or ok. 
4) click ctrl + f5 to start the project without debuggin. 

wait some time to let everything start. a winforms application and two browser tabs (may be in two different browser instances). igonore the api (swagger tab). 

now it is possible to use both application and browser to use the system. 

# Features
the project can CRUD topics, posts, comments, users

# Architecture 

to see the diagram for the domain model and architecture, at an extreamly basic level see the UML-diagram folder. 

# Code examples 

to view code example of the work done in the project see the folder named Code Examples

# Testing 
used XUnit.Net.TestGenerator2022 which is an extension to visual studio. 
mostly done integration testing / system testing on the system + manual tests for testing the website functionality. 


# Things learned
- C#, 
- HTML
- RAZOR
- web communication via http. 
- handling transactions and concurrency problem.
- winform application (GUI)
- MVC 
- Rest api 
- more sql

