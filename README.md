# CSV Parser
This project parses data from a CSV file into the database. If the data in the CSV already exists in the Database, it will be updated accordingly.

## File Format Requirements
To ensure smooth usage without errors, please make sure to send a valid CSV file. The CSV file should adhere to the following format:

### File Structure:
```code
username -> string
useridentifier -> Guid
age -> int
city -> string
phonenumber -> string
email -> string
```

**Note:**
- `username`: A string representing the user's name.
- `useridentifier`: A unique identifier in the form of a GUID (Globally Unique Identifier).
- `age`: An integer representing the user's age.
- `city`: A string indicating the user's city.
- `phonenumber`: A string containing the user's phone number.
- `email`: A string representing the user's email address.

Please ensure that your CSV file follows this specified format for proper processing.

## Usage

To use this project, follow these steps:

1. Download the project to your computer.

2. Ensure you have the .NET 7 SDK installed on your machine.

3. Open the terminal in the project folder.

4. Run the command `dotnet run` in the terminal.

5. If the project starts successfully, you will see it running on your browser via Swagger.

### Swagger Endpoints

Swagger provides two functions:

- **Get**: Use this endpoint to check if Swagger is working correctly.

- **Create**: This endpoint allows you to upload a CSV file. If the data in the CSV file is valid, it will be saved to the database.

### Example CSV File

In our GitHub repository, you can find an example CSV file at the following path: [Vention.Internship.CsvParser.API/wwwroot/uploads](snakes_count_10.csv). You can use this file as a reference to understand the required format for the CSV data.
