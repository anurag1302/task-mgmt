import React from "react";

const Footer = () => (
  <footer className="bg-gray-800 text-white py-4">
    <div className="container mx-auto text-center">
      <p>
        &copy; {new Date().getFullYear()} Task Manager. All rights reserved.
      </p>
      <p>Made with ❤️ by TaskManager</p>
    </div>
  </footer>
);

export default Footer;
