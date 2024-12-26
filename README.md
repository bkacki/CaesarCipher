# Caesar Cipher

This solution contains a simple implementation of the Caesar Cipher in C#. The solution includes a console application for encoding and decoding messages, as well as unit tests to ensure the correctness of the implementation.

## Project Structure

- **CaesarCipher**: This project contains the main implementation of the Caesar Cipher.
  - `Program.cs`: The entry point of the console application.
  - `CaesarCipher.cs`: Contains the static class `CaesarCipher` with methods for encoding and decoding messages.

- **CaesarCipherTests**: This project contains unit tests for the Caesar Cipher implementation.
  - `CaesarCipherTests.csproj`: The project file for the test project.

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

### Building the Solution

To build the solution, navigate to the solution directory and run:
`dotnet build`

### Running the Application

To run the console application, navigate to the `CaesarCipher` project directory and run:
`dotnet run --project CaesarCipher`

### Running the Tests

To run the unit tests, navigate to the `CaesarCipherTests` project directory and run:
`dotnet test`

## Usage

When you run the console application, you will be prompted to enter a message and a shift value. You can then choose to encode or decode the message using the Caesar Cipher.

## Example
```
Message: Hello World!
Enter shift: 7
[E]ncode or [D]ecode: e
Encoded message: Olssv Dvysk!

Message: Olssv Dvysk!
Enter shift: 7
[E]ncode or [D]ecode: d
Decoded message: Hello World!
```

## License

This project is licensed under the MIT License.
