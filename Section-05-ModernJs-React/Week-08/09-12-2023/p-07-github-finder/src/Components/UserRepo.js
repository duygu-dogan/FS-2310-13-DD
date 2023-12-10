import React from 'react'
import { ListGroup } from 'react-bootstrap'

const UserRepo = ({userRepoName, userRepoUrl}) => {
  return (
    <>
        <ListGroup.Item className='w-25 border-top' target='_blank' action href={userRepoUrl}>
        {userRepoName}
        </ListGroup.Item>
       
    </>
  )
}

export default UserRepo