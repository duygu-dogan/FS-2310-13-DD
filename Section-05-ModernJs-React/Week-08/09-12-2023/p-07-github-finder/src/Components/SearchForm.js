import React, { useContext, useState } from 'react'
import { Button, Container, Form, InputGroup } from 'react-bootstrap'
import { AppContext } from '../Contexts/AppContext';

const SearchForm = ({setResults}) => {
    const context =useContext(AppContext);
    const [input, setInput] = useState("");

    const handleSubmit = (e) => {
        e.preventDefault();
        if(input){
            context.getUser(input);
            setInput("");
            e.target.firstChild.focus()
        }else {
            alert("Please write the username you want to search")
        };
    }


  return (
    <>
    <Container className='py-3'>
        <Form onSubmit={ handleSubmit}>
            <InputGroup>
                      <Form.Control 
                      onChange={(e) => setInput(e.target.value)} 
                      value={input} 
                      type='text' 
                      placeholder='Enter the user name you want to search...'>
                </Form.Control>
                <Button variant='primary' type='submit'>Search</Button>
            </InputGroup>
        </Form>
    </Container>
    </>
  )
}

export default SearchForm