# Assignment – ReactJS Hands-on Lab – Component Lifecycle

**Student:** Surendar N

**Lab Title:** React Class Components – Lifecycle Methods

**Environment:** VS Code v9, Windows OS, Node.js v18+, NPM

**Estimated Time:** 60 minutes

---

## Objectives

* Understand the need and benefits of component lifecycle methods.
* Identify various lifecycle hook methods in React.
* Learn the order of component rendering in React.
* Implement `componentDidMount()` to fetch data.
* Use `componentDidCatch()` to gracefully handle errors in React components.

---

## Prerequisites

Before starting the lab, ensure the following are installed:

* Node.js and NPM → [https://nodejs.org](https://nodejs.org)
* Visual Studio Code → [https://code.visualstudio.com](https://code.visualstudio.com)
* React Developer Tools (Chrome Extension – optional)

---

## Steps Performed

### 1. Create React App

Created a new React app named `blogapp` using:

```
npx create-react-app blogapp
```

### 2. Opened the Project in VS Code

```
cd blogapp
code .
```

---

### 3. Created `Post.js`

A class-based component to display individual blog post title and content:

```
import React from 'react';

class Post extends React.Component {
  render() {
    const { title, body } = this.props;
    return (
      <div>
        <h3>{title}</h3>
        <p>{body}</p>
      </div>
    );
  }
}

export default Post;
```

---

### 4. Created `Posts.js`

This component:

* Initializes state in constructor
* Defines `loadPosts()` using Fetch API
* Implements `componentDidMount()` to fetch post data
* Implements `componentDidCatch()` to show alert on errors
* Renders a list of posts using `<Post />` component

```
import React from 'react';
import Post from './Post';

class Posts extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      posts: [],
      hasError: false
    };
  }

  loadPosts() {
    fetch('https://jsonplaceholder.typicode.com/posts')
      .then(res => res.json())
      .then(data => {
        this.setState({ posts: data });
      })
      .catch(error => {
        console.error("Error loading posts:", error);
      });
  }

  componentDidMount() {
    this.loadPosts();
  }

  componentDidCatch(error, info) {
    this.setState({ hasError: true });
    alert('An error occurred in Posts component');
  }

  render() {
    if (this.state.hasError) {
      return <h2>Something went wrong.</h2>;
    }

    return (
      <div>
        <h2>Blog Posts</h2>
        {this.state.posts.map(post => (
          <Post key={post.id} title={post.title} body={post.body} />
        ))}
      </div>
    );
  }
}

export default Posts;
```

---

### 5. Modified `App.js`

Replaced default content with:

```
import React from 'react';
import Posts from './Posts';

function App() {
  return (
    <div className="App">
      <Posts />
    </div>
  );
}

export default App;
---

```
### 7. Ran the App

```
npm start
```

Result: Opened in browser at `http://localhost:3000` showing a list of blog posts fetched from an API.

---

## Output

<img width="1920" height="1080" alt="Screenshot 2025-07-25 155041" src="https://github.com/user-attachments/assets/39d940a8-09d0-441c-ae69-38dc124ddbbd" />


---

##  Cnclusion

* Understood the React class component lifecycle.
* Learned how to fetch API data and update state dynamically.
* Applied error handling within components.
* Practiced modular design using separate component files.


