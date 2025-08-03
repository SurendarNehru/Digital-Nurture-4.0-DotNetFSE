import React from "react";
import { OddPlayers } from "./OddPlayers";

// Merging two arrays using spread operator
const T20Players = ["First Player", "Second Player", "Third Player"];
const RanjiTrophyPlayers = ["Fourth Player", "Fifth Player", "Sixth Player"];
export const IndianPlayers = [...T20Players, ...RanjiTrophyPlayers];

const IndianPlayersComponent = () => {
  return (
    <div>
      <h2>All Indian Players:</h2>
      <ul>
        {IndianPlayers.map((player, index) => (
          <li key={index}>{player}</li>
        ))}
      </ul>

      <h2>Odd Team Members:</h2>
      <OddPlayers {...[IndianPlayers]} />
    </div>
  );
};

export default IndianPlayersComponent;
