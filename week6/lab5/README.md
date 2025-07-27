**ReactJS Hands-on Lab – Styling Components**

**Student:** Surendar N

**Lab Title:** Styling React Components using CSS Module and Inline Style

**Environment:** Windows OS, VS Code v9, Node.js, React 17

**Estimated Time:** 30 minutes

**Lab Type:** Frontend (ReactJS)

---

**Objectives:**

* Understand the need for styling React components
* Learn how to apply CSS Modules in a React app
* Use inline style to conditionally format components
* Apply consistent and scoped styles using className
* Style HTML elements using tag selectors

---

**Prerequisites:**

* Node.js and npm installed
* Visual Studio Code
* A starter React project (Cohort Tracker)

---

**Steps Followed:**

1. **Project Setup:**

   * Unzipped and opened the provided React application in VS Code.
   * Installed all dependencies using the `npm install` command.

2. **Created a CSS Module:**

   * Created a file named `CohortDetails.module.css`.
   * Added the following CSS styles:

     ```
     .box {
       width: 300px;
       display: inline-block;
       margin: 10px;
       padding: 10px 20px;
       border: 1px solid black;
       border-radius: 10px;
     }

     dt {
       font-weight: 500;
     }
     ```

3. **Updated the Component:**

   * Opened the `CohortDetails.js` file.
   * Imported the CSS module using: `import styles from './CohortDetails.module.css';`
   * Applied the `.box` class using `className={styles.box}`.
   * Applied dynamic inline style to `<h3>` tag using:

     ```
     style={{ color: status === 'ongoing' ? 'green' : 'blue' }}
     ```

4. **Used Props to Display Data:**

   * Used `props.cohort` to show:

     * Cohort Name
     * Start Date
     * Current Status
     * Coach Name
     * Trainer Name

5. **Ran and Tested the App:**

   * Ran the application using `npm start`.
   * Verified output in the browser.
   * Confirmed that styles were applied correctly and heading color changed based on status.

---

**Output:**

<img width="1912" height="1079" alt="Screenshot 2025-07-28 001331" src="https://github.com/user-attachments/assets/e82e3095-8a1e-4c91-b890-c384887ca8a3" />
<img width="1919" height="1079" alt="Screenshot 2025-07-28 001313" src="https://github.com/user-attachments/assets/fbcd5ff7-623b-4120-90c9-cf8e4ce10ded" />

---

**Conclusion:**

* How to style React components using CSS Modules.
* Use of className and scoped styling.
* How to apply conditional inline styles in JSX.
* React component structure and prop handling.
