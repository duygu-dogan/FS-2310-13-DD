import { useEffect, useState } from 'react';
import './App.css';
import TodoWrapper from './Components/TodoWrapper';
import { v4 as idGenerate } from 'uuid';

// const INITIAL_STATE = [
//   { id: idGenerate(), desc: "Tezi düzenle", isCompleted: false, isEditing: false },
//   { id: idGenerate(), desc: "Toz Bezi'ni izle", isCompleted: false, isEditing: false },
//   { id: idGenerate(), desc: "May December'ı izle", isCompleted: true, isEditing: false },
//   { id: idGenerate(), desc: "Sigara al", isCompleted: false, isEditing: false },
//   { id: idGenerate(), desc: "JavaScript konferansını unutma", isCompleted: false, isEditing: false },
// ];
function App() {
  return (
    <>
      <TodoWrapper />
    </>
  )
}

export default App;
