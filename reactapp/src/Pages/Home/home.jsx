import React from "react";
import "./homeStyle.css";
// import { Card } from "../../Components/Card";

import Carrousel from "../../Components/Carrousel/Index";
import Header from "../../Components/HomeHeader/header";
import Footer from "../../Components/homeFooter/footer";



export function Home() {
   


  return (
    <>
    <div>
    <Header/> 
    </div>
    
      
      <main>

         <Carrousel/> 
      </main>
      
      <footer>
        
        <Footer/>
      </footer>
    </>
  );
        }