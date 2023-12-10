import React, { useContext, useEffect } from 'react'
import { AppContext } from '../Contexts/AppContext';
import { Button, Card, CardBody, CloseButton, Col, Container, ListGroup, Row } from 'react-bootstrap';
import UserRepo from './UserRepo';

const UserDetails = ({ login }) => {
  const context = useContext(AppContext);
  // const { login } = useParams();
  useEffect(() => {
    context.getUser(login);
    context.getRepos(login);
  }, []);
  return (
    <>
      <Card>
          <Row>
            <Col xs={12}>
                <Card.Header className='d-flex justify-content-between align-items-center display-6 fs-3 fw-normal text-danger' >
                  {context.user.name} ({context.user.login})
              <CloseButton type='button' className='btn btn-close' onClick={() => context.setUser({})}></CloseButton>
                </Card.Header>
            </Col>
        </Row>
        <Row>
            <Row>
              <Col lg={6} md={12}>
                <Row>
                  <CardBody>
                    <Card.Img src={context.user.avatar_url} />
                    <div className='d-flex justify-content-around align-items-center mt-4'>
                      <Card.Title className='fs-6'>Followers: {context.user.followers}</Card.Title>
                      <Card.Title className='fs-6' >Following: {context.user.following}</Card.Title>
                    </div>
                  </CardBody>
                </Row>
              </Col>
              <Col lg={6} md={0}>
                <CardBody>
                  <ListGroup className='flex-row flex-wrap'>
                    {context.userRepos.map(userRepo => <UserRepo userRepoName={userRepo.name} key={userRepo.id} userRepoUrl={userRepo.html_url} />)}
                  </ListGroup>
                </CardBody>
              </Col>
            </Row>
          </Row>
        </Card>
    </>
  )
}

export default UserDetails;