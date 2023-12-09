import React from 'react';
import {Navbar, Container, NavbarBrand, Nav } from 'react-bootstrap';
import { NavLink } from 'react-router-dom';


function Header() {
  return (
    <>
      <Navbar bg='primary' variant='dark'> 
        <Container>
          <NavbarBrand>
            <NavLink className="nav-link" to="/">
              FS-2310-13 GitHub Finder App
            </NavLink>
          </NavbarBrand>
          <Nav className='ms-auto'>
            <NavLink className="nav-link" to="/">Home</NavLink>
            <NavLink className="nav-link" to="/search">Search</NavLink>
          </Nav>
        </Container>
      </Navbar>
    </>
  )
}

export default Header