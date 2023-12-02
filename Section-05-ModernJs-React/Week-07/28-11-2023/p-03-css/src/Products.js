import { Container, Row, Col, Image, Button, Card } from "react-bootstrap";

import React from 'react'
import Product from "./Product";

function Products() {
    return (
        <Container>
            <Row>
                <Product productName={"iPhone 14"} productImgUrl={"https://picsum.photos/id/237/100/180"}></Product>
                <Product productName={"Vestel Buzdolabı"} productImgUrl={"https://picsum.photos/id/137/100/180"} ></Product>
                <Product productName={"Macbook Air M2"} productImgUrl={"https://picsum.photos/id/124/100/180"} ></Product>
                <Product productName={"Macbook Pro"} productImgUrl={"https://picsum.photos/id/187/100/180"} ></Product>
                <Product productName={"Logitech Mouse"} productImgUrl={"https://picsum.photos/id/104/100/180"} ></Product>
                <Product productName={"Samsung S23"} productImgUrl={"https://picsum.photos/id/127/100/180"} ></Product>

            </Row>
        </Container>
    )
}

export default Products