### Assignment – ReactJS Hands-on Lab

**Student:** Surendar N

**Lab Title:** Introduction to React and Creating First React App

**Environment:** VS Code v9, Windows OS, Node.js, NPM

**Estimated Time:** 30 minutes

---

## Objectives

* Define SPA (Single Page Application) and its benefits
* Explain the difference between SPA and MPA (Multi Page Application)
* Define React and its working
* Understand Virtual DOM
* Explore the pros and cons of SPA
* List features of React
* Learn to set up a React environment
* Use `create-react-app` to create a new project
* Run a simple React app that displays a custom heading

---

## Prerequisites

To complete this hands-on lab, the following are required:

* Node.js and NPM
* Visual Studio Code
* Internet connection for package downloads

---

## Setup Instructions (Step-by-Step)

### Step 1: Install Node.js and NPM

* Download and install Node.js 
* Verify installation using:

  ```
  node -v
  npm -v
  ```

### Step 2: Install Create React App (CRA) globally

```
npm install -g create-react-app
```

### Step 3: Create New React Application

```
npx create-react-app myfirstreact
```

### Step 4: Open Project in VS Code

```
cd myfirstreact
code .
```

### Step 5: Edit App.js

* Navigate to `src/App.js`
* Delete existing code and replace with:

  ```
  import React from 'react';

  function App() {
    return (
      <div>
        <h1>Welcome to the first session of React</h1>
      </div>
    );
  }

  export default App;
  ```

### Step 6: Run the Application

```
npm start
```

* This opens a browser at: `http://localhost:3000`
* Output displayed: **Welcome to the first session of React**

---

## Outcome

<img width="1920" height="1080" alt="Screenshot 2025-07-24 105812" src="https://github.com/user-attachments/assets/2df6f15b-9964-4392-bf4f-f8392d6ef9b1" />

---

## Concepts Practiced

* Single Page Application architecture
* React component structure
* JSX syntax
* Project bootstrapping using `create-react-app`
* Editing and running components
* React development server and live preview

