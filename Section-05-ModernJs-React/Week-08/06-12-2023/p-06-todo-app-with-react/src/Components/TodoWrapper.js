import React, { useState, useEffect } from 'react'
import { TodoContext } from '../Contexts/TodoContext';
import TodoAddForm from './TodoAddForm'
import TodoContainer from './TodoContainer';
import TodoFilter from './TodoFilter';
import { v4 as idGenerate } from 'uuid';

const TodoWrapper = () => {
    const [taskList, setTaskList] = useState(
        localStorage.getItem("todo-app-react")  != null ? JSON.parse(localStorage.getItem("todo-app-react")) : [] );
    const [filteredMode, setFilteredMode] = useState("all");

    useEffect(() => {
        getLocalStorage();  
    }, []);
    useEffect(() => {
      setLocalStorage();
    }, [taskList])
    
   
    const addTask = _desc =>{
        setTaskList(
            [...taskList, {
                id: idGenerate(),
                desc: _desc,
                isCompleted: false,
                isEditing: false
            }]
         )
    }

    const toggleComplete = _id => {
        setTaskList(
            taskList.map(task=>
                _id === task.id ? {...task, isCompleted: !task.isCompleted} : task)
        )
    };

    const deleteTask = _id =>{
        setTaskList(
            taskList.filter(task => task.id !== _id)
        )
    };

    const toggleEditing = _id => {
        setTaskList(
            taskList.map (task => _id === task.id ? {...task, isEditing: true} : {...task, isEditing: false})
        )
    };

    const updateTask = (_id, _desc) => {
        setTaskList(
            taskList.map(task => task.id === _id ? {...task, desc: _desc, isEditing: !task.isEditing}: task)
        )
    };

    const clearAll = () => {
        setTaskList([])
    };
    
    
    const setLocalStorage =() =>{
        localStorage.setItem("todo-app-react", JSON.stringify(taskList));
    }
    const getLocalStorage = () =>{
       let item = localStorage.getItem("tod0-app-react");
       if (item != null) {
        setTaskList(JSON.parse(item))
       }

    }

    return (
        <TodoContext.Provider value={{taskList, addTask, toggleComplete, deleteTask, toggleEditing, updateTask, clearAll, filteredMode, setFilteredMode}}>
            <div className='container sm-w-50 lg-w-50 p-5'>
            <TodoAddForm/>
                <TodoFilter />
            <TodoContainer/>
            </div>
        </TodoContext.Provider>
    )
}

export default TodoWrapper;