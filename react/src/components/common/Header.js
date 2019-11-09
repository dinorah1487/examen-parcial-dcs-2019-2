import React from "react";
import { NavLink } from "react-router-dom";

function Header() {
  const activeStyle = { color: "orange" };
  return (
    <nav>
      <NavLink activeStyle={activeStyle} exact to="/">
        Inicio
      </NavLink>
      {" | "}
      <NavLink activeStyle={activeStyle} to="/courses">
        Cuentas Bancarias
      </NavLink>
      {" | "}
      <NavLink activeStyle={activeStyle} to="/about">
        Acerca de 
      </NavLink>
    </nav>
  );
}

export default Header;