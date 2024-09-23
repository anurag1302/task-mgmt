import React from "react";
import homepageimg from "/hompage.jpg";

function HomePage() {
  return (
    <div className="flex flex-col items-center justify-center bg-gray-50 p-6 min-h-screen">
      <img
        src={homepageimg}
        alt="Task Management"
        className="mx-auto w-full max-w-xs sm:max-w-md h-auto rounded-lg shadow-lg"
      />
      <h1 className="text-3xl sm:text-4xl font-bold text-gray-800 mt-6">
        Welcome to Task Management
      </h1>
      <p className="text-md sm:text-lg text-gray-600 mt-4">
        Streamline your workflow and stay organized with our task management
        system.
      </p>
    </div>
  );
}

export default HomePage;
