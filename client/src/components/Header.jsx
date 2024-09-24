import { Link } from "react-router-dom";

const Header = () => (
  <header className="bg-gradient-to-r from-purple-600 to-violet-600 text-white p-4 shadow-lg">
    <nav className="container mx-auto flex flex-col sm:flex-row justify-between items-center">
      <Link to="/" className="text-xl">
        Home
      </Link>
      <div className="text-center mt-2 sm:mt-0">
        <h2 className="text-md sm:text-xl">Task Management System</h2>
      </div>
      <div className="flex">
        <Link to="/login" className="text">
          Login
        </Link>
        <Link to="/register" className="text">
          Register
        </Link>
      </div>
    </nav>
  </header>
);

export default Header;
