import { Col, Card, Button } from "react-bootstrap";

//productName=props, bir üst componentten bir alt componente veri almak istediğimizde 
function Product({productName, productImgUrl}) {
  return (
      <Col>
          <Card>
              <Card.Img variant="top" src={productImgUrl} width={100} />
              <Card.Body>
                  <Card.Title>{productName}</Card.Title>
                  <Card.Text>
                      Some quick example text to build on the card title and make up the
                      bulk of the card's content.
                  </Card.Text>
                  <Button variant="primary">Go somewhere</Button>
              </Card.Body>
          </Card>
      </Col>
  )
}

export default Product