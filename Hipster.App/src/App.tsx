import React from "react";
import logo from "./logo.svg";
import "./App.css";
import config from "./config";

interface Book {
  id: number;
  title: string;
  author: string;
}

function BookList() {
  const [books, setBooks] = React.useState<Book[]>([]);
  React.useEffect(() => {
    fetch(config.API_URL)
      .then((response) => response.json())
      .then((json) => setBooks(json));
  }, []);

  if (!books) {
    return <div>Loading...</div>;
  }

  return (
    <div>
      <h1>Books</h1>

      {books.map((book) => (
        <div key={book.id}>
          <h2>{book.title}</h2>
          <h3>{book.author}</h3>
        </div>
      ))}
    </div>
  );
}

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />

        <BookList />
      </header>
    </div>
  );
}

export default App;
