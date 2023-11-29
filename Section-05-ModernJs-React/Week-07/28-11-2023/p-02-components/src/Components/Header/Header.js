//return scope'unun içinde (return edeceğimiz element) tek bir element olmalı. Yazılacak her şey bir kapsayıcı elementin içinde olmalı. div veya refragment (<></>) kullanılabilir.
import "./Header.css";

function Header() {
  return (
    <>
    <div className="Header">
        <h1>Component Uygulaması</h1>

    </div>
    
    </>
    )
}

export default Header;