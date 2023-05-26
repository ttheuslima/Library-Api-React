import React from 'react'
import ReactDOM from 'react-dom/client'
// import { Home } from './Pages/Home/home'
// import  { FormLogin } from './Pages/Form/form'
// import  { FormRegister } from './Pages/FormRegister/form'

//  import Carrousel from './Components/Carrousel/Index'
import { App } from './routes'
// import SearchBar from './Components/Searchbar/SearchBar'
import './Styles/global.css'

ReactDOM.createRoot(document.getElementById('root')).render(
  <React.StrictMode>
    <App/>
    {/* <Carrousel/> */}
  </React.StrictMode>
  
)
