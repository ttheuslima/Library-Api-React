import React from "react";
// import { RotasPag } from './Rotas/rotas'
import {RouterProvider, createBrowserRouter, createRoutesFromElements ,Route, Outlet} from 'react-router-dom'

import {Home} from './Pages/Home/home'
import {Testando} from './Pages/TestingPage/testing'
import Carrousel from './Carrousel'


export function App() {  
    const router = createBrowserRouter(
        createRoutesFromElements(
             <Route path="/" element={<Root/>}>
                <Route index element={<Home/>}/>
                <Route path="/testando" element={<Testando/>}></Route>
                <Route path="/carrousel" element={<Carrousel/>}></Route>
            </Route>
    )
);
    return(
        <div className="App">
            <RouterProvider router={router}/>
         </div>
    )
}

const Root = () => {
    return(
 
     <div>
         <Outlet/>
     </div>
 
    )
 }