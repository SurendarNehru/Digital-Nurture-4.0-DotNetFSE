# CricketApp - ReactJS ES6 Hands-On

This project demonstrates the use of modern **ES6 features** in a ReactJS application. You will explore and apply concepts such as:

* `map()` for rendering lists
* Arrow functions for filtering
* Destructuring for picking values
* Spread operator to merge arrays

---

## Objectives

* Use `map()` method to list players
* Filter players using **arrow functions**
* Use **destructuring** to extract team members
* Merge two arrays using the **spread operator**
* Display components conditionally using a flag

---

## Prerequisites

* Node.js (LTS version recommended)
* npm (comes with Node.js)
* Visual Studio Code

---

## How to Run the App

1. Create the React App:

```
npx create-react-app cricketapp  
cd cricketapp
```

2. Replace the contents of the `src/` folder with:

* App.js
* ListofPlayers.js
* IndianPlayers.js
* OddPlayers.js

3. Start the server:

```
npm start
```

4. Open `http://localhost:3001` in your browser.

---
### ListofPlayers

* Displays a list of 11 players and their scores
* Filters and shows players with `score <= 70` using arrow functions

### IndianPlayers

* Merges two arrays (`T20Players` and `RanjiTrophyPlayers`)
* Displays combined array
* Uses destructuring to show odd-positioned players

### App.js

* A simple `flag` variable controls what component is shown:

```
const flag = true;  // shows ListofPlayers  
const flag = false; // shows IndianPlayers
```

---

## ES6 Concepts Covered

* Arrow Functions
* Array map()
* Array filter()
* Destructuring Assignment
* Spread Operator

---

##  Output 

<img width="1920" height="1080" alt="Screenshot 2025-08-03 111427" src="https://github.com/user-attachments/assets/30ef1486-cbab-45b5-a942-f7f52ae3fab7" />

---

## Conclusion

This hands-on project effectively demonstrates how powerful and practical ES6 features can be when building modern web applications with ReactJS. 
By implementing map(), arrow functions, destructuring, and the spread operator, you gain a strong foundation in writing clean, readable, and efficient JavaScript code.

---
