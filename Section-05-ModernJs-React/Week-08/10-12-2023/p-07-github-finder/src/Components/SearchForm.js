import React, { useContext, useEffect } from 'react'
import { Button, Container, Form, InputGroup } from 'react-bootstrap'
import { AppContext } from '../Contexts/AppContext';

const SearchForm = () => {
    const context = useContext(AppContext);
    

    const handleSubmit = (e) => {
        e.preventDefault();
        if (context.keyword) {
            context.searchUsers(context.keyword);
            e.target.firstChild.focus();
        } else {
            alert("Please write the username you want to search")
        };
    }

    const handleChange = (value) => {
        context.setKeyword(value);
        }
    
    useEffect(() => {
        context.handleClearAllClick()
    }, [])

    return (
        <>
            <Container className='py-3'>
                <Form onSubmit={handleSubmit}>
                    <InputGroup>
                        <Form.Control
                            onChange={(e) => handleChange(e.target.value)}
                            value={context.keyword}
                            type='text'
                            placeholder='Enter the user name you want to search...'>
                        </Form.Control>
                        <Button variant='primary' type='submit'>Search</Button>
                    </InputGroup>
                    {context.isClearBtnShow &&
                        <div className='d-grid mt-2'>
                            <Button variant='danger' onClick={context.handleClearAllClick}>Clear All</Button>
                        </div>
                    }
                </Form>
            </Container>
        </>
    )
}

export default SearchForm