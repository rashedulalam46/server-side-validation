# Server-Side Validation

This project demonstrates how to implement **server-side validation** in a web API using ASP.NET Core. It ensures that data submitted by the client meets the required rules and constraints before it is processed.

## 🔗 GitHub Repository

[https://github.com/rashedulalam46/server-side-validation](https://github.com/rashedulalam46/server-side-validation)

---

## 📦 Getting Started

Follow these instructions to get a copy of the project up and running on your local machine.

### ✅ Prerequisites

Before you begin, make sure you have the following installed:

- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or later)
- [Git](https://git-scm.com/)
- [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)

---

## ⬇️ Clone the Repository

Open your terminal and run the following command:

```bash
git clone https://github.com/rashedulalam46/server-side-validation.git
cd server-side-validation
```

## Run the API

Open your terminal and run the following command to restore depedencies, build & run the project:

```bash
dotnet restore
dotnet build
dotnet run
```

The API will start on http://localhost:5000 or https://localhost:5001.

## 🔍 Test the API with Postman

Open Postman and create a POST request to:

```bash
https://localhost:5103/api/users
```

In the Body, select raw and JSON, then use sample input like:

```bash
{
  "userId": 101,
  "userName": "rashed",
  "email": "rashed@gmail",
  "age": 12,
  "phoneNumber": "123",
  "website": "https://domain.com",
  "creditCard": "4111111111111111",
  "password": "123456",
  "confirmPassword": "123456"
}
```

## ✅ Expected Output

If validation fails, you’ll receive a 400 Bad Request response like:

```bash
{
  "errors": {
    "Email": ["The Email field is not a valid e-mail address."],
    "Age": ["Age must be 18 or older."]
  }
}
```

If validation passes, you’ll get a 200 OK response or a confirmation message depending on your controller logic.

## 📁 Project Structure

```bash
server-side-validation/
├── Controllers/
│   └── UsersController.cs
├── Models/
│   └── User.cs
├── Program.cs
└── server-side-validation.csproj
```

## 🤝 Contributing
Pull requests are welcome! If you find bugs or have suggestions, feel free to open an issue.

## 📄 License
This project is licensed under the MIT License.

## 👤 Author
[Rashedul Alam](https://github.com/rashedulalam46)






