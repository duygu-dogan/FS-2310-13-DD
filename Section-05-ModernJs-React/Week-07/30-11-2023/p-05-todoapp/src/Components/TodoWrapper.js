import React, { useState } from 'react'
import TodoForm from './TodoForm'
import { v4 as uuidv4 } from 'uuid';

const TodoWrapper = () => {
    let [todos, setTodo] = useState([]);
    const addTodo = todo => {
        setTodo([...todos, {
            id: uuidv4(),
            desc: todo,
            completed: false
        }]);
    };
    return (
        <>
            <div className='TodoWrapper'>
                <h1 className=''>
                    FS-2310-13 ToDo App
                    <TodoForm addTodo={addTodo}/>
                </h1>



            </div>


        </>
    )
}

export default TodoWrapper