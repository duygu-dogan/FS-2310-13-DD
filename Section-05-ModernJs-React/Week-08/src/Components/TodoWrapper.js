import React, { useState } from 'react'
import { TodoContext } from '../Contexts/TodoContext';
import TodoAddForm from './TodoAddForm'
import TodoContainer from './TodoContainer';
import TodoFilter from './TodoFilter';
import { v4 as idGenerate } from 'uuid';

const TodoWrapper = ({ tasks }) => {
    const [taskList, setTaskList] = useState(tasks);
    const [filteredMode, setFilteredMode] = useState("all")
    const addTask = _desc =>{
        setTaskList(
            [...taskList, {
                id: idGenerate(),
                desc: _desc,
                isCompleted: false,
                isEditing: false
            }]
         )
         console.log(taskList);
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