import React from 'react'
import { Container } from 'react-bootstrap';

const Homepage = () => {
    return (
        <>
            <Container fluid>
                <div style={{height: "85vh"}} className='d-flex justify-content-center align-items-center flex-column'>
                    <h1 className='display-4 text-primary text-center'>Welcome!</h1>
                    <p className='display-5 text-success text-center fw-bold'>GitHub Finder</p>
                </div>
                
            </Container>
        </>
    )
}

export default Homepage;