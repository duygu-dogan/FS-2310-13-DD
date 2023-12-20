import { BrowserRouter, Route, Routes } from 'react-router-dom';
import './App.css';
import Header from './Components/Header';
import Homepage from './Pages/Homepage/Homepage'
import SearchPage from './Pages/SearchPage/SearchPage';
import Footer from './Pages/Footer/Footer';
import { AppContext } from './Contexts/AppContext';
import { useEffect, useState } from 'react';
import Axios from 'axios';


function App() {
  const [users, setUsers] = useState([]);
  const [user, setUser] = useState({});
  const [userRepos, setUserRepos] = useState([]);
  const [isClearBtnShow, setIsClearBtnShow] = useState(false);
  const [keyword, setKeyword] = useState("");
  const [searchBar, setSearchBar] = useState([]);


  const token = "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";
  const config = { headers: { Authorization: `Bearer ${token}` } }

  const getAllUsers = () => {
    Axios.get(`https://api.github.com/users`, config)
      .then((response) => {
        setUsers(response.data);
      })
  };

  const searchUsers = (keyword) => {
    Axios.get(`https://api.github.com/search/users?q=${keyword}`, config)
      .then((response) => {
        setUsers(response.data.items);
        response.data.items.length == 0 ? setIsClearBtnShow(false) : setIsClearBtnShow(true)
      })
  };

  const getUser = (userName) => {
    Axios
      .get(`https://api.github.com/users/${userName}`, config)
      .then(response => { setUser(response.data) });
  }
  const getRepos = (userName) => {
    Axios
      .get(`https://api.github.com/users/${userName}/repos`, config)
      .then(response => { setUserRepos(response.data) })
  }

  const handleClearAllClick = () => {
    getAllUsers();
    setKeyword("");
    setIsClearBtnShow(false);
  };

  return (
    <>
      <AppContext.Provider value={{ users, getUser, user, userRepos, getRepos, searchUsers, setUsers, getAllUsers, setUser, setIsClearBtnShow, isClearBtnShow, keyword, setKeyword, handleClearAllClick }}>
        <BrowserRouter>
          <Header />
          <Routes>
            <Route path="/" element={<Homepage/>}/>
            <Route path='/search' element={<SearchPage />} />

          </Routes>
          <Footer />
        </BrowserRouter>
      </AppContext.Provider>
    </>
  );
}

export default App;
