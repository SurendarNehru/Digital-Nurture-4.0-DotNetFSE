import React from "react";

const ListofPlayers = () => {
  const players = [
    { name: "Virat", score: 30 },
    { name: "Rohit", score: 75 },
    { name: "Rahul", score: 60 },
    { name: "Dhoni", score: 83 },
    { name: "Iyer", score: 75 },
    { name: "Ashwin", score: 35 },
    { name: "Jadeja", score: 65 },
    { name: "Bumrah", score: 20 },
    { name: "Shami", score: 55 },
    { name: "Chahal", score: 80 },
    { name: "Gill", score: 78 },
  ];

  // Using arrow function to filter scores <= 70
  const players70 = players.filter((item) => item.score <= 70);

  return (
    <div>
      <h2>All Players:</h2>
      <ul>
        {players.map((item, index) => (
          <li key={index}>
            Mr. {item.name} <span>{item.score}</span>
          </li>
        ))}
      </ul>

      <h2>Filtered Players (Score ≤ 70):</h2>
      <ul>
        {players70.map((item, index) => (
          <li key={index}>
            {item.name} - {item.score}
          </li>
        ))}
      </ul>
    </div>
  );
};

export default ListofPlayers;
