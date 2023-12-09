import React, { useContext, useEffect } from 'react'
import { useParams } from 'react-router-dom'
import { AppContext } from '../../Contexts/AppContext';
import { Card, CardBody, Col, Container, ListGroup, Row } from 'react-bootstrap';
import UserRepo from '../../Components/UserRepo';

const UserDetailsPage = () => {
  const context = useContext(AppContext);
  const { login } = useParams();
  useEffect(() => {
    context.getUser(login);
    context.getRepos(login);
  }, []);
  return (
    <>
      <Container className='w-75 py-4'>
        <Card>
          <Row>
            <Row>
              <Col xs={12}>
                <Card.Header className='display-6 text-danger' >
                  {context.user.name} ({context.user.login})
                </Card.Header>
              </Col>
            </Row>
            <Row>
              <Col xs={4}>
                <CardBody>
                  <Card.Img src={context.user.avatar_url} />
                  <div className='d-flex justify-content-around align-items-center mt-4'>
                    <Card.Title className='fs-6'>Followers: {context.user.followers}</Card.Title> 
                    <Card.Title className='fs-6' >Following: {context.user.following}</Card.Title> 
                  </div>
                </CardBody>
              </Col>
              <Col xs={8}>
                <CardBody>
                  <ListGroup className='flex-row flex-wrap'>
                    {context.userRepos.map(userRepo => <UserRepo userRepoName={userRepo.name} key={userRepo.id} userRepoUrl={userRepo.html_url} />)}
                  </ListGroup>
                </CardBody>
              </Col>
            </Row>


          </Row>
        </Card>
      </Container>
    </>
  )
}

export default UserDetailsPage