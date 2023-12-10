import React from 'react'
import { Col, ListGroup } from 'react-bootstrap'

const UserRepo = ({userRepoName, userRepoUrl}) => {
  return (
    <>
      <Col xs={12}>
        <ListGroup.Item target='_blank' action href={userRepoUrl}>
        {userRepoName}
        </ListGroup.Item>
      </Col>
    </>
  )
}

export default UserRepo