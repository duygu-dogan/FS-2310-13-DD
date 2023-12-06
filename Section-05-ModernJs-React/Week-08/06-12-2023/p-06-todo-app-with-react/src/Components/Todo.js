import React, { useContext } from 'react'
import { TodoContext } from '../Contexts/TodoContext';
import { faPenToSquare, faTrashCan } from '@fortawesome/free-solid-svg-icons';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';

const Todo = ({task}) => {
    const context =useContext(TodoContext)
    return (
        <>
            <div>
                <li className={
                    task.isCompleted ? "d-flex justify-content-between list-group-item rounded-3 mb-1 text-decoration-line-through text-danger align-items-center" : "d-flex justify-content-between list-group-item rounded-3 mb-1 align-items-center"}>
                    <div onClick={()=> {context.toggleComplete(task.id)}} className='w-75' role='button'>{task.desc}</div>
                    <div>
                        <button className="btn btn-warning btn-sm me-1" onClick={() => context.toggleEditing(task.id)} type="button"><FontAwesomeIcon icon={faPenToSquare} /></button>
                        <button className="btn btn-danger btn-sm" type="button" onClick={() => context.deleteTask(task.id)} ><FontAwesomeIcon icon={faTrashCan} /></button>
                    </div>
                    </li>
            </div>
        </>
    )
}

export default Todo;