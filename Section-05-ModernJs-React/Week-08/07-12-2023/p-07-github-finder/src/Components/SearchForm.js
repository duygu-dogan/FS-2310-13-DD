import React from 'react'
import { Button, Container, Form, InputGroup } from 'react-bootstrap'

const SearchForm = () => {
    const handleSubmit = (e) => {
        e.preventDefault();
        
    }
  return (
    <>
    <Container className='py-3'>
        <Form onSubmit={handleSubmit}>
            <InputGroup>
                <Form.Control placeholder='Enter the user name you want to search...'>
                </Form.Control>
                <Button variant='primary' type='submit' >Search</Button>
            </InputGroup>
        </Form>
    </Container>
    </>
  )
}

export default SearchForm