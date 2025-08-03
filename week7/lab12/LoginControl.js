import React, { useState } from 'react';
import GuestPage from './GuestPage';
import UserPage from './UserPage';

function LoginControl() {
  const [isLoggedIn, setIsLoggedIn] = useState(false);

  const handleLogin = () => setIsLoggedIn(true);
  const handleLogout = () => setIsLoggedIn(false);

  let button = isLoggedIn ? (
    <button onClick={handleLogout}>Logout</button>
  ) : (
    <button onClick={handleLogin}>Login</button>
  );

  let page = isLoggedIn ? <UserPage /> : <GuestPage />;

  return (
    <div>
      {button}
      {page}
    </div>
  );
}

export default LoginControl;
