import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faPenToSquare, faTrash } from '@fortawesome/free-solid-svg-icons';
import React from 'react';

const Todo = ({ task, toggleComplete, deleteTask }) => {
    return (
        <>
            <div className='Todo'>
                <p className={task.completed ? "Completed TodoTask" : "TodoTask"} onClick={()=>{toggleComplete(task.id)}}>
                    {task.desc}
                </p>
                <div className="TodoButtons">
                    <FontAwesomeIcon icon={faPenToSquare} />
                    <FontAwesomeIcon onClick={() => deleteTask(task.id)} icon={faTrash} />
                </div>
            </div>
        </>
    )
}

export default Todo;