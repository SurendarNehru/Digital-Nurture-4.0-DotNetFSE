**ReactJS Event Handling Hands-On Lab**

**Surendar N**

This React application demonstrates the core concepts of **event handling** in React using functional components, including synthetic events, multiple event functions, and a simple currency converter.

---

**Objectives**

* Understand how React events work
* Use event handlers in functional components
* Work with synthetic events
* Use the `this` keyword where applicable
* Build interactive form elements

---

**Prerequisites**

To run this application, you must have the following installed:

* Node.js (LTS version): [https://nodejs.org](https://nodejs.org)
* npm (comes with Node.js)
* Visual Studio Code (v9 or higher)

---

**Installation & Setup**

1. Create the app using Create React App:

   ```
   npx create-react-app eventexamplesapp
   cd eventexamplesapp
   ```

2. Create a file `src/EventExamples.js` and implement your logic (like counter, say welcome, synthetic events, and currency converter).

3. In `App.js`, import and use the component:

   ```
   import EventExamples from './EventExamples';
   ```

4. Start the app:

   ```
   npm start
   ```

   It will open in your browser at `http://localhost:3000`.

---

**Features Implemented**

* **Counter Functionality**

  * Increment and Decrement buttons
  * “Increment” button invokes multiple functions (increase counter + say hello)

* **Say Welcome Button**

  * Calls a function with a message argument

* **Synthetic Event**

  * “Click me” button triggers an alert using React’s synthetic event system

* **Currency Converter**

  * Converts Indian Rupees to Euro using a simple formula on button click
  * Displays the converted amount

---

## OUTPUT

<img width="1920" height="1080" alt="Screenshot 2025-08-03 193921" src="https://github.com/user-attachments/assets/2612d75e-9568-4a33-84ae-e1b1f77e43ea" />
<img width="1920" height="1080" alt="Screenshot 2025-08-03 193934" src="https://github.com/user-attachments/assets/d092bac7-13e0-4488-9842-be199834c0f5" />
<img width="1920" height="1080" alt="Screenshot 2025-08-03 194011" src="https://github.com/user-attachments/assets/b6b43f6b-06a9-4917-9509-7baba7b80a9e" />
<img width="1920" height="1080" alt="Screenshot 2025-08-03 194021" src="https://github.com/user-attachments/assets/da9f91c7-c601-4d02-9a23-537aa05dbc73" />
<img width="1920" height="1080" alt="Screenshot 2025-08-03 194039" src="https://github.com/user-attachments/assets/83f6f464-7090-4eb1-8b1d-e78e43a9fa9d" />

**Conclusion**

This hands-on lab introduces beginner-friendly event handling in React. 
It includes practical examples such as counters, alert messages, and input handling. 
Completing this will give you a strong base in building interactive React applications.

---

