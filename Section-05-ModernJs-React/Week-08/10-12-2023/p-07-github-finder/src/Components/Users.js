import React, { useContext } from 'react'
import { AppContext } from '../Contexts/AppContext'
import { Col, Container, Row } from 'react-bootstrap'
import User from './User'
import UserDetails from './UserDetails'

const Users = () => {
    const context = useContext(AppContext);

    return (
        <>
            <Container>
                <Row>
                    <Col xs={context.user.login ? 6 : 12} >
                        <Row>
                            {context.users.map(user => <User key={user.id} user={user} />)}

                        </Row>
                    </Col>
                    <Col xs={6}>
                        {context.user.login && <UserDetails login={context.user.login} />}
                    </Col>
                </Row>
            </Container>
        </>
    )
}

export default Users;