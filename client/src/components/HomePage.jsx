import React from "react";
import homepageimg from "/hompage.jpg";

function HomePage() {
  return (
    <>
      <div className="flex flex-col min-h-screen">
        {/* Header */}

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
      </div>
    </>
  );
}

export default HomePage;
