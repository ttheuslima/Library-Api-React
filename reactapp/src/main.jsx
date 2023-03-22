import React from 'react'
import ReactDOM from 'react-dom/client'
import { Home } from './Pages/Home/home'
// import Carrousel from './Carrousel/Index'
// import { App } from './App'
import SearchBar from './Searchbar/SearchBar copy'
import './Styles/global.css'

ReactDOM.createRoot(document.getElementById('root')).render(
  <React.StrictMode>
    {/* <SearchBar placeholder='enter a book name...'/> */}
    {/* <Carrousel/> */}
    <Home/>
  </React.StrictMode>
  
)
