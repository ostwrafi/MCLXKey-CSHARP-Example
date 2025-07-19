# 🚀 MCLXKey C# Example

This project is a Windows Forms application demonstrating how to use the MCLXKey authentication API in C#. It provides a simple login interface and integrates with the MCLXKey API for user authentication.

## ✨ Features
- 🔐 User login with username, password, and HWID
- 🌐 Integration with MCLXKey API via HTTP POST (JSON)
- 🖥️ Modern Windows Forms UI
- 🛠️ Example structure for extending with registration, license, and 2FA

## 📁 Project Structure
- `Login.cs` / `Login.Designer.cs`: Login form and logic
- `Main.cs` / `Main.Designer.cs`: Main application window after login
- `MCLXKey.cs`: Contains the `MCLXKeyAuth` class for API communication
- `Program.cs`: Application entry point
- `packages/`: Contains dependencies (e.g., Newtonsoft.Json)

## 🏁 Getting Started

### 📝 Prerequisites
- 💻 .NET Framework (4.x recommended)
- 🛠️ Visual Studio or compatible C# IDE

### ⚙️ Setup
1. 📥 Clone or download this repository.
2. 🗂️ Open `Loader.sln` in Visual Studio.
3. 🔄 Restore NuGet packages if needed (Newtonsoft.Json is required).
4. In `MCLXKey.cs`, replace the following placeholders with your actual values:
   - `projectsecretid = "your_project_secret_id_here"`
   - `userid = "your_user_id_here"`
   - `special_token = "your_special_token_here"` (if required)
5. ▶️ Build and run the project.

### 🧑‍💻 Usage
- Enter your username and password in the login form.
- The application will send your credentials and HWID to the MCLXKey API.
- On successful authentication, the main window will open.

## 🛠️ Customization
- Extend the UI for registration, license activation, or 2FA as needed.
- Update API endpoint or request fields in `MCLXKey.cs` to match your backend.

## 📦 Dependencies
- [Newtonsoft.Json](https://www.newtonsoft.com/json) (for JSON serialization)

## 📄 License
This project is provided as an example. Please check the LICENSE file or contact the author for usage terms.

## 🙏 Credits
- MCLXKey API
- Example by KeyAuth community

