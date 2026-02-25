# Web Engineering Lab - API Project

**Author:** Ahmed Adel Sayed Goda Ahmed
**Student Id** 211005618
**Course:** Web Engineering

## Overview
This is an ASP.NET Core Web API project for my lab assignment. It includes two models (`Game` and `Food`) and follows the Interface -> Service -> Controller architecture using in-memory lists.

## API Endpoints

**Games**
* `GET /games` - View all games
* `GET /games/{id}` - View a specific game by ID
* `POST /games` - Add a new game

**Food**
* `GET /food` - View all food items
* `GET /food/{id}` - View a specific food item by ID
* `POST /food` - Add a new food item

## How to Run
1. Open your terminal in the project folder.
2. Run the application using:
   ```bash
   dotnet run
