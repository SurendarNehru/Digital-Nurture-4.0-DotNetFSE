import React from 'react';
import BookDetails from './BookDetails';
import BlogDetails from './BlogDetails';
import CourseDetails from './CourseDetails';

function App() {
  const currentView = 'blog'; 

  
  if (currentView === 'book') {
    return <BookDetails />;
  } else if (currentView === 'blog') {
    return <BlogDetails />;
  } else if (currentView === 'course') {
    return <CourseDetails />;
  }
}

export default App;
