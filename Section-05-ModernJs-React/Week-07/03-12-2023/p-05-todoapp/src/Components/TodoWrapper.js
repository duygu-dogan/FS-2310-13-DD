import React, { useState } from 'react'
import TodoForm from './TodoForm';
import Todo from "./Todo";
import { v4 as uuidv4 } from 'uuid';
import TodoContainer from './TodoContainer';
import { isEditable } from '@testing-library/user-event/dist/utils';

const TodoWrapper = () => {
    let [todos, setTodos] = useState([]);
    const addTodo = todo => {
        setTodos([...todos, {
            id: uuidv4(),
            desc: todo,
            completed: false,
            isEditing: false
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
    
    const editTodo = (id) =>{
        setTodos(
            todos.map((todo) =>{
                return todo.id==id ? {...todo, isEditing: !todo.isEditing} : todo
            })
        )
    }

    const saveTodo = (id, value) => {
        setTodos(
            todos.map((todo) =>
                todo.id == id ? {...todo, desc: value, isEditing: !todo.isEditing} : todo
            )
        );
    }
    return (
        <>
            <div className='TodoWrapper'>
                <h1 className=''>
                    FS-2310-13 ToDo App</h1>

                <TodoForm addTodo={addTodo} todos={todos} />
                
                <TodoContainer todos={todos} toggleComplete={toggleComplete} deleteTask={deleteTask}
                editTodo = {editTodo}
                saveTodo = {saveTodo} />
                
            </div>


        </>
    )
}

export default TodoWrapper