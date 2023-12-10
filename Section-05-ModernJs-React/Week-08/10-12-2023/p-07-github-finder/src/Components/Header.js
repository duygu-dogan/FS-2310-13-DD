import React, { useContext } from 'react';
import {Navbar, Container, NavbarBrand, Nav, Button } from 'react-bootstrap';
import { NavLink } from 'react-router-dom';
import { AppContext } from '../Contexts/AppContext';

function Header() {
  const context = useContext(AppContext);
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
            <Button onClick={context.handleClearAllClick} className="nav-link" href="/search">Search</Button>
          
          </Nav>
        </Container>
      </Navbar>
    </>
  )
}

export default Header