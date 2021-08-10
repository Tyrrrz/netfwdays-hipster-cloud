import React from "react";
import logo from "./logo.svg";
import "./App.css";
import clients from "./api";
import { useQuery } from "react-query";

function BookList() {
  const booksQuery = useQuery("all-books", () => clients.books.getAllBooks());

  if (booksQuery.isLoading) {
    return <div>Loading...</div>;
  }

  if (booksQuery.error) {
    return <div>Error: {(booksQuery.error as {}).toString()}</div>;
  }

  return (
    <div>
      <h1>Books</h1>

      {booksQuery.data!.map((book) => (
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
