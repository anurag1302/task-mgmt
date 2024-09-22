import React from "react";
import homepageimg from "/hompage.jpg";

import "./App.css";

function App() {
  return (
    <>
      <div className="flex flex-col min-h-screen">
        {/* Header */}
        <header className="bg-gradient-to-r from-purple-600 to-violet-600 text-white p-4 shadow-lg">
          <div className="container mx-auto flex justify-between items-center">
            {/* Logo */}
            <div className="flex items-center space-x-2">
              <img
                src="https://via.placeholder.com/50"
                alt="Logo"
                className="w-8 h-8 sm:w-10 sm:h-10"
              />
              <h1 className="text-xl sm:text-xl font-bold">Task Manager</h1>
            </div>
            {/* Title */}
            <div className="hidden md:flex">
              <h2 className="text-md sm:text-xl">Task Management System</h2>
            </div>
            {/* User Button */}
            <button className="bg-white text-purple-600 px-3 py-1 sm:px-4 sm:py-2 rounded-full shadow hover:bg-gray-100 transition duration-300">
              User
            </button>
          </div>
        </header>

        {/* Main Content */}
        <main className="flex-grow flex flex-col justify-center items-center bg-gray-50 p-6 sm:p-8">
          <div className="text-center space-y-6">
            <img
              src={homepageimg}
              alt="Task Management"
              className="mx-auto w-64 sm:w-96 rounded-lg shadow-lg"
            />
            <h1 className="text-3xl sm:text-4xl font-bold text-gray-800">
              Welcome to Task Management
            </h1>
            <p className="text-md sm:text-lg text-gray-600">
              Streamline your workflow and stay organized with our task
              management system. Create, update, and track your tasks
              efficiently!
            </p>
          </div>
        </main>

        {/* Footer */}
        <footer className="bg-gray-800 text-white py-4">
          <div className="container mx-auto text-center">
            <p>
              &copy; {new Date().getFullYear()} Task Manager. All rights
              reserved.
            </p>
            <p>Made with ❤️ by TaskManager</p>
          </div>
        </footer>
      </div>
    </>
  );
}

export default App;
