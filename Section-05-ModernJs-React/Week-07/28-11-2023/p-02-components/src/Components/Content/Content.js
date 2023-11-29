import ProductContainer from "../ProductContainer/ProductContainer";
import "./Content.css";

function Content() {
  return (
    <>
    <h1 className="Title">Hoşgeldiniz</h1>
    <div className="Text-Container">
              <p className="Text">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras consectetur id enim et suscipit. Morbi eu sollicitudin dui, eu ultricies arcu. Duis condimentum dictum justo, at fermentum nulla pellentesque eget. Duis et sollicitudin neque. Etiam pretium dui leo, id lobortis nibh rhoncus vel. Ut semper vitae arcu non cursus. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. .</p>    
          </div>
    <button className="Btn-detail" type="button">Detay</button>
    <ProductContainer />
    
    </>
  )
}

export default Content;












//Class component kullanımı (rce)
// import React, { Component } from 'react'

// export class Content extends Component {
//   render() {
//     return (
//       <div>Content</div>
//     )
//   }
// }

// export default Content