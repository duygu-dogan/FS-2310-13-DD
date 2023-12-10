import React, { useContext} from 'react'
import SearchForm from "../../Components/SearchForm";
import Users from "../../Components/Users";
// import { AppContext } from '../../Contexts/AppContext';

const SearchPage = () => {
  // const context = useContext(AppContext)
  return (
    <>
      {/* Buraya search işlemi için bir component bir de sonuçları göstermek için bir component tasarlayacağız */}
      <SearchForm/>
      <Users />    
    </>
  )
}

export default SearchPage;