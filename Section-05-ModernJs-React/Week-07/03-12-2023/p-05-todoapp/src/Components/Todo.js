import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faPenToSquare, faTrash } from '@fortawesome/free-solid-svg-icons';
import React from 'react';

const Todo = ({ task, toggleComplete, deleteTask, editTodo}) => {
    const confirmDelete = (id) => {
        let answer=window.confirm("Are you sure?");
        if (answer) {
            deleteTask(id);
        };
    }
    return (
        <>
            <div className='Todo'>
                <p className={task.completed ? "Completed TodoTask" : "TodoTask"} onClick={()=>{toggleComplete(task.id)}}>
                    {task.desc}
                </p>
                <div className="TodoButtons">
                    <FontAwesomeIcon onClick={() =>{editTodo(task.id)}} icon={faPenToSquare} />
                    <FontAwesomeIcon onClick= {() => confirmDelete(task.id)} icon={faTrash} />
                </div>
            </div>
        </>
    )
}

export default Todo;