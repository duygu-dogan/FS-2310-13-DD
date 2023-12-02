import { Container, Row, Col, Nav, Navbar, Image, Button, Card } from "react-bootstrap";


function Header() {
  return (
      <Container>
          <Row>
              <Col md={3} >Bright-FS-2310-13</Col>
              <Col md={9} className='text-end' ><Navbar expand="lg" className="bg-body-tertiary">
                  <Container>
                      <Navbar.Brand href="#home">React-Bootstrap</Navbar.Brand>
                      <Navbar.Toggle aria-controls="basic-navbar-nav" />
                      <Navbar.Collapse id="basic-navbar-nav">
                          <Nav className="ms-auto">
                              <Nav.Link href="#home">Home</Nav.Link>
                              <Nav.Link href="#link">Link</Nav.Link>
                          </Nav>
                      </Navbar.Collapse>
                  </Container>
              </Navbar></Col>
          </Row>
      </Container>
  )
}

export default Header