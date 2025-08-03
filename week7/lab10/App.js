import React from 'react';
import './App.css';
import officeImg from './office.jpg';

function App() {
  const officeList = [
    { name: "Office A", rent: 55000, address: "Chennai" },
    { name: "Office B", rent: 75000, address: "Bangalore" },
    { name: "Office C", rent: 60000, address: "Coimbatore" },
    { name: "Office D", rent: 110000, address: "mumbai" }
  ];

  return (
    <div className="App">
      <h1>Office Space Rental</h1>
      <img src={officeImg} alt="Office Space" />      <div>
        {officeList.map((office, index) => (
          <div key={index}>
            <h2>{office.name}</h2>
            <p style={{ color: office.rent > 60000 ? 'green' : 'red' }}>
              Rent: ₹{office.rent}
            </p>
            <p>Address: {office.address}</p>
          </div>
        ))}
      </div>
    </div>
  );
}

export default App;
