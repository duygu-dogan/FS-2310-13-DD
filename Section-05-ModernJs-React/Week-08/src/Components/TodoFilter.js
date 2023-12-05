import React, { useContext } from 'react'
import { TodoContext } from '../Contexts/TodoContext';


const TodoFilter = () => {
    const context = useContext(TodoContext)
  return (
    <div>
          <div className='container-fluid d-flex p-2 mb-1 border rounded-1'>
              <button onClick={() => {context.setFilteredMode("all")}} className="btn btn-danger me-1" type='button' id="btn-show-all">All</button>
              <button onClick={() => { context.setFilteredMode(false) }} className="btn btn-success me-1" type='button' id="btn-show-pending">Pending</button>
              <button onClick={() => { context.setFilteredMode(true) }} className="btn btn-warning" type='button' id="btn-show-completed">Completed</button>
          </div>
    </div>
  )
}

export default TodoFilter
