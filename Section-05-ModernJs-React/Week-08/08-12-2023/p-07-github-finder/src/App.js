import { BrowserRouter, Route, Routes } from 'react-router-dom';
import './App.css';
import Header from './Components/Header';
import Homepage from './Pages/Homepage/Homepage';
import SearchPage from './Pages/SearchPage/SearchPage';
import Footer from './Pages/Footer/Footer';
import { AppContext } from './Contexts/AppContext';
import { useEffect, useState } from 'react';
import Axios from 'axios';
import UserDetailsPage from './Pages/UserDetailsPage/UserDetailsPage'

function App() {
  const [users, setUsers] = useState([]);
  const [user, setUser] = useState({});
  const [userRepos, setUserRepos] = useState([]);
  const token = "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";
  const config = {headers: {Authorization: `Bearer ${token}`}}
  const searchUsers = (keyword) => {
    Axios.get("https://api.github.com/users", config)
        .then((response)=>{
          setUsers(response.data);
        })
  }

  const getUser = (userName) =>{
      Axios
        .get(`https://api.github.com/users/${userName}`, config)
        .then(response => {setUser(response.data)});
  }
  const getRepos = (userName) =>{
    Axios
      .get(`https://api.github.com/users/${userName}/repos`, config)
      .then(response => {setUserRepos(response.data)})
  }

  // const searchUser = (_userName) => {
  //   users.filter(user => _userName == user)}

  useEffect(()=>{
  searchUsers();
  },[]);
  return (
    <>
    <AppContext.Provider value={{users, getUser, user, userRepos, getRepos}}>
      <BrowserRouter>
        <Header />
        <Routes>
          <Route path = "/" element={<Homepage/>} />
          <Route path='/search' element= {<SearchPage/>} />
            <Route path="/getuser/:login" element={<UserDetailsPage />} />

        </Routes>
        <Footer/>
      </BrowserRouter>
      </AppContext.Provider>
    </>
  );
}

export default App;
