import React, { useContext } from 'react'
import { TodoContext } from '../Contexts/TodoContext';

const Todo = ({task}) => {
    const context =useContext(TodoContext)
    return (
        <>
            <div>
                <li className={
                    task.isCompleted ? "d-flex justify-content-between list-group-item rounded-3 mb-1 text-decoration-line-through" : "d-flex justify-content-between list-group-item rounded-3 mb-1"}>
                    <div>{task.desc}</div>
                    <div>
                        <button className="btn btn-warning btn-sm me-1" type="button">Edit</button>
                        <button className="btn btn-danger btn-sm" type="button" onClick={() => context.deleteTask(task.id)} >Delete</button>
                    </div>
                    </li>
            </div>
        </>
        //   <div className='container w-75'>
        //       <div className="input-group">
        //           <div className="input-group-text">
        //               <input className="form-check-input mt-0" type="checkbox" value={context.addTask.desc} id='checkbox' />
        //           </div>
        //           <label htmlFor="checkbox" type="text" className="form-control" />
        //           <button className="btn btn-warning" type="button">Edit</button>
        //           <button className="btn btn-danger" type="button">Delete</button>
        //       </div>
        //   </div>
    )
}

export default Todo;