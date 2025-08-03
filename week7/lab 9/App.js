import React from "react";
import ListofPlayers from "./ListofPlayers";
import IndianPlayersComponent from "./IndianPlayers";

function App() {
  const flag = true; // Set to false to test IndianPlayersComponent

  return (
    <div className="App">
      <h1> Cricket App</h1>
      {flag ? <ListofPlayers /> : <IndianPlayersComponent />}
    </div>
  );
}

export default App;
