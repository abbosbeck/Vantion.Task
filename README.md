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
