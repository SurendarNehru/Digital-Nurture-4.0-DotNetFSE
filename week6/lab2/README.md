### Assignment – ReactJS Hands-on Lab

**Student:** Surendar N

**Lab Title:** Student Management Portal using ReactJS

**Environment:** VS Code v9, Windows OS, Node.js, NPM

**Estimated Time:** 30 minutes

---

## Objectives

* Understand React components
* Identify the difference between JavaScript functions and React components
* Define class and functional components
* Understand the role of `constructor()` and `render()` in class components
* Create multiple components and reuse them
* Render components using JSX
* Organize components into folders
* Test a basic React app using browser preview

---

## Prerequisites

The following are required:

* Node.js and NPM
* Visual Studio Code
* Internet connection to download React dependencies

---

## Setup Instructions (Step-by-Step)

### Step 1: Install Node.js and NPM

* Download and install Node.js from: [https://nodejs.org](https://nodejs.org)
* Verify installation using:

```
node -v
npm -v
```

---

### Step 2: Create a New React App

```
npx create-react-app StudentApp
```

---

### Step 3: Open Project in Visual Studio Code

```
cd StudentApp
code .
```

---

### Step 4: Create Components Folder and Files

1. Inside the `src` folder, create a new folder named `Components`
2. Inside the `Components` folder, create three files:

   * `Home.js`
   * `About.js`
   * `Contact.js`

---

### Step 5: Add Component Code

#### Home.js

```
import React from 'react';

function Home() {
  return (
    <div>
      <h2>Welcome to the Home page of Student Management Portal</h2>
    </div>
  );
}

export default Home;
```

#### About.js

```
import React from 'react';

function About() {
  return (
    <div>
      <h2>Welcome to the About page of the Student Management Portal</h2>
    </div>
  );
}

export default About;
```

#### Contact.js

```
import React from 'react';

function Contact() {
  return (
    <div>
      <h2>Welcome to the Contact page of the Student Management Portal</h2>
    </div>
  );
}

export default Contact;
```

---

### Step 6: Modify App.js

Navigate to `src/App.js` and replace existing code with:

```
import React from 'react';
import './App.css';
import Home from './Components/Home';
import About from './Components/About';
import Contact from './Components/Contact';

function App() {
  return (
    <div className="App">
      <Home />
      <About />
      <Contact />
    </div>
  );
}

export default App;
```

---

### Step 7: Run the Application

```
npm start
```

* This opens the browser at: `http://localhost:3000`
* Output displayed:

  * Welcome to the Home page...
  * Welcome to the About page...
  * Welcome to the Contact page...

---

## Outcome

<img width="1920" height="1080" alt="Screenshot 2025-07-24 111424" src="https://github.com/user-attachments/assets/8f1471fc-ac7d-4ca0-b67a-7e5afefacf58" />


---

## Concepts Practiced

* Functional React components
* Folder structure under `src`
* JSX syntax to return HTML-like views
* Import and reuse of components
* Development server preview (`npm start`)
* Understanding basic component rendering in React
