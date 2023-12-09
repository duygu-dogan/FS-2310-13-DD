import React, { useContext, useEffect, useState } from 'react'
import { Button, Card, Container, Form, InputGroup } from 'react-bootstrap'
import { AppContext } from '../Contexts/AppContext';
import User from './User';

const SearchForm = ({users}) => {
    const context =useContext(AppContext);
    const [userName, setUserName] = useState("");
    const [searchResult, setSearchResult] = useState([]);

    const handleSubmit = (e) => {
        e.preventDefault();
        if(userName){
            setUserName(userName);
            setUserName("");
            e.target.firstChild.focus()
        }else {
            alert("Please write the username you want to search")
        };
    }

    // useEffect(() => {
    //     const results = users.filter(person => person.includes(userName));
    //     setSearchResult(results);
    // }, [userName]);
    // useEffect(()=> { 
    //     context.users.filter(user => <User key={user.id} user={user} />)}, [userName])

  return (
    <>
    <Container className='py-3'>
        <Form onSubmit={handleSubmit}>
            <InputGroup>
                      <Form.Control onChange={(e) => setUserName(e.target.value)} value={userName} type='text' placeholder='Enter the user name you want to search...'>
                </Form.Control>
                <Button variant='primary' type='submit' >Search</Button>
            </InputGroup>
        </Form>
    </Container>
    </>
  )
}

export default SearchForm