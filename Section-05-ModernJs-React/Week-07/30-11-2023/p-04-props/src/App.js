import { useState } from 'react';
import './App.css';
import ProductList from './Components/ProductList/ProductList';
import TickTock from './Components/TickTock/TickTock';

function App() {
  // const firstName = "Duygu";
  // const lastName = "Dogan"
  // const age = 29;
  let products = [
    { id: 1, name: "iPhone 14", desc: "Hoş bir telefon", price: 43000 },
    { id: 2, name: "iPhone 15", desc: "Hoş bir telefon", price: 53000 },
    { id: 3, name: "iPhone 16", desc: "Hoş bir telefon", price: 63000 },
    { id: 4, name: "iPhone 17", desc: "Hoş bir telefon", price: 73000}
  ]

 let [number, setNumber] = useState(10);
  function numberAdd(){
    setNumber(++number);
  }

  return (
    <>
    <div>
        {/* <TickTock firstName={firstName} lastName={lastName} age={age} />
        <TickTock firstName={"Kadir"} lastName={"İnce"} age={"35"}  /> */}
        <button onClick={numberAdd}>Click</button>
        <label>{number}</label>

        <ProductList products={products} />
      </div>
    </>
  );
}

export default App;
