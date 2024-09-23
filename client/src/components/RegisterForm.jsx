import React, { useState } from "react";

const RegisterForm = () => {
  const [formData, setFormData] = useState({
    firstName: "",
    lastName: "",
    email: "",
    password: "",
    confirmPassword: "",
    dateOfBirth: "",
  });

  const [errors, setErrors] = useState({});

  const handleChange = (e) => {
    setFormData({ ...formData, [e.target.name]: e.target.value });
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    // Form validation and handling logic here
    console.log("Form submitted:", formData);
  };

  return (
    <div className="max-w-lg mx-auto p-4 sm:p-6 bg-white rounded-lg shadow-md mt-8">
      <h2 className="text-2xl font-bold text-center mb-6">Register</h2>
      <form onSubmit={handleSubmit}>
        <div className="mb-4">
          <label className="block font-semibold mb-2" htmlFor="firstName">
            First Name
          </label>
          <input
            type="text"
            name="firstName"
            id="firstName"
            className="w-full p-2 border border-gray-300 rounded"
            value={formData.firstName}
            onChange={handleChange}
          />
        </div>

        <div className="mb-4">
          <label className="block font-semibold mb-2" htmlFor="lastName">
            Last Name
          </label>
          <input
            type="text"
            name="lastName"
            id="lastName"
            className="w-full p-2 border border-gray-300 rounded"
            value={formData.lastName}
            onChange={handleChange}
          />
        </div>

        <div className="mb-4">
          <label className="block font-semibold mb-2" htmlFor="email">
            Email
          </label>
          <input
            type="email"
            name="email"
            id="email"
            className="w-full p-2 border border-gray-300 rounded"
            value={formData.email}
            onChange={handleChange}
          />
        </div>

        <div className="mb-4">
          <label className="block font-semibold mb-2" htmlFor="password">
            Password
          </label>
          <input
            type="password"
            name="password"
            id="password"
            className="w-full p-2 border border-gray-300 rounded"
            value={formData.password}
            onChange={handleChange}
          />
        </div>

        <div className="mb-4">
          <label className="block font-semibold mb-2" htmlFor="confirmPassword">
            Confirm Password
          </label>
          <input
            type="password"
            name="confirmPassword"
            id="confirmPassword"
            className="w-full p-2 border border-gray-300 rounded"
            value={formData.confirmPassword}
            onChange={handleChange}
          />
        </div>

        <div className="mb-4">
          <label className="block font-semibold mb-2" htmlFor="dateOfBirth">
            Date of Birth
          </label>
          <input
            type="date"
            name="dateOfBirth"
            id="dateOfBirth"
            className="w-full p-2 border border-gray-300 rounded"
            value={formData.dateOfBirth}
            onChange={handleChange}
          />
        </div>

        <div className="text-center">
          <button
            type="submit"
            className="bg-purple-600 text-white py-2 px-4 rounded hover:bg-purple-700 transition duration-300"
          >
            Register
          </button>
        </div>
      </form>
    </div>
  );
};

export default RegisterForm;
