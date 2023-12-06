import React, { useContext, useState } from 'react'
import { TodoContext } from '../Contexts/TodoContext';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faCirclePlus } from '@fortawesome/free-solid-svg-icons';


const TodoAddForm = () => {
  const context = useContext(TodoContext)
  const [desc, setDesc] = useState("");
  const handleSubmit = (e) => {
    e.preventDefault();
    if (desc) {
      context.addTask(desc);
      setDesc("");
      e.target.firstChild.firstChild.focus();
    } else {
      alert("Please add a task")
    }
  }

  return (
    <>
      <div className='container-fluid g-0'>
        <h1 className='display-5 text-center title mb-4 text-danger fw-semibold'>Todo App</h1>
        <form onSubmit={handleSubmit}>
          <div className="input-group mb-3">
            <input onChange={(e) => setDesc(e.target.value)} value={desc} type="text" className="form-control"
              placeholder="what is today's task?" aria-describedby="button-addon2" />
            <button className="btn btn-success" type="submit" id="btn-add-task">
              {/* <FontAwesomeIcon icon={faCirclePlus} size='xl' /> */}
              <FontAwesomeIcon icon={faCirclePlus} className='fs-3' />
              </button>
            <button onClick={() => context.clearAll()} className="btn btn-danger" type='button' id="btn-clear-all">Clear All</button>
          </div>
        </form>
      </div>
    </>
  )
}

export default TodoAddForm;