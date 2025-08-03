# BloggerApp - ReactJS Hands-on Lab

## Suenda N

This is a simple React application created as part of the **ReactJS Hands-on Lab**. 
The app demonstrates **conditional rendering** using multiple components.

---

## Objectives

* Demonstrate various ways of conditional rendering in React
* Render multiple components based on conditions
* Use React `map()` and keys (optional extensions)
* Understand component extraction and modularization

---

##  Prerequisites

Make sure you have the following installed:

* Node.js (LTS): [https://nodejs.org](https://nodejs.org)
* npm (comes with Node.js)
* Visual Studio Code: [https://code.visualstudio.com](https://code.visualstudio.com)

---

## How to Setup and Run

1. **Create the App:**

   ```
   npx create-react-app bloggerapp
   cd bloggerapp
   ```

2. **Replace/Add Components:**

   Add the following files inside `src/`:

   * BookDetails.js
   * BlogDetails.js
   * CourseDetails.js
   * Modify App.js to use conditional rendering

3. **Start the App:**

   ```
   npm start
   ```

   Open: [http://localhost:3000/](http://localhost:3000/)

---

## Components

**1. BookDetails**
Displays information about a book section.

**2. BlogDetails**
Displays information about blog posts.

**3. CourseDetails**
Displays information about courses offered.

---

## Conditional Rendering Methods

1. if-else Statement
2. Ternary Operator (`? :`)
3. Logical AND (`&&`)

You can switch between these methods in `App.js` to explore how React conditionally renders components.

---

## Output
<img width="1920" height="1080" alt="Screenshot 2025-08-03 235548" src="https://github.com/user-attachments/assets/b474f744-16f5-4faa-96f2-3004a69bbf0a" />
<img width="1920" height="1080" alt="Screenshot 2025-08-03 235611" src="https://github.com/user-attachments/assets/01f52119-f8ce-4899-abf1-dcba0816db21" />
<img width="1920" height="1080" alt="Screenshot 2025-08-03 235701" src="https://github.com/user-attachments/assets/ae0cf746-f10f-4116-8b8d-5ca201489ddf" />
<img width="1920" height="1080" alt="Screenshot 2025-08-03 235433" src="https://github.com/user-attachments/assets/d479175b-90db-43d8-9603-b33e304ac79c" />


## Conclusion

 Created a React app named `bloggerapp`
 Implemented 3 components: BookDetails, BlogDetails, CourseDetails
 Demonstrated multiple types of conditional rendering
 Verified the output in browser using `npm start`

---

