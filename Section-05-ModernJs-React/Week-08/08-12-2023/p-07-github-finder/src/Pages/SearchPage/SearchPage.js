import React from 'react'
import SearchForm from '../../Components/SearchForm';
import Users from '../../Components/Users';

const SearchPage = () => {
  return (
    <>
      {/* Buraya search işlemi için bir component bir de sonuçları göstermek için bir component tasarlayacağız */}
      <SearchForm/>
      <Users />
    </>
  )
}

export default SearchPage;