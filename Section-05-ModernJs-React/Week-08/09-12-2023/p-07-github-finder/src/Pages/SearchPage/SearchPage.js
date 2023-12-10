import React, { useState } from 'react'
import SearchForm from '../../Components/SearchForm';
import Users from '../../Components/Users';

const SearchPage = () => {
  // const [results, setResults] = useState(<Users/>)

    // const getResults = (input) => { setResults(results.filter(user => user.login == input))};
    
    // useEffect(()=>{
    //     setResult();
    //     getResults()
    // }, []);
  // useEffect(() => {
  //   context.getuser(input);
  // }, [input]);

  return (
    <>
      {/* Buraya search işlemi için bir component bir de sonuçları göstermek için bir component tasarlayacağız */}
      <SearchForm />

      <Users />
    </>
  )
}

export default SearchPage;