import React from 'react'
import Product from '../Product/Product';

function ProductList({ products }) {
  return (
    <>
      {
        products.map(p => <Product key={p.id} product={p} />)
      }
      {/* Yukarıdaki map satırında yapılan işlem:
      <Product product={products[0]} 
      <Product product={products[1]} 
      <Product product={products[2]} 
      <Product product={products[3]} */}
    </>
  )
}

export default ProductList;