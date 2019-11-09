import React from "react";
import { Link } from "react-router-dom"

function HomePage() {
  return (
    <div className="jumbotron">
      <h1>Examen Parcial Ciclo 2</h1>
      <p>Dinorah  Martinez</p>
      <Link to="about" className="btn btn-primary">About</Link>
    </div>
  );
}

export default HomePage;