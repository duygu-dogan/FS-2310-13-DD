import React, { useState } from 'react'
import TodoForm from './TodoForm';
import Todo from "./Todo";
import { v4 as uuidv4 } from 'uuid';
import TodoContainer from './TodoContainer';

const TodoWrapper = () => {
    let [todos, setTodos] = useState([]);
    const addTodo = todo => {
        setTodos([...todos, {
            id: uuidv4(),
            desc: todo,
            completed: false
        }]);
    };

    const toggleComplete = (id) => {
        setTodos(
            todos.map((todo) => todo.id == id ? { ...todo, completed: !todo.completed } : todo)
        );
    }

    const deleteTask = (id) => setTodos(
        todos.filter((todo) => todo.id != id));

    // const deleteTaskAlternative = (id) => {
    //     let newTodos=[];
    //     for (let i = 0; i < todos.length; i++){
    //         if(todos.id != id){
    //             newTodos.push(todos[i]);
    //         }
    //     };
    // };

    return (
        <>
            <div className='TodoWrapper'>
                <h1 className=''>
                    FS-2310-13 ToDo App</h1>

                <TodoForm addTodo={addTodo} todos={todos} />
                
                <TodoContainer todos={todos} toggleComplete={toggleComplete} deleteTask={deleteTask} />
                

            </div>


        </>
    )
}

export default TodoWrapper