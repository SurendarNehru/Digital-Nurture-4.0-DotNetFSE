import React, { useState } from 'react';

function EventExamples() {
  const [count, setCount] = useState(0);
  const [rupees, setRupees] = useState('');
  const [euro, setEuro] = useState('');

  const increment = () => {
    setCount(count + 1);
    sayHello();
  };

  const decrement = () => setCount(count - 1);

  const sayHello = () => {
    alert('Hello! This is a static message.');
  };

  const sayWelcome = (message) => {
    alert(`Welcome Message: ${message}`);
  };

  const onPress = () => {
    alert('I was clicked');
  };

  const handleSubmit = () => {
    const converted = parseFloat(rupees) / 90; // Example conversion rate
    setEuro(converted.toFixed(2));
  };

  return (
    <div style={{ padding: '20px' }}>
      <h2>Counter: {count}</h2>
      <button onClick={increment}>Increment</button>
      <button onClick={decrement}>Decrement</button>

      <hr />

      <button onClick={() => sayWelcome('Welcome to ReactJS')}>Say Welcome</button>

      <hr />

      <button onClick={onPress}>Click me (Synthetic Event)</button>

      <hr />

      <h3>Currency Convertor</h3>
      <input
        type="text"
        placeholder="Enter amount in INR"
        value={rupees}
        onChange={(e) => setRupees(e.target.value)}
      />
      <button onClick={handleSubmit}>Convert to Euro</button>
      <p>Euro: {euro}</p>
    </div>
  );
}

export default EventExamples;
