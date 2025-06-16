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
  "email": "rashed@gmail.com",
  "age": 30,
  "phoneNumber": "123",
  "website": "https://domain.com",
  "creditCard": "4111111111111111",
  "password": "123456",
  "confirmPassword": "123456"
}
```



