import './App.css';
import ProductList from './Components/ProductList/ProductList';
import TickTock from './Components/TickTock/TickTock';

function App() {
  // const firstName = "Duygu";
  // const lastName = "Dogan"
  // const age = 29;
  let products = [
    { id: 1, name: "iPhone 14", desc: "Hoş bir telefon", price: 43000 },
    { id: 1, name: "iPhone 15", desc: "Hoş bir telefon", price: 53000 },
    { id: 1, name: "iPhone 16", desc: "Hoş bir telefon", price: 63000 },
    { id: 1, name: "iPhone 17", desc: "Hoş bir telefon", price: 73000}
  ]
  return (
    <>
    <div>
        {/* <TickTock firstName={firstName} lastName={lastName} age={age} />
        <TickTock firstName={"Kadir"} lastName={"İnce"} age={"35"}  /> */}
        <ProductList products={products} />
      </div>
    </>
  );
}

export default App;
