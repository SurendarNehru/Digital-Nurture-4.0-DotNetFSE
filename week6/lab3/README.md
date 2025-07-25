##  Assignment – ReactJS Hands-on Lab Report

**Student:** Surendar N

**Lab Title:** Create and Render Functional Component in React

**Environment:** VS Code v9, Windows OS, Node.js, NPM

**Project Name:** `scorecalculatorapp`

**Estimated Time:** 30 minutes

---

## Objectives

* Explain React components
* Identify differences between components and JavaScript functions
* Understand the types of components
* Explain class components and function components
* Define constructor and `render()` method
* Learn how to:

  * Create a functional component
  * Apply styles using CSS
  * Render and pass props to a component

---

## Prerequisites Installed

*  Node.js (via [https://nodejs.org](https://nodejs.org))
*  NPM (installed automatically with Node.js)
*  Visual Studio Code (v9)
*  React app initialized using `create-react-app` CLI

---

## Steps Performed

### 1. Created React App

In terminal:

```
npx create-react-app scorecalculatorapp
cd scorecalculatorapp
```

### 2. Created Folder for Components

Created file:

```
CalculateScore.js
```

### 3. Wrote Functional Component: `CalculateScore.js`

```
import React from "react";
import "../Stylesheets/mystyle.css";

function CalculateScore(props) {
  const average = props.total / props.goal;

  return (
    <div className="score-container">
      <h2>Student Score Calculator</h2>
      <p><strong>Name:</strong> {props.name}</p>
      <p><strong>School:</strong> {props.school}</p>
      <p><strong>Total Marks:</strong> {props.total}</p>
      <p><strong>Goal:</strong> {props.goal}</p>
      <p><strong>Average:</strong> {average.toFixed(2)}</p>
    </div>
  );
}

export default CalculateScore;
```

---

### 4. Created Stylesheet: `src/Stylesheets/mystyle.css`

```
.score-container {
  background-color: #f0f0f0;
  padding: 20px;
  border-radius: 10px;
  width: 400px;
  margin: auto;
  margin-top: 40px;
  box-shadow: 0 0 10px #ccc;
  font-family: Arial, sans-serif;
}
```

---

### 5. Modified App.js to Render Component

```
import React from 'react';
import './App.css';
import CalculateScore from './Components/CalculateScore';

function App() {
  return (
    <div className="App">
      <CalculateScore
        name="Surendar N"
        school="Saveetha Engineering College"
        total={450}
        goal={5}
      />
    </div>
  );
}

export default App;
```

---

### 6. Ran the App

In terminal:

```bash
npm start
```

✅ App launched at:
[http://localhost:3001](http://localhost:3001)

---

##  Output Screenshot (Optional)

<img width="1920" height="1080" alt="Screenshot 2025-07-25 152931" src="https://github.com/user-attachments/assets/ac718d74-b050-4efa-a3dc-879147b0fcd1" />

---

## conclusion

* Successfully created and ran a React functional component
* Applied props, calculations, and CSS styling
* Launched and verified output on browser
* Learned key React concepts like components, props, and styling


